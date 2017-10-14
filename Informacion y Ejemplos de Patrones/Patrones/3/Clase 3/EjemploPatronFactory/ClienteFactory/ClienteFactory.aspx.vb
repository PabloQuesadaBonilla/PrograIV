Public Class ClienteFactory
    Inherits System.Web.UI.Page
    ' Private listaConexiones2 As New ArrayList
    Private listaConexiones As New  _
        List(Of ConnectionFactory.TipoConexion)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            listaConexiones.Add(ConnectionFactory.TipoConexion.Generica)
            listaConexiones.Add(ConnectionFactory.TipoConexion.OracleConnection)
            listaConexiones.Add(ConnectionFactory.TipoConexion.SqlConnection)
        End If
        For Each tipo In listaConexiones
            lstConexiones.Items.Add(tipo.ToString)
        Next    
    End Sub
    Private Sub btnConectar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        Dim factory As New ConnectionFactory.ConnectionFactory _
            ([Enum].Parse _
             (GetType(ConnectionFactory.TipoConexion), _
              lstConexiones.SelectedValue))
        'Dim myConnection As ConnectionFactory.Conexion =
        '    factory.CrearConexion
        lblConexionInfo.Text = factory.CrearConexion.Descripcion
    End Sub


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim factory As New ConnectionFactory.ConnectionFactory2

        Dim myConnection As ConnectionFactory.Conexion =
        factory.CrearConexion([Enum].Parse _
         (GetType(ConnectionFactory.TipoConexion), _
          lstConexiones.SelectedValue))

        lblConexionInfo.Text = myConnection.Descripcion
    End Sub
End Class