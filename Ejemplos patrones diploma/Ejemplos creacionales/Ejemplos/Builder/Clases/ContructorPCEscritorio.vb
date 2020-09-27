''' <summary>
''' CONCRETE BUILDER
''' </summary>
''' <remarks></remarks>
Public Class ContructorPCEscritorio
    Inherits ConstructorComputadora

    Public Sub New()
        mComputadora = New Computadora(Clases.Computadora.TipoComputadora.Escritorio)
    End Sub

    Public Overrides Sub COnstruirControl()
        mComputadora.Control = "Mouse"
    End Sub

    Public Overrides Sub ConstruirCPU()
        mComputadora.CPU = "i7"
    End Sub

    Public Overrides Sub COnstruirTeclado()
        mComputadora.Teclado = "QUERTY extendido"
    End Sub

    Public Overrides Sub ContruirMonitor()
        mComputadora.Monitor = "LED 29''"
    End Sub
End Class
