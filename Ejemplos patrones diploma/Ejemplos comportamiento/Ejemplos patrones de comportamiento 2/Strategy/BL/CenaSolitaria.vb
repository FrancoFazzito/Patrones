''' <summary>
''' CONCRETE STRATEGY
''' </summary>
''' <remarks></remarks>
Public Class CenaSolitaria
    Implements IPreparacionMesa

    Public Function PonerLaMesa() As String Implements IPreparacionMesa.PonerLaMesa
        Return "1 mantel individual" & ControlChars.CrLf & _
            "1 plato diario" & ControlChars.CrLf & _
            "1 cuchillo Tramontina" & ControlChars.CrLf & _
            "1 tenedor Tramontina" & ControlChars.CrLf & _
            "1 rollo de papel de cocina" & ControlChars.CrLf & _
            "1 chop de cerveza" & ControlChars.CrLf & _
            "Control remoto de la tele"
    End Function
End Class
