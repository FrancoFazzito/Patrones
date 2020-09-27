''' <summary>
''' ABSTRACT CLASS
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Venta
    Protected mProductos As New List(Of Producto)

    Public Enum FormasDePago
        Efectivo
        Credito
        Debito
    End Enum

    Dim mFormaPago As FormasDePago
    Protected ReadOnly Property FormaDePago As FormasDePago
        Get
            Return mFormaPago
        End Get
    End Property

    Dim mSubtotal As Double
    Protected ReadOnly Property SubTotal As Double
        Get
            Return mSubtotal
        End Get
    End Property

    Public Sub Agregar(pProductos As List(Of Producto))
        For Each mP As Producto In pProductos
            mProductos.Add(mP)
        Next
    End Sub

    Public Sub Agregar(pProducto As Producto)
        mProductos.Add(pProducto)
    End Sub

    ''' <summary>
    ''' TEMPLATE METHOD
    ''' </summary>
    ''' <param name="pForma"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CerrarVenta(pForma As FormasDePago) As Double
        mFormaPago = pForma

        mSubtotal = CalcularTotal()
        mSubtotal -= CalcularDescuentos()
        mSubtotal += CalcularEmbalaje()
        mSubtotal += CalcularEnvio()

        Return mSubtotal
    End Function


    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CalcularTotal() As Double
        Dim mTotal As Double
        For Each mPr As Producto In mProductos
            mTotal += mPr.Precio
        Next
        Return mTotal
    End Function

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overridable Function CalcularDescuentos() As Double
        Select Case mFormaPago
            Case FormasDePago.Efectivo 'En efectivo hay 10% de descuento
                Return mSubtotal * 0.1
            Case FormasDePago.Credito 'Con tarjeta de crédito hay 10% de descuento comprando más de 10 productos
                If mProductos.Count > 10 Then
                    Return mSubtotal * 0.1
                End If
            Case Else
                Return 0
        End Select
    End Function

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected MustOverride Function CalcularEmbalaje() As Double

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected MustOverride Function CalcularEnvio() As Double


End Class
