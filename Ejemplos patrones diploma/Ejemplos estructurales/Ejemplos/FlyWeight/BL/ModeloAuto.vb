''' <summary>
''' FLIGHTWEIGHT CONCRETO
''' </summary>
''' <remarks></remarks>
Public Class ModeloAuto
    Implements IModeloAuto


    Public Sub New(pMarca As String, pModelo As String, pColor As String)
        mMarca = pMarca
        mModelo = pModelo
        mColor = pColor
    End Sub

    Dim mColor As String
    Public ReadOnly Property Color As String Implements IModeloAuto.Color
        Get
            Return mColor
        End Get
    End Property

    Dim mMarca As String
    Public ReadOnly Property Marca As String Implements IModeloAuto.Marca
        Get
            Return mMarca
        End Get
    End Property

    Dim mModelo As String
    Public ReadOnly Property Modelo As String Implements IModeloAuto.Modelo
        Get
            Return mModelo
        End Get
    End Property

    Public Function Describir() As String Implements IModeloAuto.Describir
        Return mMarca & " " & mModelo & " " & mColor
    End Function
End Class
