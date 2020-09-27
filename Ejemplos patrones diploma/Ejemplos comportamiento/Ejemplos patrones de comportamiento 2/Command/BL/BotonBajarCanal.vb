''' <summary>
''' CONCRETE COMMAND
''' </summary>
''' <remarks></remarks>
Public Class BotonBajarCanal
    Inherits Comando

    Dim mTV As TV
    Public Sub New(pTV As TV)
        mTV = pTV
    End Sub

    Dim mCanalAnterior As TV.Canales

    Public Overrides Function Ejecutar() As Comando
        mCanalAnterior = mTV.Canal
        mTV.BajarCanal()
        Return Me
    End Function

    Public Overrides Sub Deshacer()
        mTV.PonerCanal(mCanalAnterior)
    End Sub
End Class
