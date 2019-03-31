namespace CapaPresentesacion
{
    partial class FormAdminVuelos
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
            this.btnConsultaVuelos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdministrarVuelos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaVuelos
            // 
            this.btnConsultaVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnConsultaVuelos.FlatAppearance.BorderSize = 0;
            this.btnConsultaVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaVuelos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaVuelos.ForeColor = System.Drawing.Color.White;
            this.btnConsultaVuelos.Location = new System.Drawing.Point(16, 13);
            this.btnConsultaVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaVuelos.Name = "btnConsultaVuelos";
            this.btnConsultaVuelos.Size = new System.Drawing.Size(502, 366);
            this.btnConsultaVuelos.TabIndex = 77;
            this.btnConsultaVuelos.Text = "Consultar vuelos";
            this.btnConsultaVuelos.UseVisualStyleBackColor = false;
            this.btnConsultaVuelos.Click += new System.EventHandler(this.btnConsultaVuelos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(526, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 366);
            this.panel1.TabIndex = 76;
            // 
            // btnAdministrarVuelos
            // 
            this.btnAdministrarVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnAdministrarVuelos.FlatAppearance.BorderSize = 0;
            this.btnAdministrarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarVuelos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarVuelos.ForeColor = System.Drawing.Color.White;
            this.btnAdministrarVuelos.Location = new System.Drawing.Point(538, 13);
            this.btnAdministrarVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministrarVuelos.Name = "btnAdministrarVuelos";
            this.btnAdministrarVuelos.Size = new System.Drawing.Size(520, 366);
            this.btnAdministrarVuelos.TabIndex = 75;
            this.btnAdministrarVuelos.Text = "Gestionar vuelos";
            this.btnAdministrarVuelos.UseVisualStyleBackColor = false;
            this.btnAdministrarVuelos.Click += new System.EventHandler(this.btnAdministrarVuelos_Click);
            // 
            // FormAdminVuelos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 392);
            this.Controls.Add(this.btnConsultaVuelos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdministrarVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminVuelos";
            this.Text = "administrarRuta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaVuelos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdministrarVuelos;
    }
}