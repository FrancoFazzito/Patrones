''' <summary>
''' FLIGHTWEIGHT
''' </summary>
''' <remarks></remarks>
Public Interface IModeloAuto

    ReadOnly Property Marca As String
    ReadOnly Property Modelo As String
    ReadOnly Property Color As String


    Function Describir() As String
End Interface
