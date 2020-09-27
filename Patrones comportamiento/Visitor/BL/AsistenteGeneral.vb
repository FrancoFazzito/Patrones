''' <summary>
''' CONCRETE ELEMENT
''' </summary>
''' <remarks></remarks>
Public Class AsistenteGeneral
    Inherits Asistente

    Public Overrides Function Accept(pVisitor As AbstractVisitor) As String
        Return pVisitor.Visitar(Me)
    End Function
End Class
