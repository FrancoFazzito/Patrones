''' <summary>
''' CONCRETE STATE
''' </summary>
''' <remarks></remarks>
Public Class EstadoApagado
    Implements IEstado

    Dim mAuto As Auto

    Public Sub New(pAuto As Auto)
        mAuto = pAuto
        mAuto.Velocidad = 0
    End Sub

    Public Sub Acelerar() Implements IEstado.Acelerar

    End Sub

    Public Sub Apagar() Implements IEstado.Apagar

    End Sub

    Public Sub CargarCombutible(pCantidad As Integer) Implements IEstado.CargarCombutible
        mAuto.Combustible += pCantidad
    End Sub

    Public Sub Encender() Implements IEstado.Encender
        mAuto.CambiarEstado(New EstadoDetenido(mAuto))
    End Sub

    Public Sub Frenar() Implements IEstado.Frenar

    End Sub

    Public Function Estado() As String Implements IEstado.Estado
        Return "Apagado"
    End Function
End Class
