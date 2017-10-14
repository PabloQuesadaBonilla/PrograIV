Public Class AlgoritmoViajoPorAire
    Implements IMedioDeTransporte
    Private Function Go() As String Implements IMedioDeTransporte.Go
        Return "Yo viajo por aire"
    End Function
End Class
