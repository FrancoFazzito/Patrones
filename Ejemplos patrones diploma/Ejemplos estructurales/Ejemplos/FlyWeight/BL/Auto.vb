Public Class Auto
    Implements IModeloAuto

    Friend Sub New(pModelo As ModeloAuto, pPatente As String, pTitular As String)
        mModelo = pModelo
        Patente = pPatente
        Titular = pTitular
    End Sub

    Dim mModelo As ModeloAuto

    Public ReadOnly Property Color As String Implements IModeloAuto.Color
        Get
            Return mModelo.Color
        End Get
    End Property

    Public ReadOnly Property Marca As String Implements IModeloAuto.Marca
        Get
            Return mModelo.Marca
        End Get
    End Property

    Public ReadOnly Property Modelo As String Implements IModeloAuto.Modelo
        Get
            Return mModelo.Modelo
        End Get
    End Property

    Public Property Patente As String
    Public Property Titular As String

    Public Function Describir() As String Implements IModeloAuto.Describir
        Return mModelo.Describir & ", dominio " & Patente & ", de " & Titular
    End Function
End Class
