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
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        Return excelDTS
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
    End Function

    Public Shared Function LastRow() As DataTable
        Dim comandoInsertar As SqlCommand = MetodosDatos.ComandoSP
        comandoInsertar.CommandText = "LastRow"
        Return MetodosDatos.EjecutarComandoSelect(comandoInsertar)
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

    Public Shared Function ResumenIncidentesResueltos() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "select DISTINCT  Estado,
        sum(case when Prioridad_Real = 'Emergencia' then 1 else 0 end) Emergencia,
        sum(case when Prioridad_Real = 'Alta' then 1 else 0 end) Alta,
        sum(case when Prioridad_Real = 'Media' then 1 else 0 end) Media,
        sum(case when Prioridad_Real = 'Baja' then 1 else 0 end) Baja
        from excel
        group by Estado;"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function ResumenCantidadPorModuloAfectado() As DataTable
        Dim _comando As SqlCommand = MetodosDatos.CrearComando()
        _comando.CommandText = "select DISTINCT  modulo,
        sum(case when Prioridad_Real = 'Emergencia' then 1 else 0 end) Emergencia,
        sum(case when Prioridad_Real = 'Alta' then 1 else 0 end) Alta,
        sum(case when Prioridad_Real = 'Media' then 1 else 0 end) Media,
        sum(case when Prioridad_Real = 'Baja' then 1 else 0 end) Baja
        from excel
        group by modulo;"
        Return MetodosDatos.EjecutarComandoSelect(_comando)
    End Function

    Public Shared Function BorrarInfo(_incid) As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "delete from excel where No_Incidente = @incidente"
        comando.Parameters.Add("@incidente", SqlDbType.NVarChar)
        comando.Parameters("@incidente").Value = _incid
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function FiltrarResumenModuloAfectado(fecha_inicio, fecha_final, modulo) As DataTable
        Dim comando As SqlCommand = MetodosDatos.ComandoSP
        comando.CommandText = "FiltrosResumenModuloAfectados"
        comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2)
        comando.Parameters.Add("@fecha_final", SqlDbType.DateTime2)
        comando.Parameters.Add("@modulo", SqlDbType.NVarChar)
        comando.Parameters("@fecha_inicio").Value = fecha_inicio
        comando.Parameters("@fecha_final").Value = fecha_final
        comando.Parameters("@modulo").Value = modulo
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function ResumenIncidentesMora() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT * from excel WHERE Estado = 'Retrasado'"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function FiltroRetrasados(fecha_inicio, fecha_final, modulo) As DataTable
        Dim comando As SqlCommand = MetodosDatos.ComandoSP
        comando.CommandText = "FiltroRetrasados"
        comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2)
        comando.Parameters.Add("@fecha_final", SqlDbType.DateTime2)
        comando.Parameters.Add("@modulo", SqlDbType.NVarChar)
        comando.Parameters("@fecha_inicio").Value = fecha_inicio
        comando.Parameters("@fecha_final").Value = fecha_final
        comando.Parameters("@modulo").Value = modulo
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function ResumenIncidentesPendientes() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT * from excel WHERE Estado = 'Pendiente'"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function ResumenNuevos() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT * from excel"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function CargarTabla() As DataTable
        Dim comando As SqlCommand = MetodosDatos.CrearComando
        comando.CommandText = "SELECT * from excel"
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function FiltroPendientes(fecha_inicio, fecha_final, modulo) As DataTable
        Dim comando As SqlCommand = MetodosDatos.ComandoSP
        comando.CommandText = "FiltrarPendientes"
        comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2)
        comando.Parameters.Add("@fecha_final", SqlDbType.DateTime2)
        comando.Parameters.Add("@modulo", SqlDbType.NVarChar)
        comando.Parameters("@fecha_inicio").Value = fecha_inicio
        comando.Parameters("@fecha_final").Value = fecha_final
        comando.Parameters("@modulo").Value = modulo
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function FiltroNuevos(fecha_inicio, fecha_final, modulo) As DataTable
        Dim comando As SqlCommand = MetodosDatos.ComandoSP
        comando.CommandText = "FiltrarNuevos"
        comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2)
        comando.Parameters.Add("@fecha_final", SqlDbType.DateTime2)
        comando.Parameters.Add("@modulo", SqlDbType.NVarChar)
        comando.Parameters("@fecha_inicio").Value = fecha_inicio
        comando.Parameters("@fecha_final").Value = fecha_final
        comando.Parameters("@modulo").Value = modulo
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

    Public Shared Function FiltrarIncidentesResueltos(fecha_inicio, fecha_final, modulo) As DataTable
        Dim comando As SqlCommand = MetodosDatos.ComandoSP
        comando.CommandText = "FiltroIncidentesResueltos"
        comando.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2)
        comando.Parameters.Add("@fecha_final", SqlDbType.DateTime2)
        comando.Parameters.Add("@modulo", SqlDbType.NVarChar)
        comando.Parameters("@fecha_inicio").Value = fecha_inicio
        comando.Parameters("@fecha_final").Value = fecha_final
        comando.Parameters("@modulo").Value = modulo
        Return MetodosDatos.EjecutarComandoSelect(comando)
    End Function

End Class