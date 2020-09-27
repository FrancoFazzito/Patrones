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
        Me.btnCenaSolo = New System.Windows.Forms.Button()
        Me.txtPreparacionMesa = New System.Windows.Forms.TextBox()
        Me.btnCenaRomantica = New System.Windows.Forms.Button()
        Me.btnCenaSuegros = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCenaSolo
        '
        Me.btnCenaSolo.Location = New System.Drawing.Point(47, 144)
        Me.btnCenaSolo.Name = "btnCenaSolo"
        Me.btnCenaSolo.Size = New System.Drawing.Size(539, 53)
        Me.btnCenaSolo.TabIndex = 0
        Me.btnCenaSolo.Text = "Mesa para cena solitaria"
        Me.btnCenaSolo.UseVisualStyleBackColor = True
        '
        'txtPreparacionMesa
        '
        Me.txtPreparacionMesa.Location = New System.Drawing.Point(684, 144)
        Me.txtPreparacionMesa.Multiline = True
        Me.txtPreparacionMesa.Name = "txtPreparacionMesa"
        Me.txtPreparacionMesa.Size = New System.Drawing.Size(1250, 614)
        Me.txtPreparacionMesa.TabIndex = 1
        '
        'btnCenaRomantica
        '
        Me.btnCenaRomantica.Location = New System.Drawing.Point(47, 259)
        Me.btnCenaRomantica.Name = "btnCenaRomantica"
        Me.btnCenaRomantica.Size = New System.Drawing.Size(539, 53)
        Me.btnCenaRomantica.TabIndex = 2
        Me.btnCenaRomantica.Text = "Mesa para cena romántica"
        Me.btnCenaRomantica.UseVisualStyleBackColor = True
        '
        'btnCenaSuegros
        '
        Me.btnCenaSuegros.Location = New System.Drawing.Point(47, 379)
        Me.btnCenaSuegros.Name = "btnCenaSuegros"
        Me.btnCenaSuegros.Size = New System.Drawing.Size(539, 53)
        Me.btnCenaSuegros.TabIndex = 3
        Me.btnCenaSuegros.Text = "Mesa para cena con suegros"
        Me.btnCenaSuegros.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2102, 929)
        Me.Controls.Add(Me.btnCenaSuegros)
        Me.Controls.Add(Me.btnCenaRomantica)
        Me.Controls.Add(Me.txtPreparacionMesa)
        Me.Controls.Add(Me.btnCenaSolo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCenaSolo As System.Windows.Forms.Button
    Friend WithEvents txtPreparacionMesa As System.Windows.Forms.TextBox
    Friend WithEvents btnCenaRomantica As System.Windows.Forms.Button
    Friend WithEvents btnCenaSuegros As System.Windows.Forms.Button

End Class
