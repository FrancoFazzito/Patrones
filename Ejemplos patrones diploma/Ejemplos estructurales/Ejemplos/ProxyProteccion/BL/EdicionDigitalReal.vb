''' <summary>
''' REAL SUBJECT
''' </summary>
''' <remarks></remarks>
Public Class EdicionDigitalReal
    Implements IEdicionDigital

    Friend Sub New() 'Solo accesible desde el proxy

    End Sub

    Public Function ObtenerNoticiasPoliciales() As String Implements IEdicionDigital.ObtenerNoticiasPoliciales
        Return "Una mujer fue secuestrada en Bernal" & ControlChars.CrLf & _
            "Robo al Banco Santander Río" & ControlChars.CrLf & _
            "Hallan pruebas de culpabilidad del sobrino del dueño en el caso del Restaurante" & ControlChars.CrLf
    End Function

    Public Function ObtenerNoticiasPoliticas() As String Implements IEdicionDigital.ObtenerNoticiasPoliticas
        Return "Las encuestas dan parejas para las elecciones Legislativas" & ControlChars.CrLf & _
            "El Gobernador de Salta aseguró que por el momento no será candidato" & ControlChars.CrLf & _
            "La alianza de la izquierda mejará su peformance en los próximos comicios" & ControlChars.CrLf
    End Function

    Public Function ObtenerNoticiasEconomicas() As String Implements IEdicionDigital.ObtenerNoticiasEconomicas
        Return "El dólar sigue estable luego de una subida importante" & ControlChars.CrLf & _
           "Cosecha record asegura un año más estable fiscalmente" & ControlChars.CrLf & _
           "Las tasas vuelven a subir y complican el crédito" & ControlChars.CrLf
    End Function

    Public Function ObtenerNoticia(pId As Integer) As String Implements IEdicionDigital.ObtenerNoticia
        'Búsqueda en la base de datos...
        Return "El argentino Axel Geller perdió la final de junior del US Open ante el chino Yibing Wu por 6-4 y 6-4 y finalizó su etapa en esa categoría con una gran temporada. En Wimbledon se había coronado en dobles (junto a Yu Hsiou Hsu, de Taiwán) y perdió la final de singles." & ControlChars.CrLf
    End Function
End Class
