''' <summary>
''' CONCRETE ELEMENT
''' </summary>
''' <remarks></remarks>
Public Class AlumnoUAI
    Inherits Asistente

    Public Property Legajo As String

    Public Overrides Function Accept(pVisitor As AbstractVisitor) As String
        Return pVisitor.Visitar(Me)
    End Function
End Class
