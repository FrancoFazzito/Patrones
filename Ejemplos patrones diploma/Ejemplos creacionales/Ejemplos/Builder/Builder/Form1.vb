Imports Clases
Public Class Form1

    Dim mFabricante As New Fabricante

    Private Sub btnEscritorio_Click(sender As Object, e As EventArgs) Handles btnEscritorio.Click

        Dim mCompu As Computadora = mFabricante.ContruirComputadora(New ContructorPCEscritorio)
        txtDescripcion.Text = mCompu.MostrarDescripción()

    End Sub

    Private Sub btnNotebook_Click(sender As Object, e As EventArgs) Handles btnNotebook.Click
        Dim mCompu As Computadora = mFabricante.ContruirComputadora(New ConstructorNotebook)
        txtDescripcion.Text = mCompu.MostrarDescripción()
    End Sub

    Private Sub btnTablet_Click(sender As Object, e As EventArgs) Handles btnTablet.Click
        Dim mCompu As Computadora = mFabricante.ContruirComputadora(New ConstructorTablet)
        txtDescripcion.Text = mCompu.MostrarDescripción()
    End Sub

    Private Sub btnSmartPhone_Click(sender As Object, e As EventArgs) Handles btnSmartPhone.Click
        Dim mCompu As Computadora = mFabricante.ContruirComputadora(New ConstructorSmartPhone)
        txtDescripcion.Text = mCompu.MostrarDescripción()
    End Sub
End Class
