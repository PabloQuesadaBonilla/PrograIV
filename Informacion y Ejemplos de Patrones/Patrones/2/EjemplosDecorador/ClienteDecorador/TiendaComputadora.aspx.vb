Public Class TiendaComputadora
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnMemoria_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMemoria.Click

        Dim Acc As New DecoradorDePC.Computadora
        Acc = New DecoradorDePC.Memoria(Acc)
        Acc = New DecoradorDePC.DiscoDuro(Acc)
        Acc = New DecoradorDePC.Monitor(Acc)
        lblAcc.Text = Acc.Descripcion()


    End Sub
End Class