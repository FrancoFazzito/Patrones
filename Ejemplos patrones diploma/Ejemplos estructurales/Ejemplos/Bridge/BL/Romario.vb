''' <summary>
''' REDEFINED ABSTRACTION
''' </summary>
''' <remarks></remarks>
Public Class Romario
    Inherits Pizzeria

    Public Sub New()
        MyBase.New(New PizzeroIndustrial)
    End Sub

    Public Overrides Function EntregarPizza() As String
        Return Pizzero.PrepararPizza & Pizzero.CocinarPizza & _
            "Poner pizza en caja" & ControlChars.CrLf & _
            "Entregar a cliente"
    End Function

    Public Overrides Function ServirPizza() As String
        Dim mResultado As String = Pizzero.PrepararPizza
        mResultado &= Pizzero.CocinarPizza
        mResultado &= "Servir pizza a la mesa"
        Return mResultado
    End Function
End Class
