Imports BL
Public Class Form1

    Dim mOrganizador As New OrganizadorEventos

    Private Sub btnCasamiento_Click(sender As Object, e As EventArgs) Handles btnCasamiento.Click

        txtPresupuesto.Text = mOrganizador.OrganizarCasamiento(txtInvitados.Text, dtpFecha.Value, Gasto())

    End Sub



    Private Function Gasto() As OrganizadorEventos.TipoGasto
        If rdbAlta.Checked Then
            Return OrganizadorEventos.TipoGasto.AltaFiesta
        ElseIf rdbCompleta.Checked Then
            Return OrganizadorEventos.TipoGasto.FestejoCompleto
        ElseIf rdbModerada.Checked Then
            Return OrganizadorEventos.TipoGasto.FiestaModerada
        Else
            Return OrganizadorEventos.TipoGasto.ReunionFamiliar
        End If

    End Function

    Private Sub btnInfantil_Click(sender As Object, e As EventArgs) Handles btnInfantil.Click
        txtPresupuesto.Text = mOrganizador.OrgenizarCumpleInfantil(txtInvitados.Text, dtpFecha.Value, Gasto())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = txtPresupuesto.Left + txtPresupuesto.Width + 50
        Me.Height = txtPresupuesto.Top + txtPresupuesto.Height + 50
    End Sub
End Class
