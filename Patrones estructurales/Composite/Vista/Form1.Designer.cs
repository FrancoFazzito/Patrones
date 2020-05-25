namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Equipos = new System.Windows.Forms.Button();
            this.TxtPresupuesto = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEquipos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Equipos
            // 
            this.Button_Equipos.Location = new System.Drawing.Point(13, 356);
            this.Button_Equipos.Name = "Button_Equipos";
            this.Button_Equipos.Size = new System.Drawing.Size(502, 23);
            this.Button_Equipos.TabIndex = 1;
            this.Button_Equipos.Text = "Obtener Equipos";
            this.Button_Equipos.UseVisualStyleBackColor = true;
            this.Button_Equipos.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtPresupuesto
            // 
            this.TxtPresupuesto.Location = new System.Drawing.Point(14, 28);
            this.TxtPresupuesto.Name = "TxtPresupuesto";
            this.TxtPresupuesto.Size = new System.Drawing.Size(121, 20);
            this.TxtPresupuesto.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "presupuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "uso";
            // 
            // TxtEquipos
            // 
            this.TxtEquipos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEquipos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEquipos.Location = new System.Drawing.Point(13, 58);
            this.TxtEquipos.Multiline = true;
            this.TxtEquipos.Name = "TxtEquipos";
            this.TxtEquipos.ReadOnly = true;
            this.TxtEquipos.Size = new System.Drawing.Size(502, 292);
            this.TxtEquipos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 388);
            this.Controls.Add(this.TxtEquipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtPresupuesto);
            this.Controls.Add(this.Button_Equipos);
            this.Name = "Form1";
            this.Text = "Generacion equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Equipos;
        private System.Windows.Forms.TextBox TxtPresupuesto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEquipos;
    }
}

