''' <summary>
''' PRODUCT
''' </summary>
''' <remarks></remarks>
Public Class Computadora

    Public Enum TipoComputadora
        Escritorio
        Notebook
        Tablet
        SmartPhone
    End Enum

    Public Sub New(pTipo As TipoComputadora)
        mTipo = pTipo
    End Sub

    Dim mTipo As TipoComputadora
    Public ReadOnly Property Tipo As TipoComputadora
        Get
            Return mTipo
        End Get
    End Property

    Public Property Monitor As String

    Public Property Teclado As String

    Public Property CPU As String

    Public Property Control As String

    Public Function MostrarDescripción() As String

        Return "CPU: " & CPU & ControlChars.CrLf & _
            "Monitor: " & Monitor & ControlChars.CrLf & _
            "Teclado: " & Teclado & ControlChars.CrLf & _
            "Control: " & Control

    End Function

End Class
