''' <summary>
''' CONCRETE VISITOR
''' </summary>
''' <remarks></remarks>
Public Class Cobrador
    Inherits AbstractVisitor

    Public Overloads Overrides Function Visitar(pAnfitrion As AcademicoExterno) As String
        Return "Abona con 50% de descuento: $" & CIITI.PrecioEntrada * 0.5
    End Function

    Public Overloads Overrides Function Visitar(pAnfitrion As AlumnoUAI) As String
        Return "Ingresa con 100% de descuento: $0"
    End Function

    Public Overloads Overrides Function Visitar(pAnfitrion As AsistenteGeneral) As String
        Return "Abona: $" & CIITI.PrecioEntrada
    End Function

    Public Overloads Overrides Function Visitar(pAnfitrion As DocenteUAI) As String
        Return "Ingresa con 100% de descuento: $0"
    End Function
End Class
