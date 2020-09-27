Public Class Ticket

    Public Enum ComplejidadTecnica
        ProblemaNivelBasico = 1
        IncidenteTecnicoSencillo = 2
        IncidenteTecnicoComplejo = 3
        IncidenteTecnicoAtipico = 4
        IncidenteMetafisico = 5
        IncidenteImposibleDeResolver = 6
    End Enum

    Public Property Titulo As String
    Public Property Nivel As ComplejidadTecnica

End Class
