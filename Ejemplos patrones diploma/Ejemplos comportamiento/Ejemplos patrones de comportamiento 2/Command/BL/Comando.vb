''' <summary>
''' ABSTRACT COMMAND
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Comando

    Public MustOverride Function Ejecutar() As Comando
    Public MustOverride Sub Deshacer()
End Class
