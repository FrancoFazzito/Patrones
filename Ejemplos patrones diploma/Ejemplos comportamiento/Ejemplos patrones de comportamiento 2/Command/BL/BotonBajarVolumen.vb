''' <summary>
''' CONCRETE COMMAND
''' </summary>
''' <remarks></remarks>
Public Class BotonBajarVolumen
    Inherits Comando


    Dim mTV As TV
    Public Sub New(pTV As TV)
        mTV = pTV
    End Sub

    Dim mVolumenAnterior As Integer

    Public Overrides Function Ejecutar() As Comando
        mVolumenAnterior = mTV.Volumen
        mTV.BajarVolumen()
        Return Me
    End Function

    Public Overrides Sub Deshacer()
        mTV.ResetVolumen(mVolumenAnterior)
    End Sub
End Class
