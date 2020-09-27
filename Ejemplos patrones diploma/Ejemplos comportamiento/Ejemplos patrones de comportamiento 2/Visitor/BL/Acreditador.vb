''' <summary>
''' CONCRETE VISITOR
''' </summary>
''' <remarks></remarks>
Public Class Acreditador
    Inherits AbstractVisitor


    Public Overloads Overrides Function Visitar(pAnfitrion As AcademicoExterno) As String
        Return "Acreditado el académico externo: " & pAnfitrion.Nombre & " " & pAnfitrion.Apellido & " DNI " & pAnfitrion.DNI & ", " & pAnfitrion.Cargo & " de la institución " & pAnfitrion.Institucion
    End Function

    Public Overloads Overrides Function Visitar(pAnfitrion As AlumnoUAI) As String
        Return "Acreditado el alumno: " & pAnfitrion.Nombre & " " & pAnfitrion.Apellido & " Legajo " & pAnfitrion.Legajo
    End Function

    Public Overloads Overrides Function Visitar(pAnfitrion As AsistenteGeneral) As String
        Return "Acreditado el asistente: " & pAnfitrion.Nombre & " " & pAnfitrion.Apellido & " DNI " & pAnfitrion.DNI
    End Function

    Public Overloads Overrides Function Visitar(pAnfitrion As DocenteUAI) As String
        Return "Acreditado el docente: " & pAnfitrion.Nombre & " " & pAnfitrion.Apellido & " DNI " & pAnfitrion.DNI & ", " & pAnfitrion.Cargo & " de la sede " & pAnfitrion.Sede
    End Function
End Class
