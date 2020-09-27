''' <summary>
''' ELEMENT
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Asistente

    Public Property Nombre As String
    Public Property Apellido As String
    Public Property DNI As String

    Public MustOverride Function Accept(pVisitor As AbstractVisitor) As String

End Class
