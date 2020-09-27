''' <summary>
''' CONCRETE IMPLEMENTOR
''' </summary>
''' <remarks></remarks>
Public Class PizzeroArtesanal
    Implements IPizzero

    ''' <summary>
    ''' OPERATION IMPLEMENTATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CocinarPizza() As String Implements IPizzero.CocinarPizza
        Return "Colocar pizza en el horno a 180 grados por 20 minutos" & ControlChars.CrLf & _
            "Desmoldar pizza cocinada" & ControlChars.CrLf
    End Function


    ''' <summary>
    ''' OPERATION IMPLEMENTATION
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrepararPizza() As String Implements IPizzero.PrepararPizza
        Return "Amasar harina + agua + levadura + sal" & ControlChars.CrLf & _
                  "Dejar levar masa" & ControlChars.CrLf & _
                  "Estirar masa en pizzera" & ControlChars.CrLf & _
                  "Pintar con salsa" & ControlChars.CrLf & _
                  "Cortar 400 gr de muzzarella en dados" & ControlChars.CrLf & _
                  "Esparcir muzzarella" & ControlChars.CrLf & _
                  "Condimentar y colocar aceitunas" & ControlChars.CrLf
    End Function
End Class
