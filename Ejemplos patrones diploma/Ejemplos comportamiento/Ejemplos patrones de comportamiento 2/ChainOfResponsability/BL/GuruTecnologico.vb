Public Class GuruTecnologico
    Inherits Soporte

    Public Sub New()
        mSoporteSuperior = New Dios
    End Sub
    Public Sub New(pSoporteSuperior As Soporte)
        mSoporteSuperior = pSoporteSuperior
    End Sub

    Dim mSoporteSuperior As Soporte

    Public Overrides Function Resolver(pTicket As Ticket) As String
        If pTicket.Nivel = Ticket.ComplejidadTecnica.IncidenteTecnicoAtipico Then
            Return "Gurú tecnológico: He resuelto el problema: " & pTicket.Titulo
        Else
            If Not mSoporteSuperior Is Nothing Then
                Return mSoporteSuperior.Resolver(pTicket)
            Else
                Return "Gurú tecnológico: No puedo resolver el incidente"
            End If
        End If
    End Function
End Class
