Imports System.Data
Imports System.Data.SqlClient

Public Class MetodosDatos
    Public Shared Function CrearComando() As SqlCommand
        Dim dbString = Configuracion.dbString
        Dim conexion As New SqlConnection
        conexion.ConnectionString = dbString
        Dim comando As New SqlCommand
        comando = conexion.CreateCommand
        comando.CommandType = CommandType.Text
        Return comando
    End Function
    Public Shared Function EjecutarComandoSelect(comando As SqlCommand) As DataTable
        Dim _tabla As New DataTable()
        Try
            comando.Connection.Open()
            Dim _adaptador As New SqlDataAdapter()
            _adaptador.SelectCommand = comando
            _adaptador.Fill(_tabla)
        Catch ex As Exception
        Finally
            comando.Connection.Close()
        End Try
        Return _tabla
    End Function

    Public Shared Function EjecutarComandoBorrar(comando As SqlCommand) As Integer
        Dim _tabla As New DataTable()
        Dim cant As Integer
        Try
            comando.Connection.Open()
            cant = comando.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            comando.Connection.Close()
        End Try
        Return cant
    End Function
End Class