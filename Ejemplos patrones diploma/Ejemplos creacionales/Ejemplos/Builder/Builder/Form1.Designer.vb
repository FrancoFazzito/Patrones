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
        Me.btnEscritorio = New System.Windows.Forms.Button()
        Me.btnNotebook = New System.Windows.Forms.Button()
        Me.btnTablet = New System.Windows.Forms.Button()
        Me.btnSmartPhone = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEscritorio
        '
        Me.btnEscritorio.Location = New System.Drawing.Point(96, 117)
        Me.btnEscritorio.Name = "btnEscritorio"
        Me.btnEscritorio.Size = New System.Drawing.Size(386, 51)
        Me.btnEscritorio.TabIndex = 0
        Me.btnEscritorio.Text = "PC de escritorio"
        Me.btnEscritorio.UseVisualStyleBackColor = True
        '
        'btnNotebook
        '
        Me.btnNotebook.Location = New System.Drawing.Point(96, 198)
        Me.btnNotebook.Name = "btnNotebook"
        Me.btnNotebook.Size = New System.Drawing.Size(386, 51)
        Me.btnNotebook.TabIndex = 1
        Me.btnNotebook.Text = "Notebook"
        Me.btnNotebook.UseVisualStyleBackColor = True
        '
        'btnTablet
        '
        Me.btnTablet.Location = New System.Drawing.Point(96, 282)
        Me.btnTablet.Name = "btnTablet"
        Me.btnTablet.Size = New System.Drawing.Size(386, 51)
        Me.btnTablet.TabIndex = 2
        Me.btnTablet.Text = "Tablet"
        Me.btnTablet.UseVisualStyleBackColor = True
        '
        'btnSmartPhone
        '
        Me.btnSmartPhone.Location = New System.Drawing.Point(96, 366)
        Me.btnSmartPhone.Name = "btnSmartPhone"
        Me.btnSmartPhone.Size = New System.Drawing.Size(386, 51)
        Me.btnSmartPhone.TabIndex = 3
        Me.btnSmartPhone.Text = "SmartPhone"
        Me.btnSmartPhone.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(687, 117)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(581, 307)
        Me.txtDescripcion.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1551, 705)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnSmartPhone)
        Me.Controls.Add(Me.btnTablet)
        Me.Controls.Add(Me.btnNotebook)
        Me.Controls.Add(Me.btnEscritorio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEscritorio As System.Windows.Forms.Button
    Friend WithEvents btnNotebook As System.Windows.Forms.Button
    Friend WithEvents btnTablet As System.Windows.Forms.Button
    Friend WithEvents btnSmartPhone As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox

End Class
