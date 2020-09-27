Imports BL
Public Class Form1

    Dim mAuto As New Auto

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Actualizar()
        txtEstadoAuto.Text = mAuto.DescribirEstado
    End Sub

    Private Sub btnCombustible_Click(sender As Object, e As EventArgs) Handles btnCombustible.Click
        mAuto.CargarCombustible(txtCantidad.Text)
        Actualizar()
    End Sub

    Private Sub btnEncender_Click(sender As Object, e As EventArgs) Handles btnEncender.Click
        mAuto.Encender()
        Actualizar()
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        mAuto.Apagar()
        Actualizar()
    End Sub

    Private Sub btnAcelerar_Click(sender As Object, e As EventArgs) Handles btnAcelerar.Click
        mAuto.Acelerar()
        Actualizar()
    End Sub

    Private Sub btnFrenar_Click(sender As Object, e As EventArgs) Handles btnFrenar.Click
        mAuto.Frenar()
        Actualizar()
    End Sub
End Class
