Imports Clases
Public Class Form1

    Dim mBigMacPrototype As New BigMac
    Dim mCBOPrototype As New CBO
    Dim mMcNificaPrototye As New McNifica
    Dim mMcPolloPrototype As New McPollo

    Dim mListaHamburguesas As New List(Of Hamburguesa)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = lstHamburgesas.Width + lstHamburgesas.Left + 50
    End Sub

    Private Sub Actualizar()
        lstHamburgesas.Items.Clear()
        For Each mH As Hamburguesa In mListaHamburguesas
            lstHamburgesas.Items.Add(mH.Descripcion)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mH As Hamburguesa = mBigMacPrototype.Clone
        If chkExtraQueso.Checked Then
            mH.FetasQueso += 1
        End If
        If chkExtraBacon.Checked Then
            mH.Panceta = True
        End If
        mListaHamburguesas.Add(mH)
        Actualizar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mH As Hamburguesa = mMcPolloPrototype.Clone
        If chkExtraQueso.Checked Then
            mH.FetasQueso += 1
        End If
        If chkExtraBacon.Checked Then
            mH.Panceta = True
        End If
        mListaHamburguesas.Add(mH)
        Actualizar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mH As Hamburguesa = mCBOPrototype.Clone
        If chkExtraQueso.Checked Then
            mH.FetasQueso += 1
        End If
        If chkExtraBacon.Checked Then
            mH.Panceta = True
        End If
        mListaHamburguesas.Add(mH)
        Actualizar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mH As Hamburguesa = mMcNificaPrototye.Clone
        If chkExtraQueso.Checked Then
            mH.FetasQueso += 1
        End If
        If chkExtraBacon.Checked Then
            mH.Panceta = True
        End If
        mListaHamburguesas.Add(mH)
        Actualizar()
    End Sub
End Class
