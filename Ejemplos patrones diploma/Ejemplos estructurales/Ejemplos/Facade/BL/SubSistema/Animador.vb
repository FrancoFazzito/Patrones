Public Class Animador

    Public Enum TipoAnimacion
        Infantil
        Adultos
    End Enum

    Public Enum NivelAnimacion
        Exclusivo
        Normal
        Economico
    End Enum

    Public Property Tipo As TipoAnimacion

    Public Property Nivel As NivelAnimacion

    Dim mCosto As Double
    Public ReadOnly Property Costo As Double
        Get
            Return mCosto
        End Get
    End Property

    Public Function Contratar(pFecha As DateTime) As String
        Dim mRes As String = "Animación: " & ControlChars.CrLf

        Select Case Tipo
            Case TipoAnimacion.Infantil
                Select Case Nivel
                    Case NivelAnimacion.Economico
                        mCosto = 2000
                        mRes &= "Animación infantil con el Mago sin dientes: " & mCosto & ControlChars.CrLf
                    Case NivelAnimacion.Normal
                        mCosto = 6000
                        mRes &= "Animación infantil con Piñón fijo: " & mCosto & ControlChars.CrLf
                    Case NivelAnimacion.Exclusivo
                        mCosto = 40000
                        mRes &= "Show en vivo con elenco de Walt Disney: " & mCosto & ControlChars.CrLf

                End Select
            Case TipoAnimacion.Adultos
                Select Case Nivel
                    Case NivelAnimacion.Economico
                        mCosto = 3000
                        mRes &= "Standup y animación económica: " & mCosto & ControlChars.CrLf
                    Case NivelAnimacion.Normal
                        mCosto = 10000
                        mRes &= "Show de Fabio Posca: " & mCosto & ControlChars.CrLf
                    Case NivelAnimacion.Exclusivo
                        mCosto = 50000
                        mRes &= "Standup en vivo de Jerry Seinfeld: " & mCosto & ControlChars.CrLf
                End Select
        End Select

        Return mRes
    End Function


End Class
