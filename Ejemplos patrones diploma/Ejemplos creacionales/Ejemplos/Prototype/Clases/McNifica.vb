''' <summary>
''' Concrete prototype
''' </summary>
''' <remarks></remarks>
Public Class McNifica
    Inherits Hamburguesa

    Public Sub New()
        MyBase.New(TiposCarne.Vacuna)
        Medallones = 1
        TipoQueso = TiposQueso.Chedar
        FetasQueso = 1
        Salsa = TiposSalsa.Mostaza
        Tomate = True
        Pan = 2
        Nombre = "McNífica"
        Panceta = False
        Lechuga = True
        Cebolla = True
    End Sub

    Public Overrides Function Clone() As Hamburguesa
        Return Me.MemberwiseClone
    End Function
End Class
