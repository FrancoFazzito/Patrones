Public Class Cotillon

    Dim mCosto As Double
    Public ReadOnly Property Costo As Double
        Get
            Return mCosto
        End Get
    End Property

    Public Function Contratar(pCantidad As Integer, pFecha As DateTime) As String
        mCosto = 80 * pCantidad
        Return "Cotillón para " & pCantidad & " personas: " & mCosto & ControlChars.CrLf
    End Function

End Class
