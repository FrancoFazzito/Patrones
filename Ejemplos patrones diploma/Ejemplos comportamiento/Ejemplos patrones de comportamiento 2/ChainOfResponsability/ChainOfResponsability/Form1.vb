Imports BL
Public Class Form1

    Dim mSoporte As Soporte = New MesaDeAyudaTelefonica

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Dim mTicket As New Ticket
        mTicket.Titulo = txtIncidente.Text

        mTicket.Nivel = cmbNivel.SelectedIndex + 1

        lblRespuesta.Text = mSoporte.Resolver(mTicket)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = txtIncidente.Left + txtIncidente.Width + 100

        cmbNivel.Items.Add("Problema de nivel básico")
        cmbNivel.Items.Add("Incidente técnico sencillo")
        cmbNivel.Items.Add("Incidente técnico complejo")
        cmbNivel.Items.Add("Incidente técnico atípico")
        cmbNivel.Items.Add("Incidente metafísico")
        cmbNivel.Items.Add("Incidente imposible de resolver")
        cmbNivel.SelectedIndex = 0
    End Sub
End Class
