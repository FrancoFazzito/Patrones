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
        Me.btnCombustible = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtEstadoAuto = New System.Windows.Forms.TextBox()
        Me.btnEncender = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.btnAcelerar = New System.Windows.Forms.Button()
        Me.btnFrenar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCombustible
        '
        Me.btnCombustible.Location = New System.Drawing.Point(398, 57)
        Me.btnCombustible.Name = "btnCombustible"
        Me.btnCombustible.Size = New System.Drawing.Size(383, 51)
        Me.btnCombustible.TabIndex = 0
        Me.btnCombustible.Text = "Cargar combustible"
        Me.btnCombustible.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(275, 64)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 38)
        Me.txtCantidad.TabIndex = 2
        Me.txtCantidad.Text = "30"
        '
        'txtEstadoAuto
        '
        Me.txtEstadoAuto.Location = New System.Drawing.Point(1239, 145)
        Me.txtEstadoAuto.Multiline = True
        Me.txtEstadoAuto.Name = "txtEstadoAuto"
        Me.txtEstadoAuto.Size = New System.Drawing.Size(830, 288)
        Me.txtEstadoAuto.TabIndex = 3
        '
        'btnEncender
        '
        Me.btnEncender.Location = New System.Drawing.Point(275, 170)
        Me.btnEncender.Name = "btnEncender"
        Me.btnEncender.Size = New System.Drawing.Size(506, 51)
        Me.btnEncender.TabIndex = 4
        Me.btnEncender.Text = "Encender"
        Me.btnEncender.UseVisualStyleBackColor = True
        '
        'btnApagar
        '
        Me.btnApagar.Location = New System.Drawing.Point(275, 245)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(506, 51)
        Me.btnApagar.TabIndex = 5
        Me.btnApagar.Text = "Apagar"
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'btnAcelerar
        '
        Me.btnAcelerar.Location = New System.Drawing.Point(275, 319)
        Me.btnAcelerar.Name = "btnAcelerar"
        Me.btnAcelerar.Size = New System.Drawing.Size(506, 51)
        Me.btnAcelerar.TabIndex = 6
        Me.btnAcelerar.Text = "Acelerar"
        Me.btnAcelerar.UseVisualStyleBackColor = True
        '
        'btnFrenar
        '
        Me.btnFrenar.Location = New System.Drawing.Point(275, 393)
        Me.btnFrenar.Name = "btnFrenar"
        Me.btnFrenar.Size = New System.Drawing.Size(506, 51)
        Me.btnFrenar.TabIndex = 7
        Me.btnFrenar.Text = "Frenar"
        Me.btnFrenar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2424, 763)
        Me.Controls.Add(Me.btnFrenar)
        Me.Controls.Add(Me.btnAcelerar)
        Me.Controls.Add(Me.btnApagar)
        Me.Controls.Add(Me.btnEncender)
        Me.Controls.Add(Me.txtEstadoAuto)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnCombustible)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCombustible As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoAuto As System.Windows.Forms.TextBox
    Friend WithEvents btnEncender As System.Windows.Forms.Button
    Friend WithEvents btnApagar As System.Windows.Forms.Button
    Friend WithEvents btnAcelerar As System.Windows.Forms.Button
    Friend WithEvents btnFrenar As System.Windows.Forms.Button

End Class
