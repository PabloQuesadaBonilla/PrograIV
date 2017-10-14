Public Class Monitor
    Inherits ComputadoraDecoradora
    Private miPc As Computadora
    Private mDescripcion As String = ",Monitor"
    Public Sub New(ByVal miPc As Computadora)
        Me.miPc = miPc
    End Sub

    Public Overrides ReadOnly Property Descripcion As String
        Get
            Return miPc.Descripcion & mDescripcion
        End Get
    End Property
End Class
