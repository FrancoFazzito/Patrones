Public Class Fotografo

    Public Property Video As Boolean = False

    Public Property Camaras As Integer = 1

    Dim mCosto As Double
    Public ReadOnly Property Costo As Double
        Get
            Return mCosto
        End Get
    End Property

    Public Function Contratar(pCantidad As Integer, pFecha As DateTime) As String
        Dim mRes As String
        mCosto = 100 * pCantidad

        If Camaras > 1 Then
            mCosto *= ((Camaras - 1) * 0.3) '30% más por cada cámara adicional
        End If
        mRes = "Fotografía con " & Camaras & " cámaras para " & pCantidad & " personas" & ControlChars.CrLf
        If Video Then
            mCosto += 100 * pCantidad
            mRes = "Video con edición digital. Se entregan masters y 4 copias" & ControlChars.CrLf
        End If

        Return mRes
    End Function


End Class
