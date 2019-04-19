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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonActualizar.Visible = False
        ProgressBar.Visible = False
        LabelCargando.Visible = False
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

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        ButtonInsertar.Visible = False
        ButtonEliminar.Visible = False
        ButtonModificar.Visible = False
        ButtonActualizar.Visible = True
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

            AccesoLogica.InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado)

            ProgressBar.Value = i
        Next
        MessageBox.Show("Se guardo la data satisfactoriamente")

        ProgressBar.Visible = False
        LabelCargando.Visible = False

    End Sub

End Class
