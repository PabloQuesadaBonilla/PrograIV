Public Class Avion
    Inherits Transporte

    Public Sub New()
        Me.SetAlgoritmo(New AlgoritmoViajoPorAire)
    End Sub
End Class
