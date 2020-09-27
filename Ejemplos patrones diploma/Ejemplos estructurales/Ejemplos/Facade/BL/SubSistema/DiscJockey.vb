Public Class DiscJockey


    Const EquipoChico As String = "Potencia 80W, 2 cajas de 2 vías"
    Const EquipoMediano As String = "Potencia 150W, 2 cajas de 3 vías"
    Const EquipoGrande As String = "Potencia 300W, 2 subwoofer, 4 bocinas, 2 tweeters"

    Public Property Iluminacion As Boolean
    Public Property MaquinaHumo As Boolean
    Public Property EfectosLaser As Boolean

    Dim mCosto As Double
    Public ReadOnly Property Costo As Double
        Get
            Return mCosto
        End Get
    End Property

    Public Function Contratar(pCantidad As Integer, pFecha As DateTime)
        Dim mRes As String

        Select Case pCantidad
            Case Is <= 100
                mRes = "Equipo de audio: " & EquipoChico & ControlChars.CrLf
                mCosto = 2000
            Case 101 To 500
                mRes = "Equipo de audio: " & EquipoMediano & ControlChars.CrLf
                mCosto = 5000
            Case Else
                mRes = "Equipo de audio: " & EquipoGrande & ControlChars.CrLf
                mCosto = 7000
        End Select

        If Iluminacion Then
            mCosto += 2000
            mRes &= "Iluminación con dos torres y 10 efectos" & ControlChars.CrLf
        End If

        If MaquinaHumo Then
            mCosto += 5 * pCantidad
            mRes &= "Máquina de humo" & ControlChars.CrLf
        End If

        If EfectosLaser Then
            mCosto += 3000
            mRes &= "Máquina de efectos láser (20 efectos)" & ControlChars.CrLf
        End If

        mRes &= "Costo DiscJockey: " & mCosto & ControlChars.CrLf
        Return mRes
    End Function

End Class
