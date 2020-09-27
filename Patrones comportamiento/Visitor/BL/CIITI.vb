''' <summary>
''' CLIENT
''' </summary>
''' <remarks></remarks>
Public Class CIITI

    Public Shared Property PrecioEntrada As Double = 550

    Dim mAcreditador As New Acreditador
    Dim mCobrador As New Cobrador

    Public Function Ingresar(pAsistente As Asistente) As String

        Return pAsistente.Accept(mAcreditador) & ControlChars.CrLf & pAsistente.Accept(mCobrador) & ControlChars.CrLf & ControlChars.CrLf

    End Function


End Class
