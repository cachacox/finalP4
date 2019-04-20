Imports Logica
Public Class frmInsertar
    Private Sub frmInsertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As DataTable
        Dim s As String
        Dim sb As Integer
        dttFecha = Now()
        cbxPrioridad.SelectedIndex = 0
        cbxModulo.SelectedIndex = 0
        x = AccesoLogica.LastRow()
        s = x.Rows(0).Item(0)
        sb = Convert.ToInt32(Strings.Mid(s, 3) + 1)
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
                txtHoras.Text = "288"
                DeterminaHoras(cbxPrioridad.SelectedItem)
        End Select
    End Sub

    Sub DeterminaHoras(_str)
        Dim estimado As DateTime
        If dttFecha <> Nothing Then
            Select Case _str
                Case "Emergencia"
                    estimado = dttFecha.AddHours(4.5)
                    txtFechaEstimada.Text = estimado
                Case "Alta"
                    estimado = dttFecha.AddHours(26)
                    txtFechaEstimada.Text = estimado
                Case "Media"
                    'falta
                    estimado = dttFecha.AddHours(32)
                    txtFechaEstimada.Text = estimado
                Case "Baja"
                    'falta
                    estimado = dttFecha.AddHours(288)
                    txtFechaEstimada.Text = estimado
            End Select
        End If
    End Sub
End Class