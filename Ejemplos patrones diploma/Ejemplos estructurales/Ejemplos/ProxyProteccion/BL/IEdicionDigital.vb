''' <summary>
''' SUBJECT
''' </summary>
''' <remarks></remarks>
Public Interface IEdicionDigital


    Function ObtenerNoticiasPoliciales() As String

    Function ObtenerNoticiasPoliticas() As String

    Function ObtenerNoticiasEconomicas() As String

    Function ObtenerNoticia(pId As Integer) As String


End Interface
