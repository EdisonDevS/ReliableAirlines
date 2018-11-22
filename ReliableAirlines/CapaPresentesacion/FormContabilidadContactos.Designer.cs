namespace CapaPresentesacion
{
    partial class FormContabilidadContactos
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
            this.btnCrearContacto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearContacto
            // 
            this.btnCrearContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearContacto.FlatAppearance.BorderSize = 0;
            this.btnCrearContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearContacto.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearContacto.ForeColor = System.Drawing.Color.White;
            this.btnCrearContacto.Location = new System.Drawing.Point(16, 78);
            this.btnCrearContacto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearContacto.Name = "btnCrearContacto";
            this.btnCrearContacto.Size = new System.Drawing.Size(305, 123);
            this.btnCrearContacto.TabIndex = 86;
            this.btnCrearContacto.Text = "Crear contacto";
            this.btnCrearContacto.UseVisualStyleBackColor = false;
            this.btnCrearContacto.Click += new System.EventHandler(this.btnCrearContacto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(329, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 123);
            this.panel1.TabIndex = 85;
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnModificarContacto.FlatAppearance.BorderSize = 0;
            this.btnModificarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarContacto.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarContacto.ForeColor = System.Drawing.Color.White;
            this.btnModificarContacto.Location = new System.Drawing.Point(341, 78);
            this.btnModificarContacto.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(305, 123);
            this.btnModificarContacto.TabIndex = 84;
            this.btnModificarContacto.Text = "Modificar contacto";
            this.btnModificarContacto.UseVisualStyleBackColor = false;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // FormContabilidadContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(663, 279);
            this.Controls.Add(this.btnCrearContacto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificarContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContabilidadContactos";
            this.Text = "FormContabilidadContactos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearContacto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificarContacto;
    }
}