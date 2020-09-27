''' <summary>
''' CONCRETE COMMAND
''' </summary>
''' <remarks></remarks>
Public Class BotonEncendidoApagado
    Inherits Comando

    Dim mTV As TV
    Dim mCanal As TV.Canales
    Public Sub New(pTV As TV)
        mTV = pTV
    End Sub

    Public Overrides Sub Deshacer()
        'No se puede deshacer encendido o apagado
    End Sub

    Public Overrides Function Ejecutar() As Comando
        If mTV.Encendido Then
            mTV.Apagar()
        Else
            mTV.Encender()
        End If
        Return Me
    End Function
End Class
