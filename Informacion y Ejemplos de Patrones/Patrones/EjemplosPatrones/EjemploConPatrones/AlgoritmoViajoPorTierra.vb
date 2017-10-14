Public Class AlgoritmoViajoPorTierra
    Implements IMedioDeTransporte

    Private Function Go() As String _
    Implements IMedioDeTransporte.Go

        Return "Yo viajo por tierra"

    End Function
End Class
