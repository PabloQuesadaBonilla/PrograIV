﻿Public Class OrcaleConnection
    Inherits Conexion
    Private mDescripcion As String = _
        "Oracle Connection"
    Public Overrides ReadOnly Property _
        Descripcion As String
        Get
            Return mDescripcion
        End Get
    End Property
End Class
