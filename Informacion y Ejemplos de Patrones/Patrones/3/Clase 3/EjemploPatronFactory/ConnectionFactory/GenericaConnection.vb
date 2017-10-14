Public Class GenericaConnection
    Inherits Conexion

    Public Overrides ReadOnly Property _
        Descripcion As String
        Get
            Return MyBase.Descripcion
        End Get
    End Property


End Class
