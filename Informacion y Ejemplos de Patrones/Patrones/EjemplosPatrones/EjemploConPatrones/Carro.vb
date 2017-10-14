Public Class Carro
    Inherits Transporte
    Public Sub New()
        SetAlgoritmo(New AlgoritmoViajoPorTierra)
    End Sub
End Class
