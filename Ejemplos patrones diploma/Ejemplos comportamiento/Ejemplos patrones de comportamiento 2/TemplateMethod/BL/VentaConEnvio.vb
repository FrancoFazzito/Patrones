''' <summary>
''' CONCRETE CLASS
''' </summary>
''' <remarks></remarks>
Public Class VentaConEnvio
    Inherits Venta

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function CalcularEmbalaje() As Double
        Dim mPeso As Integer
        For Each mP As Producto In mProductos
            mPeso += mP.Peso
        Next
        If mPeso > 10 Then
            Return SubTotal * 0.2 '20% de recargo por embalaje de más de 10 kilos
        End If
    End Function

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function CalcularEnvio() As Double
        Return 40 * mProductos.Count '$40 por producto
    End Function
End Class
