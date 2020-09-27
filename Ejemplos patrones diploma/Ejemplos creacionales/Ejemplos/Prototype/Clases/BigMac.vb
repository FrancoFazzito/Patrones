''' <summary>
''' Concrete prototype
''' </summary>
''' <remarks></remarks>
Public Class BigMac
    Inherits Hamburguesa

    Public Sub New()
        MyBase.New(TiposCarne.Vacuna)
        Medallones = 2
        TipoQueso = TiposQueso.Chedar
        FetasQueso = 2
        Salsa = TiposSalsa.BigMac
        Tomate = False
        Pan = 2
        Nombre = "Big Mac"
        Panceta = False
        Lechuga = True
        Cebolla = True
    End Sub

    Public Overrides Function Clone() As Hamburguesa
        Return Me.MemberwiseClone
    End Function
End Class
