''' <summary>
''' INVOKER
''' </summary>
''' <remarks></remarks>
Public Class ControlRemoto

   

    Dim mHistoricoAcciones As New List(Of Comando)

    Dim mTv As TV

    Public Sub New(pTV As TV)
        mTv = pTV
    End Sub

    Public Sub EncendidoApagado()
        getCommandBotonEncendidoApagado.Ejecutar()
    End Sub

    Public Sub SubirVolumen()
        mHistoricoAcciones.Add(getCommandBotonSubirVolumen.Ejecutar())
    End Sub

    Public Sub BajarVolumen()
        mHistoricoAcciones.Add(getCommandBotonBajarVolumen.Ejecutar())
    End Sub

    Public Sub SubirCanal()
        mHistoricoAcciones.Add(getCommandBotonSubirCanal.Ejecutar())
    End Sub

    Public Sub BajarCanal()
        mHistoricoAcciones.Add(getCommandBotonBajarCanal.Ejecutar())
    End Sub

    Public Sub PonerCanal(pCanal As TV.Canales)
        mHistoricoAcciones.Add(getCommandBotonPonerCanal(pCanal).Ejecutar())
    End Sub

    Public Sub Deshacer()
        If mHistoricoAcciones.Count > 0 Then
            mHistoricoAcciones.Last.Deshacer()
            mHistoricoAcciones.Remove(mHistoricoAcciones.Last)
        End If
    End Sub

    Public Sub Deshacer(pNumero As Integer)
        If mHistoricoAcciones.Count > 0 Then
            Dim mHasta As Integer
            If mHistoricoAcciones.Count - 1 - pNumero < 0 Then
                mHasta = 0
            Else
                mHasta = mHistoricoAcciones.Count - 1 - pNumero < 0
            End If
            For x As Integer = mHistoricoAcciones.Count - 1 To mHasta Step -1
                mHistoricoAcciones.Last.Deshacer()
                mHistoricoAcciones.Remove(mHistoricoAcciones.Last)
            Next
        End If

    End Sub

    Private Function getCommandBotonSubirVolumen() As Comando
        Return New BotonSubirVolumen(mTv)
    End Function

    Private Function getCommandBotonBajarVolumen() As Comando
        Return New BotonBajarVolumen(mTv)
    End Function

    Private Function getCommandBotonSubirCanal() As Comando
        Return New BotonSubirCanal(mTv)
    End Function

    Private Function getCommandBotonBajarCanal() As Comando
        Return New BotonBajarCanal(mTv)
    End Function

    Private Function getCommandBotonPonerCanal(pCanal As TV.Canales) As Comando
        Return New BotonPonerCanal(mTv, pCanal)
    End Function

    Private Function getCommandBotonEncendidoApagado() As Comando
        Return New BotonEncendidoApagado(mTv)
    End Function

End Class
