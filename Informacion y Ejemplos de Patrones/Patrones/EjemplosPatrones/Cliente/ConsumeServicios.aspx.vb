Public Class ConsumeServicios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnConsumeServicio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsumeServicio.Click
        Dim miTransporte As EjemploSinPatrones.Transporte
        miTransporte = New EjemploSinPatrones.Bus


        lblTransporte.Text = miTransporte.Go()
        miTransporte = New EjemploSinPatrones.Carro
        lblTransporte.Text = miTransporte.Go()

        miTransporte = New EjemploSinPatrones.Avion
        miTransporte.Go()
    End Sub


    Private Sub btnAvion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAvion.Click
        Dim miTransporte As EjemploConPatrones.Transporte
        miTransporte = New EjemploConPatrones.Avion
        lblAvion.Text = miTransporte.Go()



    End Sub

    Private Sub btnCarro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCarro.Click
        Dim miTransporte As EjemploConPatrones.Transporte
        miTransporte = New EjemploConPatrones.Carro
        lblCarro.Text = miTransporte.Go()
    End Sub



    Private Sub btnFerrari_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFerrari.Click
        Dim miTransporte As EjemploConPatrones.Transporte
        miTransporte = New EjemploConPatrones.Ferrari
        lblFerrari.Text = miTransporte.Go()

    End Sub
End Class