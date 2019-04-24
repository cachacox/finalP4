Imports Logica

Public Class IncidentesResueltos
    Private Sub IncidentesResueltos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesResueltos.DataSource = AccesoLogica.ResumenIncidentesResueltos()
        ComboBoxFiltro.ValueMember = "No_Incidente"
        ComboBoxFiltro.DisplayMember = "modulo"
        ComboBoxFiltro.DataSource = AccesoLogica.ResumenCantidadPorModuloAfectado()
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        Dim inicio As DateTime = DateTimePickerInicio.Value.ToString
        Dim final As DateTime = DateTimePickerFinal.Value.ToString
        Dim modulo As String = ComboBoxFiltro.Text
        DataGridViewIncidentesResueltos.DataSource = AccesoLogica.FiltrarIncidentesResueltos(inicio, final, modulo)
    End Sub

    Private Sub ButtonRestablecerFiltro_Click(sender As Object, e As EventArgs) Handles ButtonRestablecerFiltro.Click
        DataGridViewIncidentesResueltos.DataSource = New DataGridView()
        DataGridViewIncidentesResueltos.DataSource = AccesoLogica.ResumenIncidentesResueltos()
    End Sub
End Class