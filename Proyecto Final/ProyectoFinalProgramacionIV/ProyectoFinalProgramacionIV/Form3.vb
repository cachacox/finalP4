Imports Logica

Public Class IncidentesMora
    Private Sub IncidentesMora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesMora.DataSource = AccesoLogica.ResumenIncidentesMora
        ComboBoxFiltro.ValueMember = "No_Incidente"
        ComboBoxFiltro.DisplayMember = "modulo"
        ComboBoxFiltro.DataSource = AccesoLogica.ResumenIncidentesMora()
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        Dim inicio As DateTime = DateTimePickerInicio.Value.ToString
        Dim final As DateTime = DateTimePickerFinal.Value.ToString
        Dim modulo As String = ComboBoxFiltro.Text
        DataGridViewIncidentesMora.DataSource = AccesoLogica.FiltroRetrasados(inicio, final, modulo)
    End Sub

    Private Sub ButtonRestablecerFiltro_Click(sender As Object, e As EventArgs) Handles ButtonRestablecerFiltro.Click
        DataGridViewIncidentesMora.DataSource = New DataGridView()
        DataGridViewIncidentesMora.DataSource = AccesoLogica.ResumenIncidentesMora()
    End Sub
End Class