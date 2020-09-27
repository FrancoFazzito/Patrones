''' <summary>
''' VISITOR
''' </summary>
''' <remarks></remarks>
Public MustInherit Class AbstractVisitor

    Public MustOverride Function Visitar(pAnfitrion As DocenteUAI) As String

    Public MustOverride Function Visitar(pAnfitrion As AlumnoUAI) As String

    Public MustOverride Function Visitar(pAnfitrion As AsistenteGeneral) As String

    Public MustOverride Function Visitar(pAnfitrion As AcademicoExterno) As String

End Class
