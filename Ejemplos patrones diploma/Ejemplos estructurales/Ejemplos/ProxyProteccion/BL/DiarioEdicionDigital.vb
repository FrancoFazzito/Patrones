''' <summary>
''' PROXY
''' </summary>
''' <remarks></remarks>
Public Class DiarioEdicionDigital
    Implements IEdicionDigital


    Dim mDiario As New EdicionDigitalReal
    Dim mUsuario As Usuario
    Public Sub New(pUsuario As Usuario)
        mUsuario = pUsuario
    End Sub

    Dim mNoticiasLeidas As Integer

    Public Function ObtenerNoticia(pId As Integer) As String Implements IEdicionDigital.ObtenerNoticia
        If Not mUsuario.Premium Then
            If mNoticiasLeidas > 5 Then
                Return "YA HA LEIDO 5 NOTICIAS. DEBE SUSCRIBIR UN PLAN PREMIUM PARA SEGUIR LEYENDO" & ControlChars.CrLf
            Else
                mNoticiasLeidas += 1
            End If
        End If
        Return mDiario.ObtenerNoticia(pId)
    End Function

    Public Function ObtenerNoticiasEconomicas() As String Implements IEdicionDigital.ObtenerNoticiasEconomicas
        If Not mUsuario.Premium Then
            Return "DEBE SUSCRIBIR UN PLAN PREMIUM PARA LEER ESTA SECCION" & ControlChars.CrLf
        End If
        Return mDiario.ObtenerNoticiasEconomicas
    End Function

    Public Function ObtenerNoticiasPoliciales() As String Implements IEdicionDigital.ObtenerNoticiasPoliciales
        Return mDiario.ObtenerNoticiasPoliciales
    End Function

    Public Function ObtenerNoticiasPoliticas() As String Implements IEdicionDigital.ObtenerNoticiasPoliticas
        Return mDiario.ObtenerNoticiasPoliticas
    End Function
End Class
