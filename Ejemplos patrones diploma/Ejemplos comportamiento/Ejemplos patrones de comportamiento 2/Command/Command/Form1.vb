Imports BL
Public Class Form1

    Dim mTV As New TV
    Dim mControl As New ControlRemoto(mTV)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Actualizar()
        txtTV.Text = mTV.Estado
    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        mControl.EncendidoApagado()
        Actualizar()
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click, b2.Click, b3.Click, b4.Click, b5.Click, b6.Click, b7.Click, b8.Click, b9.Click, b10.Click, b11.Click, b12.Click
        Dim mNumero As String = CType(sender, Control).Name.Replace("b", "0")
        If IsNumeric(mNumero) Then
            mControl.PonerCanal(CInt(mNumero))
        End If
        Actualizar()
    End Sub

    Private Sub vSubir_Click(sender As Object, e As EventArgs) Handles vSubir.Click
        mControl.SubirVolumen()
        Actualizar()
    End Sub

    Private Sub vBajar_Click(sender As Object, e As EventArgs) Handles vBajar.Click
        mControl.BajarVolumen()
        Actualizar()
    End Sub

    Private Sub Subir_Click(sender As Object, e As EventArgs) Handles Subir.Click
        mControl.SubirCanal()
        Actualizar()
    End Sub

    Private Sub cBajar_Click(sender As Object, e As EventArgs) Handles cBajar.Click
        mControl.BajarCanal()
        Actualizar()
    End Sub

    Private Sub btnDeshacer_Click(sender As Object, e As EventArgs) Handles btnDeshacer.Click
        mControl.Deshacer()
        Actualizar()
    End Sub
End Class
