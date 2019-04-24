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

    'Private Sub Form1_Load(sender As Object, e As EventArgs)

    'End Sub

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
        strGlobalIncid = txtPrincIncidente.Text
        Dim intRespuesta As Integer = MsgBox("Desea borrar el Incidente " + strGlobalIncid + "?", vbYesNo)
        If intRespuesta = 6 Then
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

    Sub DeterminaHoras(_str)
        Dim estimado As DateTime
        Dim _ano As Integer = Date.Today.Year
        Dim _mes As Integer = Date.Today.Month
        Dim _dia As Integer = Date.Today.Day
        'Dim _temp As Integer = 23 'borrar esto, es para pruebas
        Dim _hora As Decimal = Math.Round(Now().Hour + (Now().Minute / 60), 2)
        Dim _fechas As Date = Today()
        Dim _flag As Boolean = False
        Dim strFecha As String
        Dim intLen As Integer

        If _fechas.DayOfWeek = DayOfWeek.Saturday Then
            _dia = _dia + 2
        ElseIf _fechas.DayOfWeek = DayOfWeek.Sunday Then
            _dia = _dia + 1
        End If

        If dttfecha1 <> Nothing Then
            Dim __flag As Boolean = _compare()
            Select Case _str
                Case "Emergencia"
                    If Not __flag Then
                        estimado = dttfecha1.AddHours(4.5)
                        txtPrincFechaEst.Text = estimado
                    Else
                        txtPrincFechaEst.Text = _datemp
                    End If
                Case "Alta"
                    If Not __flag Then
                        estimado = dttfecha1.AddHours(26)
                        txtPrincFechaEst.Text = estimado
                    Else
                        txtPrincFechaEst.Text = _datemp
                    End If

                    'Case "Media"
                    '    Dim startime As DateTimeOffset
                    '    Dim startOfShift As DateTimeOffset
                    '    Dim intDiff As Double
                    '    startime = New DateTimeOffset(_ano, _mes, _dia, 0, 0, 0, DateTimeOffset.Now.Offset) 'volver a poner _dia
                    '    startOfShift = startime.AddHours(8)
                    '    If _hora >= 16 And _fechas.DayOfWeek <> DayOfWeek.Saturday And _fechas.DayOfWeek <> DayOfWeek.Sunday Then
                    '        startOfShift = startOfShift.AddDays(1)
                    '    End If
                    '    Dim intHoras As Integer = 0
                    '    If _fechas.DayOfWeek = DayOfWeek.Saturday Or _fechas.DayOfWeek = DayOfWeek.Sunday Then
                    '        While (intHoras < 32)
                    '            If startOfShift.Hour = 16 Then
                    '                intHoras = intHoras + 8
                    '            End If
                    '            startOfShift = startOfShift.AddHours(8)
                    '        End While
                    '        strFecha = startOfShift.AddHours(-8).ToString
                    '        intLen = strFecha.Length - 7
                    '        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    '    Else
                    '        If _hora > startOfShift.Hour And _flag = False Then
                    '            intDiff = Math.Round((_hora - startOfShift.Hour), 2)
                    '            If intDiff > 8 Then
                    '                intDiff = intDiff - Int(intDiff)
                    '            End If
                    '            _flag = True
                    '        End If
                    '        While (intHoras < 32)
                    '            If startOfShift.Hour = 16 Then
                    '                intHoras = intHoras + 8
                    '            End If
                    '            startOfShift = startOfShift.AddHours(8)
                    '            If startOfShift.DayOfWeek = DayOfWeek.Saturday And intHoras < 32 Then
                    '                startOfShift = startOfShift.AddDays(2)
                    '            ElseIf startOfShift.DayOfWeek = DayOfWeek.Sunday And intHoras < 32 Then
                    '                startOfShift = startOfShift.AddDays(1)
                    '            End If
                    '        End While
                    '        If intDiff > 0 Then
                    '            strFecha = startOfShift.AddHours(8 + intDiff).ToString
                    '            intLen = strFecha.Length - 7
                    '        Else
                    '            strFecha = startOfShift.AddHours(-8).ToString
                    '            intLen = strFecha.Length - 7
                    '        End If
                    '        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    '    End If
                    'Case "Baja"
                    '    '96 horas
                    '    Dim startime As DateTimeOffset
                    '    Dim startOfShift As DateTimeOffset
                    '    Dim intDiff As Double
                    '    startime = New DateTimeOffset(_ano, _mes, _dia, 0, 0, 0, DateTimeOffset.Now.Offset) 'volver a poner _dia
                    '    startOfShift = startime.AddHours(8)
                    '    If _hora >= 16 And _fechas.DayOfWeek <> DayOfWeek.Saturday And _fechas.DayOfWeek <> DayOfWeek.Sunday Then
                    '        startOfShift = startOfShift.AddDays(1)
                    '    End If
                    '    Dim intHoras As Integer = 0
                    '    If _fechas.DayOfWeek = DayOfWeek.Saturday Or _fechas.DayOfWeek = DayOfWeek.Sunday Then
                    '        While (intHoras < 96)
                    '            If startOfShift.Hour = 16 Then
                    '                intHoras = intHoras + 8
                    '            End If
                    '            startOfShift = startOfShift.AddHours(8)
                    '            If startOfShift.DayOfWeek = DayOfWeek.Saturday And intHoras < 96 Then
                    '                startOfShift = startOfShift.AddDays(2)
                    '            ElseIf startOfShift.DayOfWeek = DayOfWeek.Sunday And intHoras < 96 Then
                    '                startOfShift = startOfShift.AddDays(1)
                    '            End If
                    '        End While
                    '        strFecha = startOfShift.AddHours(-8).ToString
                    '        intLen = strFecha.Length - 7
                    '        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    '    Else
                    '        'este if es si ya empezó el día, por ejemplo, el tiquete lo abren después de las 8
                    '        If _hora > startOfShift.Hour And _flag = False Then
                    '            intDiff = Math.Round((_hora - startOfShift.Hour), 2)
                    '            If intDiff > 8 Then
                    '                intDiff = intDiff - Int(intDiff)
                    '            End If
                    '            _flag = True
                    '        End If
                    '        While (intHoras < 96)
                    '            If startOfShift.Hour = 16 Then
                    '                intHoras = intHoras + 8
                    '            End If
                    '            startOfShift = startOfShift.AddHours(8)
                    '            If startOfShift.DayOfWeek = DayOfWeek.Saturday And intHoras < 96 Then
                    '                startOfShift = startOfShift.AddDays(2)
                    '            ElseIf startOfShift.DayOfWeek = DayOfWeek.Sunday And intHoras < 96 Then
                    '                startOfShift = startOfShift.AddDays(1)
                    '            End If
                    '        End While
                    '        If intDiff > 0 Then
                    '            strFecha = startOfShift.AddHours(8 + intDiff).ToString
                    '            intLen = strFecha.Length - 7
                    '        Else
                    '            strFecha = startOfShift.AddHours(-8).ToString
                    '            intLen = strFecha.Length - 7
                    '        End If
                    '        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    '    End If
            End Select
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        'acá va el insert al sql again
        ButtonInsertar.Visible = True
        ButtonEliminar.Visible = True
        ButtonModificar.Visible = True
        ButtonActualizar.Visible = False
        cbxPrincModulo.Enabled = False
        dtpPrincResol.Enabled = False
        dtpPrincAsignado.Enabled = False
        cbxPrincPrioReal.Enabled = False
        txtPrincUsuario.Enabled = False
        lblRecalc.Visible = False
        txtRecal.Visible = False
        renewTabla()
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
        _datemp = txtPrincFechaEst.Text
        dtpPrincAsignado.Value = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(7).Value
        dtpPrincResol.Value = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(8).Value
        txtPrincEstado.Text = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(9).Value
        cbxPrincModulo.SelectedItem = DataGridViewPrincipal.Rows(intGlobalIndex).Cells(10).Value
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonActualizar.Visible = False
        ProgressBar.Visible = False
        LabelCargando.Visible = False
        renewTabla()
        dttfecha1 = Convert.ToDateTime(txtPrincFechaCrea.Text)
        _datemp = txtPrincFechaEst.Text
    End Sub

    Function _compare()
        Dim x As Boolean = False
        Dim strA As String = txtPrincPrioridad.Text
        Dim strB As String = cbxPrincPrioReal.SelectedItem
        If strA.Equals(strB) Then
            x = True
        End If
        Return x
    End Function

    Private Sub cbxPrincPrioReal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPrincPrioReal.SelectedIndexChanged
        If txtPrincFechaEst.Text <> "" Then
            dttfecha1 = Convert.ToDateTime(txtPrincFechaCrea.Text)
        End If

        Select Case cbxPrincPrioReal.SelectedItem
            Case "Emergencia"
                txtRecal.Text = "4"
                DeterminaHoras(cbxPrincPrioReal.SelectedItem)
            Case "Alta"
                txtRecal.Text = "26"
                DeterminaHoras(cbxPrincPrioReal.SelectedItem)
            Case "Media"
                txtRecal.Text = "32"
                DeterminaHoras(cbxPrincPrioReal.SelectedItem)
            Case "Baja"
                txtRecal.Text = "96"
                DeterminaHoras(cbxPrincPrioReal.SelectedItem)
        End Select
    End Sub
End Class
