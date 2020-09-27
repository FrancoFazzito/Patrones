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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lstHamburgesas = New System.Windows.Forms.ListBox()
        Me.chkExtraQueso = New System.Windows.Forms.CheckBox()
        Me.chkExtraBacon = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "BigMac"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(37, 93)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "McPollo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(37, 141)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 25)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CBO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(37, 191)
        Me.Button4.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 25)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "McNífica"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lstHamburgesas
        '
        Me.lstHamburgesas.FormattingEnabled = True
        Me.lstHamburgesas.Location = New System.Drawing.Point(146, 48)
        Me.lstHamburgesas.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.lstHamburgesas.Name = "lstHamburgesas"
        Me.lstHamburgesas.Size = New System.Drawing.Size(581, 173)
        Me.lstHamburgesas.TabIndex = 4
        '
        'chkExtraQueso
        '
        Me.chkExtraQueso.AutoSize = True
        Me.chkExtraQueso.Location = New System.Drawing.Point(37, 244)
        Me.chkExtraQueso.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkExtraQueso.Name = "chkExtraQueso"
        Me.chkExtraQueso.Size = New System.Drawing.Size(82, 17)
        Me.chkExtraQueso.TabIndex = 5
        Me.chkExtraQueso.Text = "Extra queso"
        Me.chkExtraQueso.UseVisualStyleBackColor = True
        '
        'chkExtraBacon
        '
        Me.chkExtraBacon.AutoSize = True
        Me.chkExtraBacon.Location = New System.Drawing.Point(37, 273)
        Me.chkExtraBacon.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkExtraBacon.Name = "chkExtraBacon"
        Me.chkExtraBacon.Size = New System.Drawing.Size(83, 17)
        Me.chkExtraBacon.TabIndex = 6
        Me.chkExtraBacon.Text = "Extra bacon"
        Me.chkExtraBacon.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 311)
        Me.Controls.Add(Me.chkExtraBacon)
        Me.Controls.Add(Me.chkExtraQueso)
        Me.Controls.Add(Me.lstHamburgesas)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "Form1"
        Me.Text = "Prototype"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lstHamburgesas As System.Windows.Forms.ListBox
    Friend WithEvents chkExtraQueso As System.Windows.Forms.CheckBox
    Friend WithEvents chkExtraBacon As System.Windows.Forms.CheckBox

End Class
