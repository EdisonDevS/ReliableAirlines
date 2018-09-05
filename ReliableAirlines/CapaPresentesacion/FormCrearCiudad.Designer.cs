namespace CapaPresentesacion
{
    partial class FormCrearCiudad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardarCiudad = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAeropuerto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAeropuerto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCiudadAeropuerto = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarCiudad
            // 
            this.btnGuardarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnGuardarCiudad.FlatAppearance.BorderSize = 0;
            this.btnGuardarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCiudad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCiudad.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCiudad.Location = new System.Drawing.Point(648, 9);
            this.btnGuardarCiudad.Name = "btnGuardarCiudad";
            this.btnGuardarCiudad.Size = new System.Drawing.Size(112, 36);
            this.btnGuardarCiudad.TabIndex = 15;
            this.btnGuardarCiudad.Text = "Guardar ruta";
            this.btnGuardarCiudad.UseVisualStyleBackColor = false;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(371, 12);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(271, 33);
            this.txtCiudad.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de la nueva ciudad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnGuardarCiudad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 58);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Agregar ciudad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 1);
            this.panel2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Agregar aeropuerto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.cbbCiudadAeropuerto);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAeropuerto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAeropuerto);
            this.panel3.Location = new System.Drawing.Point(16, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 95);
            this.panel3.TabIndex = 44;
            // 
            // btnAeropuerto
            // 
            this.btnAeropuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnAeropuerto.FlatAppearance.BorderSize = 0;
            this.btnAeropuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAeropuerto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAeropuerto.ForeColor = System.Drawing.Color.White;
            this.btnAeropuerto.Location = new System.Drawing.Point(644, 47);
            this.btnAeropuerto.Name = "btnAeropuerto";
            this.btnAeropuerto.Size = new System.Drawing.Size(112, 36);
            this.btnAeropuerto.TabIndex = 15;
            this.btnAeropuerto.Text = "Guardar ruta";
            this.btnAeropuerto.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre del nuevo aeropuerto:";
            // 
            // txtAeropuerto
            // 
            this.txtAeropuerto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAeropuerto.Location = new System.Drawing.Point(367, 12);
            this.txtAeropuerto.Name = "txtAeropuerto";
            this.txtAeropuerto.Size = new System.Drawing.Size(271, 33);
            this.txtAeropuerto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ciudad del aeropuerto:";
            // 
            // cbbCiudadAeropuerto
            // 
            this.cbbCiudadAeropuerto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbbCiudadAeropuerto.FormattingEnabled = true;
            this.cbbCiudadAeropuerto.Location = new System.Drawing.Point(367, 50);
            this.cbbCiudadAeropuerto.Name = "cbbCiudadAeropuerto";
            this.cbbCiudadAeropuerto.Size = new System.Drawing.Size(271, 32);
            this.cbbCiudadAeropuerto.TabIndex = 17;
            // 
            // FormCrearCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCrearCiudad";
            this.Text = "FormCrearCiudad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbCiudadAeropuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAeropuerto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAeropuerto;
    }
}