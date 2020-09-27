Public Class Transporte

    Public Enum TipoTransporte
        Limo
        CocheClasico
        Trencito
    End Enum

    Public Property Tipo As TipoTransporte

    Dim mCosto As Double
    Public ReadOnly Property Costo As Double
        Get
            Return mCosto
        End Get
    End Property

    Public Function Contratar(pFecha As DateTime) As String
        Dim mRes As String = "Transporte: " & ControlChars.CrLf
        Select Case Tipo
            Case TipoTransporte.Limo
                mCosto = 15000
                mRes = "Limousina para 6 pasajeros Lincoln: " & mCosto & ControlChars.CrLf
            Case TipoTransporte.CocheClasico
                mCosto = 8000
                mRes = "Cadillac '56: " & mCosto & ControlChars.CrLf
            Case Else
                mCosto = 4000
                mRes = "Trencito de la alegría para 35 pasajeros: " & mCosto & ControlChars.CrLf
        End Select

        Return mRes
    End Function


End Class
