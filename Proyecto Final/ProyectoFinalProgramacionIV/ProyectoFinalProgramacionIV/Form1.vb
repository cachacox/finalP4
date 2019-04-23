Imports Logica
Imports System
Imports System.Windows.Forms
Public Class Form1

    Sub ColoresTalbla()
        For i As Integer = 0 To DataGridViewPrincipal.Rows.Count - 1
            If DataGridViewPrincipal.Rows(i).Cells(9).Value.ToString = "Prorroga" Then
                DataGridViewPrincipal.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf DataGridViewPrincipal.Rows(i).Cells(9).Value.ToString = "Resuelto a Tiempo" Then
                DataGridViewPrincipal.Rows(i).DefaultCellStyle.BackColor = Color.LawnGreen
            ElseIf DataGridViewPrincipal.Rows(i).Cells(9).Value.ToString = "Resuelto NO a Tiempo" Then
                DataGridViewPrincipal.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf DataGridViewPrincipal.Rows(i).Cells(9).Value.ToString = "Resuelto en Prorroga" Then
                DataGridViewPrincipal.Rows(i).DefaultCellStyle.BackColor = Color.LawnGreen
            ElseIf DataGridViewPrincipal.Rows(i).Cells(9).Value.ToString = "Resuelto en SLAHOLD" Then
                DataGridViewPrincipal.Rows(i).DefaultCellStyle.BackColor = Color.LawnGreen
            End If
        Next
    End Sub

    Public Shared Sub renewTabla()
        tbldtgPrincipal = AccesoLogica.CargarTabla()
        If tbldtgPrincipal.Rows.Count > 0 Then
            Form1.DataGridViewPrincipal.DataSource = tbldtgPrincipal
            Form1.ColoresTalbla()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        ButtonActualizar.Visible = False
        ProgressBar.Visible = False
        LabelCargando.Visible = False
        renewTabla()
    End Sub

    Private Sub ButtonModulosAfectados_Click(sender As Object, e As EventArgs) Handles ButtonModulosAfectados.Click
        Dim VentanaModulosAfectados = New ModulosAfectados()
        VentanaModulosAfectados.ShowDialog()
    End Sub

    Private Sub ButtonIncidentesMora_Click(sender As Object, e As EventArgs) Handles ButtonIncidentesMora.Click
        Dim VentanaIncidentesMora = New IncidentesMora()
        VentanaIncidentesMora.ShowDialog()
    End Sub

    Private Sub ButtonIncidentesPendientes_Click(sender As Object, e As EventArgs) Handles ButtonIncidentesPendientes.Click
        Dim VentanaIncidentesPendientes = New IncidentesPendientes()
        VentanaIncidentesPendientes.ShowDialog()
    End Sub

    Private Sub ButtonIncidentesNuevos_Click(sender As Object, e As EventArgs) Handles ButtonIncidentesNuevos.Click
        Dim VentanaIncidentesNuevos = New IncidentesNuevos()
        VentanaIncidentesNuevos.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonIncidentesResueltos.Click
        Dim VentanaIncidentesResueltos = New IncidentesResueltos()
        VentanaIncidentesResueltos.ShowDialog()
    End Sub

    Private Sub ButtonInsertar_Click(sender As Object, e As EventArgs) Handles ButtonInsertar.Click
        Dim frmInsert = New frmInsertar()
        frmInsertar.ShowDialog()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim intRespuesta As Integer = MsgBox("Desea borrar la carrera?", vbYesNo)
        If intRespuesta = 6 Then
            strGlobalIncid = txtPrincIncidente.Text
            AccesoLogica.BorrarInfo(strGlobalIncid)
            renewTabla()
        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        ButtonInsertar.Visible = False
        ButtonEliminar.Visible = False
        ButtonModificar.Visible = False
        ButtonActualizar.Visible = True

        cbxPrincModulo.Enabled = True
        dtpPrincResol.Enabled = True
        dtpPrincAsignado.Enabled = True
        cbxPrincPrioReal.Enabled = True
        txtPrincUsuario.Enabled = True
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ButtonInsertar.Visible = True
        ButtonEliminar.Visible = True
        ButtonModificar.Visible = True
        ButtonActualizar.Visible = False

    End Sub

    Private Sub ButtonCargarExcel_Click(sender As Object, e As EventArgs) Handles ButtonCargarExcel.Click
        DataGridViewPrincipal.DataSource = AccesoLogica.CargarExcel()
        DataGridViewPrincipal.DataMember = "[Hoja1$]"
        ColoresTalbla()
    End Sub

    Private Sub ButtonGuardarData_Click(sender As Object, e As EventArgs) Handles ButtonGuardarData.Click

        ProgressBar.Visible = True
        LabelCargando.Visible = True
        ProgressBar.Value = 0

        Dim contador As Integer
        contador = 0

        For i As Integer = 0 To DataGridViewPrincipal.Rows.Count - 1
            contador = contador + 1
        Next

        ProgressBar.Minimum = 0
        ProgressBar.Maximum = contador

        Dim no_incidente As String
        Dim usuario As String
        Dim fecha_creacion As Date
        Dim prioridad As String
        Dim prioridad_real As String
        Dim horas As Integer
        Dim fech_estado As Date
        Dim fecha_asignado As Date
        Dim fecha_resultado As Date
        Dim estado As String
        Dim _mod As String

        For i As Integer = 0 To DataGridViewPrincipal.Rows.Count - 1

            no_incidente = DataGridViewPrincipal.Rows(i).Cells(0).Value
            usuario = DataGridViewPrincipal.Rows(i).Cells(1).Value
            fecha_creacion = DataGridViewPrincipal.Rows(i).Cells(2).Value
            prioridad = DataGridViewPrincipal.Rows(i).Cells(3).Value
            prioridad_real = DataGridViewPrincipal.Rows(i).Cells(4).Value
            horas = DataGridViewPrincipal.Rows(i).Cells(5).Value
            fech_estado = DataGridViewPrincipal.Rows(i).Cells(6).Value
            fecha_asignado = DataGridViewPrincipal.Rows(i).Cells(7).Value
            fecha_resultado = DataGridViewPrincipal.Rows(i).Cells(8).Value
            estado = DataGridViewPrincipal.Rows(i).Cells(9).Value
            If IsDBNull(DataGridViewPrincipal.Rows(i).Cells(10).Value) Then
                _mod = ""
            Else
                _mod = DataGridViewPrincipal.Rows(i).Cells(10).Value
            End If
            AccesoLogica.InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod)
            ProgressBar.Value = i
        Next
        MessageBox.Show("Se guardo la data satisfactoriamente")

        ProgressBar.Visible = False
        LabelCargando.Visible = False

    End Sub

    Private Sub DataGridViewPrincipal_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewPrincipal.SelectionChanged
        intGlobalIndex = DataGridViewPrincipal.CurrentCell.RowIndex
        txtPrincIncidente.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(0).Value
        txtPrincUsuario.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(1).Value
        txtPrincFechaCrea.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(2).Value
        txtPrincPrioridad.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(3).Value
        If DataGridViewPrincipal.Rows(intGlobalIndex).Cells(4).Value = "" Then
            cbxPrincPrioReal.SelectedIndex = 0
        Else
            Select Case DataGridViewPrincipal.Rows(intGlobalIndex).Cells(4).Value
                Case "Emergencia"
                    cbxPrincPrioReal.SelectedIndex = 1
                Case "Alta"
                    cbxPrincPrioReal.SelectedIndex = 2
                Case "Media"
                    cbxPrincPrioReal.SelectedIndex = 3
                Case "Baja"
                    cbxPrincPrioReal.SelectedIndex = 4
            End Select
        End If
        txtPrincHoras.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(5).Value
        txtPrincFechaEst.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(6).Value
        dtpPrincAsignado.Value = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(7).Value
        dtpPrincResol.Value = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(8).Value
        txtPrincEstado.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(9).Value
        cbxPrincModulo.SelectedItem = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(10).Value
    End Sub
End Class
