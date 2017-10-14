Public MustInherit Class Conexion
    Private mDescripcion As String = "Conexion generica"
    Public Overridable ReadOnly _
        Property Descripcion As String
        Get
            Return mDescripcion
        End Get
    End Property
End Class
