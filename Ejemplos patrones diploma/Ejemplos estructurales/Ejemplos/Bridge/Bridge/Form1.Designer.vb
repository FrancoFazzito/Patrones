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
        Me.txtTareas = New System.Windows.Forms.TextBox()
        Me.btnTakeAway = New System.Windows.Forms.Button()
        Me.btnRestaurante = New System.Windows.Forms.Button()
        Me.grpPizzeria = New System.Windows.Forms.GroupBox()
        Me.rdbCadena = New System.Windows.Forms.RadioButton()
        Me.rdbArtesanal = New System.Windows.Forms.RadioButton()
        Me.grpPizzeria.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTareas
        '
        Me.txtTareas.Location = New System.Drawing.Point(719, 119)
        Me.txtTareas.Multiline = True
        Me.txtTareas.Name = "txtTareas"
        Me.txtTareas.Size = New System.Drawing.Size(1120, 533)
        Me.txtTareas.TabIndex = 0
        '
        'btnTakeAway
        '
        Me.btnTakeAway.Location = New System.Drawing.Point(17, 221)
        Me.btnTakeAway.Name = "btnTakeAway"
        Me.btnTakeAway.Size = New System.Drawing.Size(467, 66)
        Me.btnTakeAway.TabIndex = 1
        Me.btnTakeAway.Text = "Take away"
        Me.btnTakeAway.UseVisualStyleBackColor = True
        '
        'btnRestaurante
        '
        Me.btnRestaurante.Location = New System.Drawing.Point(17, 319)
        Me.btnRestaurante.Name = "btnRestaurante"
        Me.btnRestaurante.Size = New System.Drawing.Size(467, 66)
        Me.btnRestaurante.TabIndex = 2
        Me.btnRestaurante.Text = "A la mesa"
        Me.btnRestaurante.UseVisualStyleBackColor = True
        '
        'grpPizzeria
        '
        Me.grpPizzeria.Controls.Add(Me.btnRestaurante)
        Me.grpPizzeria.Controls.Add(Me.rdbCadena)
        Me.grpPizzeria.Controls.Add(Me.btnTakeAway)
        Me.grpPizzeria.Controls.Add(Me.rdbArtesanal)
        Me.grpPizzeria.Location = New System.Drawing.Point(107, 59)
        Me.grpPizzeria.Name = "grpPizzeria"
        Me.grpPizzeria.Size = New System.Drawing.Size(503, 535)
        Me.grpPizzeria.TabIndex = 5
        Me.grpPizzeria.TabStop = False
        Me.grpPizzeria.Text = "Pizzería"
        '
        'rdbCadena
        '
        Me.rdbCadena.AutoSize = True
        Me.rdbCadena.Location = New System.Drawing.Point(270, 127)
        Me.rdbCadena.Name = "rdbCadena"
        Me.rdbCadena.Size = New System.Drawing.Size(159, 36)
        Me.rdbCadena.TabIndex = 4
        Me.rdbCadena.Text = "Romario"
        Me.rdbCadena.UseVisualStyleBackColor = True
        '
        'rdbArtesanal
        '
        Me.rdbArtesanal.AutoSize = True
        Me.rdbArtesanal.Checked = True
        Me.rdbArtesanal.Location = New System.Drawing.Point(17, 127)
        Me.rdbArtesanal.Name = "rdbArtesanal"
        Me.rdbArtesanal.Size = New System.Drawing.Size(175, 36)
        Me.rdbArtesanal.TabIndex = 3
        Me.rdbArtesanal.TabStop = True
        Me.rdbArtesanal.Text = "La Nonna"
        Me.rdbArtesanal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1931, 798)
        Me.Controls.Add(Me.grpPizzeria)
        Me.Controls.Add(Me.txtTareas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpPizzeria.ResumeLayout(False)
        Me.grpPizzeria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTareas As System.Windows.Forms.TextBox
    Friend WithEvents btnTakeAway As System.Windows.Forms.Button
    Friend WithEvents btnRestaurante As System.Windows.Forms.Button
    Friend WithEvents grpPizzeria As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCadena As System.Windows.Forms.RadioButton
    Friend WithEvents rdbArtesanal As System.Windows.Forms.RadioButton

End Class
