Imports Logica

Public Class IncidentesNuevos
    Private Sub IncidentesNuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesNuevos.DataSource = AccesoLogica.ResumenNuevos()
        ComboBoxFiltro.ValueMember = "No_Incidente"
        ComboBoxFiltro.DisplayMember = "modulo"
        ComboBoxFiltro.DataSource = AccesoLogica.ResumenNuevos()
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        Dim inicio As DateTime = DateTimePickerInicio.Value.ToString
        Dim final As DateTime = DateTimePickerFinal.Value.ToString
        Dim modulo As String = ComboBoxFiltro.Text
        DataGridViewIncidentesNuevos.DataSource = AccesoLogica.FiltroNuevos(inicio, final, modulo)
    End Sub

    Private Sub ButtonRestablecerFiltro_Click(sender As Object, e As EventArgs) Handles ButtonRestablecerFiltro.Click
        DataGridViewIncidentesNuevos.DataSource = New DataGridView()
        DataGridViewIncidentesNuevos.DataSource = AccesoLogica.ResumenNuevos()
    End Sub
End Class