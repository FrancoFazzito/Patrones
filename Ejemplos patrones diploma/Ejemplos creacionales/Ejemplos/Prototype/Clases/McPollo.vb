''' <summary>
''' Concrete prototype
''' </summary>
''' <remarks></remarks>
Public Class McPollo
    Inherits Hamburguesa

    Public Sub New()
        MyBase.New(TiposCarne.Pollo)
        Medallones = 1
        TipoQueso = TiposQueso.SinQueso
        FetasQueso = 0
        Salsa = TiposSalsa.Mayonesa
        Tomate = False
        Pan = 2
        Nombre = "McPollo"
        Panceta = False
        Lechuga = True
        Cebolla = False
    End Sub

    Public Overrides Function Clone() As Hamburguesa
        Return Me.MemberwiseClone
    End Function
End Class
