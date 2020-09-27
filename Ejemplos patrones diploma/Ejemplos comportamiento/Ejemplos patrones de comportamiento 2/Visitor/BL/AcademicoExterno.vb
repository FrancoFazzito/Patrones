''' <summary>
''' CONCRETE ELEMENT
''' </summary>
''' <remarks></remarks>
Public Class AcademicoExterno
    Inherits Asistente

    Public Property Institucion As String
    Public Property Cargo As String

    Public Overrides Function Accept(pVisitor As AbstractVisitor) As String
        Return pVisitor.Visitar(Me)
    End Function
End Class
