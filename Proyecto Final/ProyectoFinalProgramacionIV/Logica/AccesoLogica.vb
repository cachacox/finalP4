Imports Datos

Public Class AccesoLogica
    Public Shared Function CargarExcel()
        Return AccesoDatos.CargarExcel()
    End Function
    Public Shared Function InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod) As DataTable
        Return AccesoDatos.InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod)
    End Function

    Public Shared Function ActualizarInfo(no_incidente, usuario, fecha_creacion, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod) As DataTable
        Return AccesoDatos.ActualizarInfo(no_incidente, usuario, fecha_creacion, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod)
    End Function

    Public Shared Function BorrarInfo(_incid) As DataTable
        Return AccesoDatos.BorrarInfo(_incid)
    End Function
    Public Shared Function ResumenIncidentesResueltos() As DataTable
        Return AccesoDatos.ResumenIncidentesResueltos()
    End Function
    Public Shared Function CargarTabla() As DataTable
        Return AccesoDatos.CargarTabla()
    End Function

    Public Shared Function ResumenCantidadPorModuloAfectado() As DataTable
        Return AccesoDatos.ResumenCantidadPorModuloAfectado()
    End Function

    Public Shared Function LastRow() As DataTable
        Return AccesoDatos.LastRow()
    End Function

    Public Shared Function FiltrarResumenModuloAfectado(fecha_inicio, fecha_final, modulo) As DataTable
        Return AccesoDatos.FiltrarResumenModuloAfectado(fecha_inicio, fecha_final, modulo)
    End Function

    Public Shared Function ResumenIncidentesMora() As DataTable
        Return AccesoDatos.ResumenIncidentesMora()
    End Function

    Public Shared Function ResumenIncidentesPendientes() As DataTable
        Return AccesoDatos.ResumenIncidentesPendientes()
    End Function

    Public Shared Function ResumenNuevos() As DataTable
        Return AccesoDatos.ResumenNuevos()
    End Function

    Public Shared Function FiltroRetrasados(fecha_inicio, fecha_final, modulo) As DataTable
        Return AccesoDatos.FiltroRetrasados(fecha_inicio, fecha_final, modulo)
    End Function

    Public Shared Function FiltroPendientes(fecha_inicio, fecha_final, modulo) As DataTable
        Return AccesoDatos.FiltroPendientes(fecha_inicio, fecha_final, modulo)
    End Function

    Public Shared Function FiltroNuevos(fecha_inicio, fecha_final, modulo) As DataTable
        Return AccesoDatos.FiltroNuevos(fecha_inicio, fecha_final, modulo)
    End Function

    Public Shared Function FiltrarIncidentesResueltos(fecha_inicio, fecha_final, modulo) As DataTable
        Return AccesoDatos.FiltrarIncidentesResueltos(fecha_inicio, fecha_final, modulo)
    End Function

End Class