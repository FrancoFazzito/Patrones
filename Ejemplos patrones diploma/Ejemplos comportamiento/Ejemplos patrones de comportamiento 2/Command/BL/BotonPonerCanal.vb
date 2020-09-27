''' <summary>
''' CONCRETE COMMAND
''' </summary>
''' <remarks></remarks>
Public Class BotonPonerCanal
    Inherits Comando

    Dim mTV As TV
    Dim mCanal As TV.Canales
    Public Sub New(pTV As TV, pCanal As TV.Canales)
        mTV = pTV
        mCanal = pCanal
    End Sub

    Dim mCanalAnterior As TV.Canales

    Public Overrides Function Ejecutar() As Comando
        mCanalAnterior = mTV.Canal
        mTV.PonerCanal(mCanal)
        Return Me
    End Function

    Public Overrides Sub Deshacer()
        mTV.PonerCanal(mCanalAnterior)
    End Sub
End Class
