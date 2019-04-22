Imports Logica

Public Class IncidentesMora
    Private Sub IncidentesMora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewIncidentesMora.DataSource = AccesoLogica.ResumenIncidentesMora
    End Sub
End Class