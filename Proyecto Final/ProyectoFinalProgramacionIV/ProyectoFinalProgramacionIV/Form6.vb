Imports Logica

Public Class IncidentesResueltos
    Private Sub IncidentesResueltos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesResueltos.DataSource = AccesoLogica.ResumenIncidentesResueltos()
    End Sub
End Class