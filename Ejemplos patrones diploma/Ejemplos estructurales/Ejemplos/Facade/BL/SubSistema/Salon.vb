Public Class Salon

    Const mPrecioSalonChico As Double = 40000
    Const mPrecioSalonMediano As Double = 70000
    Const mPrecioSalonGrande As Double = 100000

    Dim mCosto As Double
    Public ReadOnly Property Costo As Double
        Get
            Return mCosto
        End Get
    End Property

    Public Function Reservar(pInvitados As Integer, pFecha As DateTime) As String
        Dim mRes As String = "Verificando disponibilidad del salón " & ControlChars.CrLf & _
            "Salón disponible" & ControlChars.CrLf
        Dim mSalonTxt = ""
        Select Case pInvitados
            Case Is <= 100
                mCosto = mPrecioSalonChico
                mSalonTxt = " chico "
            Case 101 To 500
                mCosto = mPrecioSalonMediano
                mSalonTxt = " mediano "
            Case Else
                mCosto = mPrecioSalonGrande
                mSalonTxt = " grande "
        End Select

        If (pFecha.Month = 11 Or pFecha.Month = 12) Then 'Los salones son 20% más caros en Noviembre y Diciembre
            mCosto *= 1.2
            mRes &= "Costo del salón aumenta 20% por ser meses de temporada alta" & ControlChars.CrLf
        End If

        mRes &= "Costo del salón" & mSalonTxt & ": " & mCosto & ControlChars.CrLf
        Return mRes
    End Function


End Class
