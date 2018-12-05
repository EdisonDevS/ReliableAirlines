namespace CapaPresentesacion
{
    partial class FormCambioContraseña
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVerificar = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblDocumento);
            this.panel1.Controls.Add(this.txtVerificar);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 313);
            this.panel1.TabIndex = 75;
            // 
            // txtVerificar
            // 
            this.txtVerificar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtVerificar.Location = new System.Drawing.Point(297, 149);
            this.txtVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificar.Name = "txtVerificar";
            this.txtVerificar.PasswordChar = '*';
            this.txtVerificar.Size = new System.Drawing.Size(249, 37);
            this.txtVerificar.TabIndex = 77;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtContraseña.Location = new System.Drawing.Point(297, 110);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(249, 37);
            this.txtContraseña.TabIndex = 76;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(25, 154);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(255, 28);
            this.label19.TabIndex = 75;
            this.label19.Text = "Verificar contraseña:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(393, 204);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(153, 54);
            this.btnGuardarCambios.TabIndex = 74;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(25, 115);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 28);
            this.label17.TabIndex = 69;
            this.label17.Text = "Nueva contraseña:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(25, 26);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(161, 28);
            this.lblDocumento.TabIndex = 78;
            this.lblDocumento.Text = "Documento: ";
            // 
            // FormCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(597, 313);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCambioContraseña";
            this.Text = "FormCambioContraseña";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtVerificar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label17;
    }
}