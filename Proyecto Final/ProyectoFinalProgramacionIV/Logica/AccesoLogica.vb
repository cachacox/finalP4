﻿Imports Datos

Public Class AccesoLogica
    Public Shared Function CargarExcel()
        Return AccesoDatos.CargarExcel()
    End Function

    Public Shared Function InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod) As DataTable
        Return AccesoDatos.InsertarInfoExcel(no_incidente, usuario, fecha_creacion, prioridad, prioridad_real, horas, fech_estado, fecha_asignado, fecha_resultado, estado, _mod)
    End Function

    Public Shared Function InsertarSQL(_a, _b, _c, _d, _e, _f, _g, _mod) As DataTable
        Return AccesoDatos.InsertarSQL(_a, _b, _c, _d, _e, _f, _g, _mod)
    End Function


    Public Shared Function ResumenIncidentesResueltos() As DataTable
        Return AccesoDatos.ResumenIncidentesResueltos()
    End Function

    Public Shared Function ResumenCantidadPorModuloAfectado() As DataTable
        Return AccesoDatos.ResumenCantidadPorModuloAfectado()
    End Function

    Public Shared Function LastRow() As DataTable
        Return AccesoDatos.LastRow()
    End Function

    Public Shared Function FiltrarResumenModuloAfectado(fecha_inicio, fecha_final) As DataTable
        Return AccesoDatos.FiltrarResumenModuloAfectado(fecha_inicio, fecha_final)
    End Function

End Class