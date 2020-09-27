Imports BL
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mCon As New Conversor()

        Dim mMonto As Double = mCon.Convertir(CurrencyService.Currency.USD, CurrencyService.Currency.USD, 1000)

        MsgBox(mMonto)

    End Sub
End Class
