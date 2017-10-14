Public Class ConnectionFactory2
    Public Sub New()
    End Sub
    Public Function CrearConexion _
        (ByVal tipo As TipoConexion) As Conexion
        Select Case tipo
            Case TipoConexion.SqlConnection
                Return New SqlConnection
            Case TipoConexion.OracleConnection
                Return New OrcaleConnection
            Case Else
                Return New GenericaConnection
        End Select
    End Function
End Class
