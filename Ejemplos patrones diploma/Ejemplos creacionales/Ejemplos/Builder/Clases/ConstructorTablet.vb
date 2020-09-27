''' <summary>
''' CONCRETE BUILDER
''' </summary>
''' <remarks></remarks>
Public Class ConstructorTablet
    Inherits ConstructorComputadora

    Public Sub New()
        mComputadora = New Computadora(Clases.Computadora.TipoComputadora.Tablet)
    End Sub

    Public Overrides Sub COnstruirControl()
        mComputadora.Control = "Touch screen"
    End Sub

    Public Overrides Sub ConstruirCPU()
        mComputadora.CPU = "MT8163"
    End Sub

    Public Overrides Sub COnstruirTeclado()
        mComputadora.Teclado = ""
    End Sub

    Public Overrides Sub ContruirMonitor()
        mComputadora.Monitor = "Touch LED 10.1''"
    End Sub
End Class
