''' <summary>
''' RECEIVER
''' </summary>
''' <remarks></remarks>
Public Class TV

    Public Property Encendido As Boolean
    Public Property Canal As Canales
    Dim mVolumen As Integer
    Public ReadOnly Property Volumen As Integer
        Get
            Return mVolumen
        End Get
    End Property

    Public Enum Canales
        TVPublica = 1
        Telefe = 2
        Nueve = 3
        America = 4
        Trece = 5
        TN = 6
        A24 = 7
        Fox = 8
        HBO = 9
        ISat = 10
        Space = 11
        Warner = 12
        Sony = 13
    End Enum

    Public Sub Encender()
        Encendido = True
    End Sub

    Public Sub Apagar()
        Encendido = False
    End Sub

    Public Sub SubirVolumen()
        If Volumen < 100 Then
            mVolumen += 1
        End If
    End Sub

    Public Sub BajarVolumen()
        If Volumen > 0 Then
            mVolumen -= 1
        End If
    End Sub

    Friend Sub ResetVolumen(pVolumen As Integer)
        mVolumen = pVolumen
        If Volumen > 100 Then
            mVolumen = 100
        End If
        If Volumen < 0 Then
            mVolumen = 0
        End If
    End Sub

    Public Sub SubirCanal()
        If Canal < 13 Then
            Canal += 1
        End If
    End Sub

    Public Sub BajarCanal()
        If Canal > 1 Then
            Canal -= 1
        End If
    End Sub

    Public Sub PonerCanal(pCanal As Integer)
        Canal = pCanal
        If Canal > 13 Then
            Canal = 13
        End If
        If Canal < 1 Then
            Canal = 1
        End If
    End Sub

    Public Function Estado() As String
        If Encendido Then
            Return "TV: Encendido" & ControlChars.CrLf & _
                "Canal: " & Canal.ToString & ControlChars.CrLf & _
                "Volumen: " & Volumen
        Else
            Return "TV: Apagado"
        End If
    End Function
End Class
