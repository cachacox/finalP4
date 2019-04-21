Imports Logica

Public Class IncidentesResueltos
    Private Sub IncidentesResueltos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesResueltos.DataSource = AccesoLogica.ResumenIncidentesResueltos()
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click

    End Sub
End Class