''' <summary>
''' CONCRETE IMPLEMENTOR
''' </summary>
''' <remarks></remarks>
Public Class PizzeroIndustrial
    Implements IPizzero

    ''' <summary>
    ''' OPERATION IMPLEMENTATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CocinarPizza() As String Implements IPizzero.CocinarPizza
        Return "Colocar pizza en el horno indistrial a 230 grados por 10 minutos" & ControlChars.CrLf & _
            "Desmoldar pizza cocinada" & ControlChars.CrLf
    End Function

    ''' <summary>
    ''' OPERATION IMPLEMENTATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrepararPizza() As String Implements IPizzero.PrepararPizza
        Return "Tomar prepizza de la cámara de frío" & ControlChars.CrLf & _
            "Tomar porción de muzzarella trozada de envases de cámara" & ControlChars.CrLf & _
            "Esparcir trozos de muzzarella en prepizza" & ControlChars.CrLf & _
            "Condimentar y colocar aceitunas" & ControlChars.CrLf
    End Function
End Class
