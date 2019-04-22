Imports Logica

Public Class IncidentesNuevos
    Private Sub IncidentesNuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesNuevos.DataSource = AccesoLogica.ResumenNuevos()
    End Sub
End Class