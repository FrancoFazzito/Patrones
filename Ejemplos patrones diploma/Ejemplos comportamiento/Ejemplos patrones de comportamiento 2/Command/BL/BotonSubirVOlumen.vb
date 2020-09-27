''' <summary>
''' CONCRETE COMMAND
''' </summary>
''' <remarks></remarks>
Public Class BotonSubirVolumen
    Inherits Comando


    Dim mTV As TV
    Public Sub New(pTV As TV)
        mTV = pTV
    End Sub

    Dim mVolumenAnterior As Integer

    Public Overrides Function Ejecutar() As Comando
        mVolumenAnterior = mTV.Volumen
        mTV.SubirVolumen()
        Return Me
    End Function

    Public Overrides Sub Deshacer()
        mTV.ResetVolumen(mVolumenAnterior)
    End Sub
End Class
