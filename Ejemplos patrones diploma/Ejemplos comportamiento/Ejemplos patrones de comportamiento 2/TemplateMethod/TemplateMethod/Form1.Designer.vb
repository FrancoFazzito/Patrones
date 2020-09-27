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
        Me.btnEnvio = New System.Windows.Forms.Button()
        Me.btnMostrador = New System.Windows.Forms.Button()
        Me.grdProductos = New System.Windows.Forms.DataGridView()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnvio
        '
        Me.btnEnvio.Location = New System.Drawing.Point(170, 581)
        Me.btnEnvio.Name = "btnEnvio"
        Me.btnEnvio.Size = New System.Drawing.Size(436, 51)
        Me.btnEnvio.TabIndex = 0
        Me.btnEnvio.Text = "Cerrar venta con envío"
        Me.btnEnvio.UseVisualStyleBackColor = True
        '
        'btnMostrador
        '
        Me.btnMostrador.Location = New System.Drawing.Point(170, 506)
        Me.btnMostrador.Name = "btnMostrador"
        Me.btnMostrador.Size = New System.Drawing.Size(436, 51)
        Me.btnMostrador.TabIndex = 1
        Me.btnMostrador.Text = "Cerrar venta x mostrador"
        Me.btnMostrador.UseVisualStyleBackColor = True
        '
        'grdProductos
        '
        Me.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProductos.Location = New System.Drawing.Point(152, 58)
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.RowTemplate.Height = 40
        Me.grdProductos.Size = New System.Drawing.Size(1147, 269)
        Me.grdProductos.TabIndex = 2
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(211, 423)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(340, 39)
        Me.cmbFormaPago.TabIndex = 3
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(859, 586)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(281, 38)
        Me.txtTotal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(718, 589)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1699, 755)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.grdProductos)
        Me.Controls.Add(Me.btnMostrador)
        Me.Controls.Add(Me.btnEnvio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnvio As System.Windows.Forms.Button
    Friend WithEvents btnMostrador As System.Windows.Forms.Button
    Friend WithEvents grdProductos As System.Windows.Forms.DataGridView
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
