Imports Logica

Public Class ModulosAfectados
    Private Sub ModulosAfectados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewModulosAfectados.DataSource = AccesoLogica.ResumenCantidadPorModuloAfectado()
        ComboBoxFiltro.ValueMember = "No_Incidente"
        ComboBoxFiltro.DisplayMember = "modulo"
        ComboBoxFiltro.DataSource = AccesoLogica.ResumenCantidadPorModuloAfectado()
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        Dim inicio As DateTime = DateTimePickerInicio.Value.ToString
        Dim final As DateTime = DateTimePickerFinal.Value.ToString
        Dim modulo As String = ComboBoxFiltro.Text
        DataGridViewModulosAfectados.DataSource = AccesoLogica.FiltrarResumenModuloAfectado(inicio, final, modulo)
    End Sub

    Private Sub ButtonRestablecerFiltro_Click(sender As Object, e As EventArgs) Handles ButtonRestablecerFiltro.Click
        DataGridViewModulosAfectados.DataSource = New DataGridView()
        DataGridViewModulosAfectados.DataSource = AccesoLogica.ResumenCantidadPorModuloAfectado()
    End Sub
End Class