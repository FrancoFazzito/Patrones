Imports BL
Public Class Form1

    Dim mOrganizador As New OrganizadorCena

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCenaSolo_Click(sender As Object, e As EventArgs) Handles btnCenaSolo.Click
        txtPreparacionMesa.Text = mOrganizador.PonerLaMesa(New CenaSolitaria)
    End Sub

    Private Sub btnCenaRomantica_Click(sender As Object, e As EventArgs) Handles btnCenaRomantica.Click
        txtPreparacionMesa.Text = mOrganizador.PonerLaMesa(New CenaRomantica)
    End Sub

    Private Sub btnCenaSuegros_Click(sender As Object, e As EventArgs) Handles btnCenaSuegros.Click
        txtPreparacionMesa.Text = mOrganizador.PonerLaMesa(New CenaConSuegros)
    End Sub
End Class
