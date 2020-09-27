Imports BL


''' <summary>
''' CLIENT
''' </summary>
''' <remarks></remarks>
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = txtTareas.Left + txtTareas.Width + 50
    End Sub

    Private Sub btnTakeAway_Click(sender As Object, e As EventArgs) Handles btnTakeAway.Click
        Try
            Dim mPizzeria As Pizzeria = QuePizzeria()
            txtTareas.Text = mPizzeria.EntregarPizza
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnRestaurante_Click(sender As Object, e As EventArgs) Handles btnRestaurante.Click
        Try
            Dim mPizzeria As Pizzeria = QuePizzeria()
            txtTareas.Text = mPizzeria.ServirPizza
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function QuePizzeria() As Pizzeria
        If rdbArtesanal.Checked Then
            Return New PizzaLaNonna
        Else
            Return New Romario
        End If
    End Function


End Class
