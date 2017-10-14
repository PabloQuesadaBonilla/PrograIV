Public MustInherit Class Transporte

    Private _MedioDeTransporte As IMedioDeTransporte

    Public Sub SetAlgoritmo(ByVal _MedioDeTransporte _
                            As IMedioDeTransporte)
        Me._MedioDeTransporte = _MedioDeTransporte
    End Sub

    Public Function Go() As String
        Return _MedioDeTransporte.Go
    End Function

End Class
