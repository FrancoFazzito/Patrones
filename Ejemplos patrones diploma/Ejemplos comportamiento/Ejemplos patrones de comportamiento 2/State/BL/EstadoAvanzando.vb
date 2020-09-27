''' <summary>
''' CONCRETE STATE
''' </summary>
''' <remarks></remarks>
Public Class EstadoAvanzando
    Implements IEstado

    Dim mAuto As Auto

    Public Sub New(pAuto As Auto)
        mAuto = pAuto
    End Sub

    Public Sub Acelerar() Implements IEstado.Acelerar
        mAuto.Velocidad += 1
        mAuto.Combustible -= 10
        If mAuto.Combustible <= 0 Then
            mAuto.CambiarEstado(New EstadoSinCombustible(mAuto))
        End If
    End Sub

    Public Sub Apagar() Implements IEstado.Apagar
        mAuto.CambiarEstado(New EstadoApagado(mAuto))
    End Sub

    Public Sub CargarCombutible(pCantidad As Integer) Implements IEstado.CargarCombutible
        mAuto.Combustible += pCantidad
    End Sub

    Public Sub Encender() Implements IEstado.Encender

    End Sub

    Public Sub Frenar() Implements IEstado.Frenar
        mAuto.Velocidad -= 1
        mAuto.Combustible -= 10
        If mAuto.Combustible <= 0 Then
            mAuto.CambiarEstado(New EstadoSinCombustible(mAuto))
        ElseIf mAuto.Velocidad <= 0 Then
            mAuto.CambiarEstado(New EstadoDetenido(mAuto))
        End If

    End Sub

    Public Function Estado() As String Implements IEstado.Estado
        Return "Avanzando"
    End Function
End Class
