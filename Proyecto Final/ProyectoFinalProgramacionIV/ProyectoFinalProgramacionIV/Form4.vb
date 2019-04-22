Imports Logica

Public Class IncidentesPendientes
    Private Sub IncidentesPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesPndientes.DataSource = AccesoLogica.ResumenIncidentesPendientes()
    End Sub
End Class