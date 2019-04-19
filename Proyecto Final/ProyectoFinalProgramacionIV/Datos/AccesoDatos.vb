Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AccesoDatos
    Public Shared Function CargarExcel() As DataSet
        Dim excelconn As OleDbConnection
        Dim excelDTA As OleDbDataAdapter
        Dim excelDTS As DataSet
        Dim excelFileName As String
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx)|*.xlsx|Xls Files (*.xls)|*.xls"
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
            Dim FileName As String = OpenFileDialog.FileName
            excelFileName = fi.FullName
            excelconn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFileName + ";Extended Properties=Excel 12.0")
            excelDTA = New OleDbDataAdapter("select * from [Hoja1$]", excelconn)
            excelDTS = New DataSet
            excelDTA.Fill(excelDTS, "[Hoja1$]")
            excelconn.Close()
        End If
        Return excelDTS
    End Function

    Public Shared Function InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod) As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.CrearComando
        comandoInsertar.CommandText = "Insert into excel values (@No_Incidente, @Usuario, @Fecha_Creacion, @Prioridad, @Prioridad_Real, @Horas, @Fecha_Est, @Fecha_Asigna, @Fecha_Resul, @Estado, @modulo)"

        comandoInsertar.Parameters.Add("@No_Incidente", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@Usuario", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@Fecha_Creacion", SqlDbType.DateTime2)
        comandoInsertar.Parameters.Add("@Prioridad", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@Prioridad_Real", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@Horas", SqlDbType.Int)
        comandoInsertar.Parameters.Add("@Fecha_Est", SqlDbType.DateTime2)
        comandoInsertar.Parameters.Add("@Fecha_Asigna", SqlDbType.DateTime2)
        comandoInsertar.Parameters.Add("@Fecha_Resul", SqlDbType.DateTime2)
        comandoInsertar.Parameters.Add("@Estado", SqlDbType.NVarChar)
        comandoInsertar.Parameters.Add("@modulo", SqlDbType.NVarChar)

        comandoInsertar.Parameters("@No_Incidente").Value = no_incidente
        comandoInsertar.Parameters("@Usuario").Value = usuario
        comandoInsertar.Parameters("@Fecha_Creacion").Value = Convert.ToDateTime(fecha_creacion)
        comandoInsertar.Parameters("@Prioridad").Value = prioridad
        comandoInsertar.Parameters("@Prioridad_Real").Value = prioridad_real
        comandoInsertar.Parameters("@Horas").Value = Convert.ToInt32(horas)
        comandoInsertar.Parameters("@Fecha_Est").Value = Convert.ToDateTime(fech_estado)
        comandoInsertar.Parameters("@Fecha_Asigna").Value = Convert.ToDateTime(fecha_asignado)
        comandoInsertar.Parameters("@Fecha_Resul").Value = Convert.ToDateTime(fecha_resultado)
        comandoInsertar.Parameters("@Estado").Value = estado
        If _mod <> Nothing Then
            comandoInsertar.Parameters("@modulo").Value = _mod
        Else
            comandoInsertar.Parameters("@modulo").Value = ""
        End If
        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
    End Function

End Class