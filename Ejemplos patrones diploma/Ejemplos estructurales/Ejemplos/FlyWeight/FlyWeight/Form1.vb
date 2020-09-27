Imports BL

Public Class Form1

    Dim mConsecionario As New Concesionario

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstAutos.Items.Add(mConsecionario.Vender("Audi", "A4", "Negro", "AA123AA", "Juan Perez").Describir)
        lstAutos.Items.Add(mConsecionario.Vender("Ford", "Fiesta", "Rojo", "JAD922", "Pedro Ramírez").Describir)
        lstAutos.Items.Add(mConsecionario.Vender("Audi", "A4", "Negro", "AB112BB", "Miguel González").Describir)
        lstAutos.Items.Add(mConsecionario.Vender("Chevrolet", "Tracker", "Blanco", "KDS132", "María Suarez").Describir)
        lstAutos.Items.Add(mConsecionario.Vender("Ford", "Fiesta", "Rojo", "HAK234", "Susana Juarez").Describir)
        lstAutos.Items.Add(mConsecionario.Vender("Chevrolet", "Tracker", "Blanco", "AA120AB", "Jorge Benitez").Describir)


    End Sub
End Class
