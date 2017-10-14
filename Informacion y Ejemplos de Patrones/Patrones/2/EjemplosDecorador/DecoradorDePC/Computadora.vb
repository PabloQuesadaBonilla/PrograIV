Public Class Computadora

    Private mDescripcion As String = "Computadora"
    'Public MustOverride ReadOnly Property Descripcion1
    Public Overridable ReadOnly Property Descripcion As String
        Get
            Return mDescripcion
        End Get
    End Property




End Class
