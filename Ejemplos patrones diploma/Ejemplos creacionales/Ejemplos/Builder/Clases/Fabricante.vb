''' <summary>
''' DIRECTOR
''' </summary>
''' <remarks></remarks>
Public Class Fabricante

    Public Function ContruirComputadora(pConctructor As ConstructorComputadora) As Computadora
        pConctructor.ConstruirCPU()
        pConctructor.ContruirMonitor()
        pConctructor.COnstruirTeclado()
        pConctructor.COnstruirControl()

        Return pConctructor.Computadora
    End Function

End Class
