''' <summary>
''' REDEFINED ABSTRACTION
''' </summary>
''' <remarks></remarks>
Public Class PizzaLaNonna
    Inherits Pizzeria

    Public Sub New()
        MyBase.New(New PizzeroArtesanal)
    End Sub

    Public Overrides Function EntregarPizza() As String
        Throw New Exception("La Nonna no ofrece Delvery ni Take Away")
    End Function

    Public Overrides Function ServirPizza() As String
        Dim mResultado As String = Pizzero.PrepararPizza
        mResultado &= Pizzero.CocinarPizza
        mResultado &= "Servir pizza a la mesa"
        Return mResultado
    End Function
End Class
