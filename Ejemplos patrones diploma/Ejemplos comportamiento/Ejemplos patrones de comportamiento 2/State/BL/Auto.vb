''' <summary>
''' CONTEXT
''' </summary>
''' <remarks></remarks>
Public Class Auto

    Dim mEstado As IEstado

    Public Sub New()
        mEstado = New EstadoSinCombustible(Me)
    End Sub

    Dim mCombustible As Integer
    Public Property Combustible As Integer
        Get
            Return mCombustible
        End Get
        Friend Set(value As Integer)
            mCombustible = value
        End Set
    End Property

    Dim mVelocidad As Integer
    Public Property Velocidad As Integer
        Get
            Return mVelocidad
        End Get
        Friend Set(value As Integer)
            mVelocidad = value
        End Set
    End Property

    Friend Sub CambiarEstado(pEstado As IEstado)
        mEstado = pEstado
    End Sub

    Public Sub Encender()
        mEstado.Encender()
    End Sub

    Public Sub Apagar()
        mEstado.Apagar()
    End Sub

    Public Sub Acelerar()
        mEstado.Acelerar()
    End Sub

    Public Sub Frenar()
        mEstado.Frenar()
    End Sub

    Public Sub CargarCombustible(pCantidad As Integer)
        mEstado.CargarCombutible(pCantidad)
    End Sub

    Public Function DescribirEstado() As String
        Return "Estado: " & mEstado.Estado & ControlChars.CrLf & _
            "Velocidad: " & Velocidad & ControlChars.CrLf & _
            "Combustible: " & Combustible & ControlChars.CrLf
    End Function

End Class
