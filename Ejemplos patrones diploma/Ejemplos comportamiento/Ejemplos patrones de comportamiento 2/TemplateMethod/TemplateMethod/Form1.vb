Imports BL
Public Class Form1

    Dim mProductos As New List(Of Producto)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With grdProductos
            .Columns.Add("Codigo", "Código")
            .Columns("Codigo").DataPropertyName = "Codigo"
            .Columns.Add("Nombre", "Nombre")
            .Columns("Nombre").DataPropertyName = "Nombre"
            .Columns.Add("Precio", "Precio")
            .Columns("Precio").DataPropertyName = "Precio"
            .Columns.Add("Peso", "Peso")
            .Columns("Peso").DataPropertyName = "Peso"
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .EditMode = DataGridViewEditMode.EditProgrammatically
        End With

        mProductos.Add(New Producto With {.Codigo = "A12", .Nombre = "Zapatillas", .Precio = 1500, .Peso = 2})
        mProductos.Add(New Producto With {.Codigo = "B26", .Nombre = "Bolso", .Precio = 800, .Peso = 1})
        mProductos.Add(New Producto With {.Codigo = "C14", .Nombre = "Bicicleta", .Precio = 6800, .Peso = 25})

        grdProductos.DataSource = mProductos

        cmbFormaPago.Items.Add("Efectivo")
        cmbFormaPago.Items.Add("Crédito")
        cmbFormaPago.Items.Add("Débito")
        cmbFormaPago.SelectedIndex = 1
    End Sub

    Private Sub btnMostrador_Click(sender As Object, e As EventArgs) Handles btnMostrador.Click

        Dim mVenta As New VentaPorMostrador
        ProcesarVenta(mVenta)

    End Sub

    Private Sub btnEnvio_Click(sender As Object, e As EventArgs) Handles btnEnvio.Click
        Dim mVenta As New VentaConEnvio
        ProcesarVenta(mVenta)
    End Sub

    Private Sub ProcesarVenta(pVenta As Venta)
        pVenta.Agregar(mProductos)

        Select Case cmbFormaPago.SelectedItem
            Case "Efectivo"
                txtTotal.Text = pVenta.CerrarVenta(Venta.FormasDePago.Efectivo)
            Case "Crédito"
                txtTotal.Text = pVenta.CerrarVenta(Venta.FormasDePago.Credito)
            Case "Débito"
                txtTotal.Text = pVenta.CerrarVenta(Venta.FormasDePago.Debito)
        End Select
    End Sub
End Class
