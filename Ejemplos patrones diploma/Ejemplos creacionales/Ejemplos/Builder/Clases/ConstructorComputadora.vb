''' <summary>
''' CONCRETE BUILDER
''' </summary>
''' <remarks></remarks>
Public MustInherit Class ConstructorComputadora

    Protected mComputadora As Computadora

    Public ReadOnly Property Computadora As Computadora
        Get
            Return mComputadora
        End Get
    End Property

    Public MustOverride Sub ContruirMonitor() 'BuildPart()
    Public MustOverride Sub COnstruirTeclado() 'BuildPart()
    Public MustOverride Sub ConstruirCPU() 'BuildPart()
    Public MustOverride Sub COnstruirControl() 'BuildPart()

End Class
