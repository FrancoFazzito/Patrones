Imports BL
Public Class Form1

    Dim mCIITI As New CIITI

    Private Sub btnALumno_Click(sender As Object, e As EventArgs) Handles btnALumno.Click
        Dim mAlumno As New AlumnoUAI With {.Nombre = "Juan", .Apellido = "Pereyra", .DNI = "44332244", .Legajo = "1210"}
        txtAcreditaciones.Text &= mCIITI.Ingresar(mAlumno)
    End Sub

    Private Sub btnDocente_Click(sender As Object, e As EventArgs) Handles btnDocente.Click
        Dim mDocente As New DocenteUAI With {.Nombre = "Leonardo", .Apellido = "Ghigliani", .Cargo = "Profesor", .DNI = "22334455", .Sede = "Centro"}
        txtAcreditaciones.Text &= mCIITI.Ingresar(mDocente)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = txtAcreditaciones.Width + txtAcreditaciones.Left + 100
    End Sub

    Private Sub btnExterno_Click(sender As Object, e As EventArgs) Handles btnExterno.Click
        Dim mAcademico As New AcademicoExterno With {.Nombre = "Miguel", .Apellido = "Perez", .DNI = "12319933", .Institucion = "UBA", .Cargo = "Decano"}
        txtAcreditaciones.Text &= mCIITI.Ingresar(mAcademico)
    End Sub

    Private Sub bnGeneral_Click(sender As Object, e As EventArgs) Handles bnGeneral.Click
        Dim mAsistente As New AsistenteGeneral With {.Nombre = "Jorge", .Apellido = "Ferreira", .DNI = "24203112"}
        txtAcreditaciones.Text &= mCIITI.Ingresar(mAsistente)
    End Sub
End Class
