''' <summary>
''' CONCRETE ELEMENT
''' </summary>
''' <remarks></remarks>
Public Class DocenteUAI
    Inherits Asistente

    Public Property Cargo As String
    Public Property Sede As String

    Public Overrides Function Accept(pVisitor As AbstractVisitor) As String
        Return pVisitor.Visitar(Me)
    End Function
End Class
