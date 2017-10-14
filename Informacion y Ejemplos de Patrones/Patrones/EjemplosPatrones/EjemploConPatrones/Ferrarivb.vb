Public Class Ferrari
    Inherits Transporte


    Public Sub New()
        Me.SetAlgoritmo(New AlgoritmoViajoPorTierraRapido)
    End Sub

End Class
