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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.chkPremium = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoticias = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPoliciales = New System.Windows.Forms.Button()
        Me.btnEconomia = New System.Windows.Forms.Button()
        Me.btnPolitica = New System.Windows.Forms.Button()
        Me.btnArticulo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(288, 113)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(362, 38)
        Me.txtNombre.TabIndex = 0
        '
        'chkPremium
        '
        Me.chkPremium.AutoSize = True
        Me.chkPremium.Location = New System.Drawing.Point(692, 115)
        Me.chkPremium.Name = "chkPremium"
        Me.chkPremium.Size = New System.Drawing.Size(166, 36)
        Me.chkPremium.TabIndex = 1
        Me.chkPremium.Text = "Premium"
        Me.chkPremium.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(890, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre usuario:"
        '
        'txtNoticias
        '
        Me.txtNoticias.Location = New System.Drawing.Point(47, 192)
        Me.txtNoticias.Multiline = True
        Me.txtNoticias.Name = "txtNoticias"
        Me.txtNoticias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoticias.Size = New System.Drawing.Size(1726, 803)
        Me.txtNoticias.TabIndex = 4
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(1464, 117)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(121, 32)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Usuario:"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(1273, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 51)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(472, 58)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Diario edición digital"
        '
        'btnPoliciales
        '
        Me.btnPoliciales.Enabled = False
        Me.btnPoliciales.Location = New System.Drawing.Point(37, 1039)
        Me.btnPoliciales.Name = "btnPoliciales"
        Me.btnPoliciales.Size = New System.Drawing.Size(155, 51)
        Me.btnPoliciales.TabIndex = 8
        Me.btnPoliciales.Text = "Policiales"
        Me.btnPoliciales.UseVisualStyleBackColor = True
        '
        'btnEconomia
        '
        Me.btnEconomia.Enabled = False
        Me.btnEconomia.Location = New System.Drawing.Point(290, 1039)
        Me.btnEconomia.Name = "btnEconomia"
        Me.btnEconomia.Size = New System.Drawing.Size(155, 51)
        Me.btnEconomia.TabIndex = 9
        Me.btnEconomia.Text = "Economía"
        Me.btnEconomia.UseVisualStyleBackColor = True
        '
        'btnPolitica
        '
        Me.btnPolitica.Enabled = False
        Me.btnPolitica.Location = New System.Drawing.Point(544, 1039)
        Me.btnPolitica.Name = "btnPolitica"
        Me.btnPolitica.Size = New System.Drawing.Size(155, 51)
        Me.btnPolitica.TabIndex = 10
        Me.btnPolitica.Text = "Política"
        Me.btnPolitica.UseVisualStyleBackColor = True
        '
        'btnArticulo
        '
        Me.btnArticulo.Enabled = False
        Me.btnArticulo.Location = New System.Drawing.Point(798, 1039)
        Me.btnArticulo.Name = "btnArticulo"
        Me.btnArticulo.Size = New System.Drawing.Size(234, 51)
        Me.btnArticulo.TabIndex = 11
        Me.btnArticulo.Text = "Leer artículo"
        Me.btnArticulo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1852, 1129)
        Me.Controls.Add(Me.btnArticulo)
        Me.Controls.Add(Me.btnPolitica)
        Me.Controls.Add(Me.btnEconomia)
        Me.Controls.Add(Me.btnPoliciales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtNoticias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkPremium)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents chkPremium As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoticias As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPoliciales As System.Windows.Forms.Button
    Friend WithEvents btnEconomia As System.Windows.Forms.Button
    Friend WithEvents btnPolitica As System.Windows.Forms.Button
    Friend WithEvents btnArticulo As System.Windows.Forms.Button

End Class
