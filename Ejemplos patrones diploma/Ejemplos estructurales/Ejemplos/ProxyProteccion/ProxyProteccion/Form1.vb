Imports BL
Public Class Form1

    Dim mUsuario As Usuario
    Dim mDiario As IEdicionDigital

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mUsuario = New Usuario
        mUsuario.Nombre = txtNombre.Text
        mUsuario.Premium = chkPremium.Checked

        Button1.Enabled = False
        txtNombre.Enabled = False
        chkPremium.Enabled = False
        Button2.Enabled = True

        btnArticulo.Enabled = True
        btnEconomia.Enabled = True
        btnPoliciales.Enabled = True
        btnPolitica.Enabled = True

        lblUsuario.Text = "Usuario: " & mUsuario.Nombre & IIf(mUsuario.Premium, " (Premium)", " (Básico)")

        mDiario = New DiarioEdicionDigital(mUsuario)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblUsuario.Text = "Usuario: "
        Button2.Enabled = False
        Button1.Enabled = True
        txtNombre.Enabled = True
        chkPremium.Enabled = True

        btnArticulo.Enabled = False
        btnEconomia.Enabled = False
        btnPoliciales.Enabled = False
        btnPolitica.Enabled = False

        txtNoticias.Text = ""

        mDiario = Nothing
    End Sub

    Private Sub btnPoliciales_Click(sender As Object, e As EventArgs) Handles btnPoliciales.Click
        txtNoticias.Text &= mDiario.ObtenerNoticiasPoliciales
    End Sub

    Private Sub btnEconomia_Click(sender As Object, e As EventArgs) Handles btnEconomia.Click
        txtNoticias.Text &= mDiario.ObtenerNoticiasEconomicas
    End Sub

    Private Sub btnPolitica_Click(sender As Object, e As EventArgs) Handles btnPolitica.Click
        txtNoticias.Text &= mDiario.ObtenerNoticiasPoliticas
    End Sub

    Private Sub btnArticulo_Click(sender As Object, e As EventArgs) Handles btnArticulo.Click
        txtNoticias.Text &= mDiario.ObtenerNoticia(10023)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = txtNoticias.Left + txtNoticias.Width + 50
        Me.Height = btnPolitica.Top + btnPolitica.Height + 50
    End Sub
End Class
