Public Class ConclaveDeIngenieros
    Inherits Soporte

    Public Sub New()
        mSoporteSuperior = New GuruTecnologico
    End Sub
    Public Sub New(pSoporteSuperior As Soporte)
        mSoporteSuperior = pSoporteSuperior
    End Sub

    Dim mSoporteSuperior As Soporte

    Public Overrides Function Resolver(pTicket As Ticket) As String
        If pTicket.Nivel = Ticket.ComplejidadTecnica.IncidenteTecnicoComplejo Then
            Return "Cónclave de ingenieros: Hemos resuelto el problema: " & pTicket.Titulo
        Else
            If Not mSoporteSuperior Is Nothing Then
                Return mSoporteSuperior.Resolver(pTicket)
            Else
                Return "Cónclave de ingenieros: No podemos resolver el incidente"
            End If
        End If
    End Function
End Class
