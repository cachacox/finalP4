Imports Logica

Public Class IncidentesPendientes
    Private Sub IncidentesPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesPndientes.DataSource = AccesoLogica.ResumenIncidentesPendientes()
        ComboBoxFiltro.ValueMember = "No_Incidente"
        ComboBoxFiltro.DisplayMember = "modulo"
        ComboBoxFiltro.DataSource = AccesoLogica.ResumenIncidentesPendientes()
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        Dim inicio As DateTime = DateTimePickerInicio.Value.ToString
        Dim final As DateTime = DateTimePickerFinal.Value.ToString
        Dim modulo As String = ComboBoxFiltro.Text
        DataGridViewIncidentesPndientes.DataSource = AccesoLogica.FiltroPendientes(inicio, final, modulo)
    End Sub

    Private Sub ButtonRestablecerFiltro_Click(sender As Object, e As EventArgs) Handles ButtonRestablecerFiltro.Click
        DataGridViewIncidentesPndientes.DataSource = New DataGridView()
        DataGridViewIncidentesPndientes.DataSource = AccesoLogica.ResumenIncidentesPendientes()
    End Sub
End Class