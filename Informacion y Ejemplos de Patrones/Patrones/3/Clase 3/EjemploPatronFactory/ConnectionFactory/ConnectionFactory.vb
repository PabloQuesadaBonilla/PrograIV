Public Class ConnectionFactory
    Private tipo As TipoConexion
    Public Sub New(ByVal tipo As TipoConexion)
        Me.tipo = tipo
    End Sub
    Public Function CrearConexion() As Conexion
        Select Case tipo
            Case TipoConexion.SqlConnection
                Return New SqlConnection()
            Case TipoConexion.OracleConnection
                Return New OrcaleConnection()
            Case Else
                Return New GenericaConnection()
        End Select
    End Function
End Class
