''' <summary>
''' STATE
''' </summary>
''' <remarks></remarks>
Public Interface IEstado

    Sub Acelerar()
    Sub Frenar()
    Sub Encender()
    Sub Apagar()
    Sub CargarCombutible(pCantidad As Integer)
    Function Estado() As String
End Interface
