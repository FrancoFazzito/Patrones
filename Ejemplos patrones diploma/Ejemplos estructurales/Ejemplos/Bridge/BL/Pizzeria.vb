''' <summary>
''' ABSTRACTION
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Pizzeria

    Dim mPizzero As IPizzero

    Public Sub New(pPizzero As IPizzero)
        mPizzero = pPizzero
    End Sub

    Protected ReadOnly Property Pizzero As IPizzero
        Get
            Return mPizzero
        End Get
    End Property


    ''' <summary>
    ''' ABSTRACT OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public MustOverride Function EntregarPizza() As String

    ''' <summary>
    ''' ABSTRACT OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public MustOverride Function ServirPizza() As String


End Class
