''' <summary>
''' CONCRETE BUILDER
''' </summary>
''' <remarks></remarks>
Public Class ConstructorNotebook
    Inherits ConstructorComputadora

    Public Sub New()
        mComputadora = New Computadora(Clases.Computadora.TipoComputadora.Notebook)
    End Sub

    Public Overrides Sub COnstruirControl()
        mComputadora.Control = "Pad"
    End Sub

    Public Overrides Sub ConstruirCPU()
        mComputadora.CPU = "i7"
    End Sub

    Public Overrides Sub COnstruirTeclado()
        mComputadora.Teclado = "QUERTY"
    End Sub

    Public Overrides Sub ContruirMonitor()
        mComputadora.Monitor = "LED 15.5''"
    End Sub
End Class
