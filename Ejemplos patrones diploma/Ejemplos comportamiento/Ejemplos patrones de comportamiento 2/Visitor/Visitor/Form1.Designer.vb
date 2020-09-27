<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAcreditaciones = New System.Windows.Forms.TextBox()
        Me.btnALumno = New System.Windows.Forms.Button()
        Me.btnDocente = New System.Windows.Forms.Button()
        Me.btnExterno = New System.Windows.Forms.Button()
        Me.bnGeneral = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAcreditaciones
        '
        Me.txtAcreditaciones.Location = New System.Drawing.Point(516, 70)
        Me.txtAcreditaciones.Multiline = True
        Me.txtAcreditaciones.Name = "txtAcreditaciones"
        Me.txtAcreditaciones.Size = New System.Drawing.Size(1422, 692)
        Me.txtAcreditaciones.TabIndex = 0
        '
        'btnALumno
        '
        Me.btnALumno.Location = New System.Drawing.Point(38, 289)
        Me.btnALumno.Name = "btnALumno"
        Me.btnALumno.Size = New System.Drawing.Size(435, 53)
        Me.btnALumno.TabIndex = 1
        Me.btnALumno.Text = "Alumno UAI"
        Me.btnALumno.UseVisualStyleBackColor = True
        '
        'btnDocente
        '
        Me.btnDocente.Location = New System.Drawing.Point(38, 390)
        Me.btnDocente.Name = "btnDocente"
        Me.btnDocente.Size = New System.Drawing.Size(435, 53)
        Me.btnDocente.TabIndex = 2
        Me.btnDocente.Text = "Docente UAI"
        Me.btnDocente.UseVisualStyleBackColor = True
        '
        'btnExterno
        '
        Me.btnExterno.Location = New System.Drawing.Point(38, 492)
        Me.btnExterno.Name = "btnExterno"
        Me.btnExterno.Size = New System.Drawing.Size(435, 53)
        Me.btnExterno.TabIndex = 3
        Me.btnExterno.Text = "Académico externo"
        Me.btnExterno.UseVisualStyleBackColor = True
        '
        'bnGeneral
        '
        Me.bnGeneral.Location = New System.Drawing.Point(38, 591)
        Me.bnGeneral.Name = "bnGeneral"
        Me.bnGeneral.Size = New System.Drawing.Size(435, 53)
        Me.bnGeneral.TabIndex = 4
        Me.bnGeneral.Text = "Público general"
        Me.bnGeneral.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingreso al CIITI"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1990, 819)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnGeneral)
        Me.Controls.Add(Me.btnExterno)
        Me.Controls.Add(Me.btnDocente)
        Me.Controls.Add(Me.btnALumno)
        Me.Controls.Add(Me.txtAcreditaciones)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAcreditaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnALumno As System.Windows.Forms.Button
    Friend WithEvents btnDocente As System.Windows.Forms.Button
    Friend WithEvents btnExterno As System.Windows.Forms.Button
    Friend WithEvents bnGeneral As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
