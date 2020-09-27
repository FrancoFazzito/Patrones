''' <summary>
''' CONCRETE BUILDER
''' </summary>
''' <remarks></remarks>
Public Class ConstructorSmartPhone
    Inherits ConstructorComputadora

    Public Sub New()
        mComputadora = New Computadora(Clases.Computadora.TipoComputadora.SmartPhone)
    End Sub

    Public Overrides Sub COnstruirControl()
        mComputadora.Control = "Touch screen"
    End Sub

    Public Overrides Sub ConstruirCPU()
        mComputadora.CPU = "1.6GHz OctaCore"
    End Sub

    Public Overrides Sub COnstruirTeclado()
        mComputadora.Teclado = ""
    End Sub

    Public Overrides Sub ContruirMonitor()
        mComputadora.Monitor = "Super AMOLED 5.5''"
    End Sub
End Class
