namespace CapaPresentesacion
{
    partial class FormAdminRutasVuelos
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
            this.btnAdministrarRuta = new System.Windows.Forms.Button();
            this.panelRutas = new System.Windows.Forms.Panel();
            this.btnCrearRuta = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrarRuta
            // 
            this.btnAdministrarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnAdministrarRuta.FlatAppearance.BorderSize = 0;
            this.btnAdministrarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdministrarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarRuta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarRuta.ForeColor = System.Drawing.Color.White;
            this.btnAdministrarRuta.Location = new System.Drawing.Point(248, 0);
            this.btnAdministrarRuta.Name = "btnAdministrarRuta";
            this.btnAdministrarRuta.Size = new System.Drawing.Size(249, 27);
            this.btnAdministrarRuta.TabIndex = 4;
            this.btnAdministrarRuta.Text = "Administrar vuelos";
            this.btnAdministrarRuta.UseVisualStyleBackColor = false;
            this.btnAdministrarRuta.Click += new System.EventHandler(this.btnAdministrarRuta_Click);
            // 
            // panelRutas
            // 
            this.panelRutas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRutas.Location = new System.Drawing.Point(0, 25);
            this.panelRutas.Name = "panelRutas";
            this.panelRutas.Size = new System.Drawing.Size(497, 202);
            this.panelRutas.TabIndex = 5;
            // 
            // btnCrearRuta
            // 
            this.btnCrearRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearRuta.FlatAppearance.BorderSize = 0;
            this.btnCrearRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCrearRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRuta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRuta.ForeColor = System.Drawing.Color.White;
            this.btnCrearRuta.Location = new System.Drawing.Point(0, -2);
            this.btnCrearRuta.Name = "btnCrearRuta";
            this.btnCrearRuta.Size = new System.Drawing.Size(248, 27);
            this.btnCrearRuta.TabIndex = 6;
            this.btnCrearRuta.Text = "Crear ruta nueva";
            this.btnCrearRuta.UseVisualStyleBackColor = false;
            this.btnCrearRuta.Click += new System.EventHandler(this.btnRegistrarEmpleado_Click_1);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(1, -2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(248, 27);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear ruta nueva";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // menuRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 227);
            this.Controls.Add(this.btnCrearRuta);
            this.Controls.Add(this.panelRutas);
            this.Controls.Add(this.btnAdministrarRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuRutas";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdministrarRuta;
        private System.Windows.Forms.Panel panelRutas;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Button btnCrearRuta;
        private System.Windows.Forms.Button btnCrear;
    }
}