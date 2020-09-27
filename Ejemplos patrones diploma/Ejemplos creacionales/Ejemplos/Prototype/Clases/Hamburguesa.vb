''' <summary>
''' Prototype
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Hamburguesa

    Public Enum TiposCarne
        Vacuna
        Pollo
        Cerdo
    End Enum

    Public Enum TiposQueso
        Chedar
        Mozarella
        SinQueso
    End Enum

    Public Enum TiposSalsa
        BigMac
        Mayonesa
        BBQ
        Ketchup
        Mostaza
        SinSalsa
    End Enum

    Public Sub New(pTipoCarne As TiposCarne)
        mTipoCarne = pTipoCarne
    End Sub

    Public Property Medallones As Integer
    Dim mTipoCarne As TiposCarne

    Public ReadOnly Property Carne As TiposCarne
        Get
            Return mTipoCarne
        End Get
    End Property
    Public ReadOnly Property Descripcion As String
        Get
            Dim mDesc As String
            mDesc = Nombre & " [Carne: " & mTipoCarne.ToString & "(" & Medallones & ")"
            If FetasQueso > 0 Then
                mDesc &= ", " & TipoQueso.ToString & "(" & FetasQueso & ")"
            End If
            If Tomate Then
                mDesc &= ", Tomate"
            End If
            If Cebolla Then
                mDesc &= ", Cebolla"
            End If
            If Panceta Then
                mDesc &= ", Panceta"
            End If
            If Pan > 0 Then
                mDesc &= ", Pan(" & Pan & ")"
            End If
            If Salsa <> TiposSalsa.SinSalsa Then
                mDesc &= ", Salsa:" & Salsa.ToString
            End If
            mDesc &= "]"
            Return mDesc
        End Get
    End Property

    Public Property FetasQueso As Integer
    Public Property TipoQueso As TiposQueso
    Public Property Tomate As Boolean
    Public Property Salsa As TiposSalsa
    Public Property Pan As Integer
    Public Property Nombre As String
    Public Property Panceta As Boolean
    Public Property Lechuga As Boolean
    Public Property Cebolla As Boolean

    Public MustOverride Function Clone() As Hamburguesa 'Clone()

End Class
