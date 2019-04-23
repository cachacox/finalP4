Imports Logica
Imports ProyectoFinalProgramacionIV
Public Class frmInsertar
    Private Sub frmInsertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As DataTable
        Dim s As String
        Dim sb As Integer = 1
        dttFecha = Now()
        cbxPrioridad.SelectedIndex = 0
        cbxModulo.SelectedIndex = 0
        x = AccesoLogica.LastRow()
        If x.Rows.Count > 0 Then
            s = x.Rows(0).Item(0)
            sb = Convert.ToInt32(Strings.Mid(s, 3) + 1)
        End If
        lblNumINC.Text = sb
        lblFechaCreacion.Text = dttFecha
    End Sub

    Private Sub cbxPrioridad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPrioridad.SelectedIndexChanged
        Select Case cbxPrioridad.SelectedItem
            Case "Emergencia"
                txtHoras.Text = "4"
                DeterminaHoras(cbxPrioridad.SelectedItem)
            Case "Alta"
                txtHoras.Text = "26"
                DeterminaHoras(cbxPrioridad.SelectedItem)
            Case "Media"
                txtHoras.Text = "32"
                DeterminaHoras(cbxPrioridad.SelectedItem)
            Case "Baja"
                txtHoras.Text = "96"
                DeterminaHoras(cbxPrioridad.SelectedItem)
        End Select
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

        If dttFecha <> Nothing Then
            Select Case _str
                Case "Emergencia"
                    estimado = dttFecha.AddHours(4.5)
                    txtFechaEstimada.Text = estimado
                Case "Alta"
                    estimado = dttFecha.AddHours(26)
                    txtFechaEstimada.Text = estimado
                Case "Media"
                    Dim startime As DateTimeOffset
                    Dim startOfShift As DateTimeOffset
                    Dim intDiff As Double
                    startime = New DateTimeOffset(_ano, _mes, _dia, 0, 0, 0, DateTimeOffset.Now.Offset) 'volver a poner _dia
                    startOfShift = startime.AddHours(8)
                    If _hora >= 16 And _fechas.DayOfWeek <> DayOfWeek.Saturday And _fechas.DayOfWeek <> DayOfWeek.Sunday Then
                        startOfShift = startOfShift.AddDays(1)
                    End If
                    Dim intHoras As Integer = 0
                    If _fechas.DayOfWeek = DayOfWeek.Saturday Or _fechas.DayOfWeek = DayOfWeek.Sunday Then
                        While (intHoras < 32)
                            If startOfShift.Hour = 16 Then
                                intHoras = intHoras + 8
                            End If
                            startOfShift = startOfShift.AddHours(8)
                        End While
                        strFecha = startOfShift.AddHours(-8).ToString
                        intLen = strFecha.Length - 7
                        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    Else
                        If _hora > startOfShift.Hour And _flag = False Then
                            intDiff = Math.Round((_hora - startOfShift.Hour), 2)
                            If intDiff > 8 Then
                                intDiff = intDiff - Int(intDiff)
                            End If
                            _flag = True
                        End If
                        While (intHoras < 32)
                            If startOfShift.Hour = 16 Then
                                intHoras = intHoras + 8
                            End If
                            startOfShift = startOfShift.AddHours(8)
                            If startOfShift.DayOfWeek = DayOfWeek.Saturday And intHoras < 32 Then
                                startOfShift = startOfShift.AddDays(2)
                            ElseIf startOfShift.DayOfWeek = DayOfWeek.Sunday And intHoras < 32 Then
                                startOfShift = startOfShift.AddDays(1)
                            End If
                        End While
                        If intDiff > 0 Then
                            strFecha = startOfShift.AddHours(8 + intDiff).ToString
                            intLen = strFecha.Length - 7
                        Else
                            strFecha = startOfShift.AddHours(-8).ToString
                            intLen = strFecha.Length - 7
                        End If
                        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    End If
                Case "Baja"
                    '96 horas
                    Dim startime As DateTimeOffset
                    Dim startOfShift As DateTimeOffset
                    Dim intDiff As Double
                    startime = New DateTimeOffset(_ano, _mes, _dia, 0, 0, 0, DateTimeOffset.Now.Offset) 'volver a poner _dia
                    startOfShift = startime.AddHours(8)
                    If _hora >= 16 And _fechas.DayOfWeek <> DayOfWeek.Saturday And _fechas.DayOfWeek <> DayOfWeek.Sunday Then
                        startOfShift = startOfShift.AddDays(1)
                    End If
                    Dim intHoras As Integer = 0
                    If _fechas.DayOfWeek = DayOfWeek.Saturday Or _fechas.DayOfWeek = DayOfWeek.Sunday Then
                        While (intHoras < 96)
                            If startOfShift.Hour = 16 Then
                                intHoras = intHoras + 8
                            End If
                            startOfShift = startOfShift.AddHours(8)
                            If startOfShift.DayOfWeek = DayOfWeek.Saturday And intHoras < 96 Then
                                startOfShift = startOfShift.AddDays(2)
                            ElseIf startOfShift.DayOfWeek = DayOfWeek.Sunday And intHoras < 96 Then
                                startOfShift = startOfShift.AddDays(1)
                            End If
                        End While
                        strFecha = startOfShift.AddHours(-8).ToString
                        intLen = strFecha.Length - 7
                        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    Else
                        'este if es si ya empezó el día, por ejemplo, el tiquete lo abren después de las 8
                        If _hora > startOfShift.Hour And _flag = False Then
                            intDiff = Math.Round((_hora - startOfShift.Hour), 2)
                            If intDiff > 8 Then
                                intDiff = intDiff - Int(intDiff)
                            End If
                            _flag = True
                        End If
                        While (intHoras < 96)
                            If startOfShift.Hour = 16 Then
                                intHoras = intHoras + 8
                            End If
                            startOfShift = startOfShift.AddHours(8)
                            If startOfShift.DayOfWeek = DayOfWeek.Saturday And intHoras < 96 Then
                                startOfShift = startOfShift.AddDays(2)
                            ElseIf startOfShift.DayOfWeek = DayOfWeek.Sunday And intHoras < 96 Then
                                startOfShift = startOfShift.AddDays(1)
                            End If
                        End While
                        If intDiff > 0 Then
                            strFecha = startOfShift.AddHours(8 + intDiff).ToString
                            intLen = strFecha.Length - 7
                        Else
                            strFecha = startOfShift.AddHours(-8).ToString
                            intLen = strFecha.Length - 7
                        End If
                        txtFechaEstimada.Text = Strings.Left(strFecha, intLen)
                    End If
            End Select
        End If
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim strIncidente As String = ""
        Dim strNull As String = ""
        Dim datenull As DateTime = "1/1/1753 12:00:00 AM"
        strIncidente = "IN" + lblNumINC.Text
        If txtNombre.Text <> "" Then
            Try
                AccesoLogica.InsertarInfoExcel(strIncidente, txtNombre.Text, lblFechaCreacion.Text, cbxPrioridad.SelectedItem.ToString, strNull, txtHoras.Text, txtFechaEstimada.Text, datenull, datenull, txtEstado.Text, cbxModulo.SelectedItem.ToString)
                Dim x As DataTable
                Dim s As String
                Dim sb As Integer = 1
                x = AccesoLogica.LastRow()
                If x.Rows.Count > 0 Then
                    s = x.Rows(0).Item(0)
                    sb = Convert.ToInt32(Strings.Mid(s, 3) + 1)
                End If
                lblNumINC.Text = sb
                MsgBox("Incidente insertado exitosamente")
                Form1.renewTabla()
            Catch ex As Exception
                MsgBox("Error al insertar nuevo Incidente")
            End Try

        Else
            MsgBox("Debe llenar todos los espacios")
        End If
    End Sub
End Class