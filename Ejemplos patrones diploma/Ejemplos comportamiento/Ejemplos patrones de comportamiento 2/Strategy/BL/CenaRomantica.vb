''' <summary>
''' CONCRETE STRATEGY
''' </summary>
''' <remarks></remarks>
Public Class CenaRomantica
    Implements IPreparacionMesa

    Public Function PonerLaMesa() As String Implements IPreparacionMesa.PonerLaMesa
        Return "Mantel rojo" & ControlChars.CrLf & _
           "2 platos de porcelana" & ControlChars.CrLf & _
           "2 platos de sitio" & ControlChars.CrLf & _
           "2 cuchillos finos" & ControlChars.CrLf & _
           "2 tenedores finos" & ControlChars.CrLf & _
           "2 servilletas con motivos románticos" & ControlChars.CrLf & _
           "2 copas de vino" & ControlChars.CrLf & _
           "2 copas de agua" & ControlChars.CrLf & _
           "Hornillo con aroma a sándalo" & ControlChars.CrLf & _
           "Candelabro con vela"
    End Function
End Class
