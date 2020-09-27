''' <summary>
''' Concrete prototype
''' </summary>
''' <remarks></remarks>
Public Class CBO
    Inherits Hamburguesa

    Public Sub New()
        MyBase.New(TiposCarne.Pollo)
        Medallones = 1
        TipoQueso = TiposQueso.Chedar
        FetasQueso = 1
        Salsa = TiposSalsa.Mayonesa
        Tomate = False
        Pan = 2
        Nombre = "CBO"
        Panceta = True
        Lechuga = True
        Cebolla = True
    End Sub

    Public Overrides Function Clone() As Hamburguesa
        Return Me.MemberwiseClone
    End Function
End Class
