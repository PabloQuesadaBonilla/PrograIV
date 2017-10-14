Public Class AlgoritmoViajoPorAgua
    Implements IMedioDeTransporte
    Private Function Go() As String Implements IMedioDeTransporte.Go
        Return "Yo viajo por agua"
    End Function
End Class
