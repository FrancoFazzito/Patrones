Public Class Dios
    Inherits Soporte

    Public Sub New()

    End Sub
    Public Sub New(pSoporteSuperior As Soporte)
        mSoporteSuperior = pSoporteSuperior
    End Sub

    Dim mSoporteSuperior As Soporte

    Public Overrides Function Resolver(pTicket As Ticket) As String
        If pTicket.Nivel = Ticket.ComplejidadTecnica.IncidenteMetafisico Then
            Return "Dios: He resuelto el problema: " & pTicket.Titulo
        Else
            If Not mSoporteSuperior Is Nothing Then
                Return mSoporteSuperior.Resolver(pTicket)
            Else
                Return "Dios: Hijo, lo siento, estás perdido"
            End If
        End If
    End Function
End Class
