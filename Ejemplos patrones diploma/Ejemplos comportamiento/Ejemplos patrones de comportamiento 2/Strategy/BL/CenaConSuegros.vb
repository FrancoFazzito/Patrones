''' <summary>
''' CONCRETE STRATEGY
''' </summary>
''' <remarks></remarks>
Public Class CenaConSuegros
    Implements IPreparacionMesa

    Public Function PonerLaMesa() As String Implements IPreparacionMesa.PonerLaMesa
        Return "Mantel floreado" & ControlChars.CrLf & _
         "4 platos de porcelana" & ControlChars.CrLf & _
         "2 cuchillos finos" & ControlChars.CrLf & _
         "2 cuchillos sin filo (para los suegros)" & ControlChars.CrLf & _
         "4 tenedores finos" & ControlChars.CrLf & _
         "4 servilletas blancas" & ControlChars.CrLf & _
         "4 copas de vino" & ControlChars.CrLf & _
         "4 copas de agua" & ControlChars.CrLf & _
         "Salero y pimentero con roscas de tapa falseadas"
    End Function
End Class
