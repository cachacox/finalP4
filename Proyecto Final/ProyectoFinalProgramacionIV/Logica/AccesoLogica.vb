Imports Datos

Public Class AccesoLogica
    Public Shared Function CargarExcel()
        Return AccesoDatos.CargarExcel()
        'text
    End Function

    Public Shared Function InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod) As DataTable
        Return AccesoDatos.InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod)
    End Function

    Public Shared Function ResumenIncidentesResueltos() As DataTable
        Return AccesoDatos.ResumenIncidentesResueltos()
    End Function

    Public Shared Function LastRow() As DataTable
        Return AccesoDatos.LastRow()
    End Function

End Class