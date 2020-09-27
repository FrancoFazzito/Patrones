''' <summary>
''' FLIGHTWEIGHT FACTORY
''' </summary>
''' <remarks></remarks>
Public Class Concesionario

    Dim mModelos As New Dictionary(Of String, IModeloAuto)

    Public Function Vender(pMarca As String, pModelo As String, pColor As String, pPatente As String, pTitular As String) As IModeloAuto

        Dim mKey As String = pMarca.ToUpper & pModelo.ToUpper & pColor.ToUpper

        If Not mModelos.ContainsKey(mKey) Then
            mModelos.Add(mKey, New ModeloAuto(pMarca, pModelo, pColor))
        End If
        Return New Auto(mModelos(mKey), pPatente, pTitular)

    End Function

End Class
