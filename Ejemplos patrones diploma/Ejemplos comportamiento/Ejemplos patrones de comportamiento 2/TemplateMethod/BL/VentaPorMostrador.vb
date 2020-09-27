''' <summary>
''' CONCRETE CLASS
''' </summary>
''' <remarks></remarks>
Public Class VentaPorMostrador
    Inherits Venta

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function CalcularDescuentos() As Double
        Return MyBase.CalcularDescuentos() * 2 'Doble de descuento para compras por mostrador
    End Function

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function CalcularEmbalaje() As Double
        Return 20 '$20 de embalaje mínimo para llevar
    End Function

    ''' <summary>
    ''' PRIMITIVE OPERATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function CalcularEnvio() As Double
        Return 0 'No hay costo de envío
    End Function
End Class
