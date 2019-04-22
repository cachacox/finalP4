Imports Logica

Public Class ModulosAfectados
    Private Sub ModulosAfectados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewModulosAfectados.DataSource = AccesoLogica.ResumenCantidadPorModuloAfectado()
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        Dim inicio As DateTime = DateTimePickerInicio.Value.ToString
        Dim final As DateTime = DateTimePickerFinal.Value.ToString
        DataGridViewModulosAfectados.DataSource = AccesoLogica.FiltrarResumenModuloAfectado(inicio, final)
    End Sub
End Class