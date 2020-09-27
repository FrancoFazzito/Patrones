Public Class Conversor


    Public Function Convertir(pModenaOrigen As CurrencyService.Currency, pMonedaDestino As CurrencyService.Currency, pMonto As Double) As Double

        Dim mServ As New CurrencyService.CurrencyConvertor
        Dim mRate As Double = mServ.ConversionRate(pModenaOrigen, pMonedaDestino)

        Return mRate * pMonto

    End Function

End Class
