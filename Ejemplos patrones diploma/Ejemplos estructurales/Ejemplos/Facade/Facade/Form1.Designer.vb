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
        Me.txtPresupuesto = New System.Windows.Forms.TextBox()
        Me.btnCasamiento = New System.Windows.Forms.Button()
        Me.btnInfantil = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbAlta = New System.Windows.Forms.RadioButton()
        Me.rdbCompleta = New System.Windows.Forms.RadioButton()
        Me.rdbModerada = New System.Windows.Forms.RadioButton()
        Me.rdbFamiliar = New System.Windows.Forms.RadioButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtInvitados = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.Location = New System.Drawing.Point(769, 3)
        Me.txtPresupuesto.Multiline = True
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(1301, 960)
        Me.txtPresupuesto.TabIndex = 0
        '
        'btnCasamiento
        '
        Me.btnCasamiento.Location = New System.Drawing.Point(183, 552)
        Me.btnCasamiento.Name = "btnCasamiento"
        Me.btnCasamiento.Size = New System.Drawing.Size(408, 53)
        Me.btnCasamiento.TabIndex = 1
        Me.btnCasamiento.Text = "Casamiento"
        Me.btnCasamiento.UseVisualStyleBackColor = True
        '
        'btnInfantil
        '
        Me.btnInfantil.Location = New System.Drawing.Point(183, 646)
        Me.btnInfantil.Name = "btnInfantil"
        Me.btnInfantil.Size = New System.Drawing.Size(408, 53)
        Me.btnInfantil.TabIndex = 2
        Me.btnInfantil.Text = "Cumple infantil"
        Me.btnInfantil.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbFamiliar)
        Me.GroupBox1.Controls.Add(Me.rdbModerada)
        Me.GroupBox1.Controls.Add(Me.rdbCompleta)
        Me.GroupBox1.Controls.Add(Me.rdbAlta)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 168)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nivel de gasto estimado"
        '
        'rdbAlta
        '
        Me.rdbAlta.AutoSize = True
        Me.rdbAlta.Location = New System.Drawing.Point(57, 60)
        Me.rdbAlta.Name = "rdbAlta"
        Me.rdbAlta.Size = New System.Drawing.Size(178, 36)
        Me.rdbAlta.TabIndex = 0
        Me.rdbAlta.Text = "Alta fiesta"
        Me.rdbAlta.UseVisualStyleBackColor = True
        '
        'rdbCompleta
        '
        Me.rdbCompleta.AutoSize = True
        Me.rdbCompleta.Location = New System.Drawing.Point(57, 113)
        Me.rdbCompleta.Name = "rdbCompleta"
        Me.rdbCompleta.Size = New System.Drawing.Size(253, 36)
        Me.rdbCompleta.TabIndex = 1
        Me.rdbCompleta.Text = "Fiesta completa"
        Me.rdbCompleta.UseVisualStyleBackColor = True
        '
        'rdbModerada
        '
        Me.rdbModerada.AutoSize = True
        Me.rdbModerada.Checked = True
        Me.rdbModerada.Location = New System.Drawing.Point(344, 60)
        Me.rdbModerada.Name = "rdbModerada"
        Me.rdbModerada.Size = New System.Drawing.Size(265, 36)
        Me.rdbModerada.TabIndex = 2
        Me.rdbModerada.TabStop = True
        Me.rdbModerada.Text = "Fiesta moderada"
        Me.rdbModerada.UseVisualStyleBackColor = True
        '
        'rdbFamiliar
        '
        Me.rdbFamiliar.AutoSize = True
        Me.rdbFamiliar.Location = New System.Drawing.Point(344, 113)
        Me.rdbFamiliar.Name = "rdbFamiliar"
        Me.rdbFamiliar.Size = New System.Drawing.Size(259, 36)
        Me.rdbFamiliar.TabIndex = 3
        Me.rdbFamiliar.Text = "Reunión familiar"
        Me.rdbFamiliar.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(385, 406)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(181, 38)
        Me.dtpFecha.TabIndex = 4
        '
        'txtInvitados
        '
        Me.txtInvitados.Location = New System.Drawing.Point(385, 350)
        Me.txtInvitados.Name = "txtInvitados"
        Me.txtInvitados.Size = New System.Drawing.Size(181, 38)
        Me.txtInvitados.TabIndex = 5
        Me.txtInvitados.Text = "150"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cantidad de invitados:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha del evento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(579, 58)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Organización de eventos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2297, 1001)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvitados)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnInfantil)
        Me.Controls.Add(Me.btnCasamiento)
        Me.Controls.Add(Me.txtPresupuesto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents btnCasamiento As System.Windows.Forms.Button
    Friend WithEvents btnInfantil As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFamiliar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbModerada As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCompleta As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAlta As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvitados As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
