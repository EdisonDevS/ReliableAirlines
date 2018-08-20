namespace CapaPresentesacion
{
    partial class FormAdminNominaConsulta
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
            this.panelConsultaNomina = new System.Windows.Forms.Panel();
            this.btnConsultaPersona = new System.Windows.Forms.Button();
            this.btnConsultaGenera = new System.Windows.Forms.Button();
            this.btnConsultaGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelConsultaNomina
            // 
            this.panelConsultaNomina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConsultaNomina.Location = new System.Drawing.Point(0, 39);
            this.panelConsultaNomina.Name = "panelConsultaNomina";
            this.panelConsultaNomina.Size = new System.Drawing.Size(497, 164);
            this.panelConsultaNomina.TabIndex = 45;
            // 
            // btnConsultaPersona
            // 
            this.btnConsultaPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnConsultaPersona.FlatAppearance.BorderSize = 0;
            this.btnConsultaPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPersona.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPersona.ForeColor = System.Drawing.Color.White;
            this.btnConsultaPersona.Location = new System.Drawing.Point(168, 12);
            this.btnConsultaPersona.Name = "btnConsultaPersona";
            this.btnConsultaPersona.Size = new System.Drawing.Size(80, 28);
            this.btnConsultaPersona.TabIndex = 47;
            this.btnConsultaPersona.Text = "Ajustes de nómina";
            this.btnConsultaPersona.UseVisualStyleBackColor = false;
            this.btnConsultaPersona.Click += new System.EventHandler(this.btnConsultaPersona_Click);
            // 
            // btnConsultaGenera
            // 
            this.btnConsultaGenera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnConsultaGenera.FlatAppearance.BorderSize = 0;
            this.btnConsultaGenera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGenera.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGenera.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGenera.Location = new System.Drawing.Point(248, 12);
            this.btnConsultaGenera.Name = "btnConsultaGenera";
            this.btnConsultaGenera.Size = new System.Drawing.Size(80, 28);
            this.btnConsultaGenera.TabIndex = 46;
            this.btnConsultaGenera.Text = "Consultas generales";
            this.btnConsultaGenera.UseVisualStyleBackColor = false;
            this.btnConsultaGenera.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnConsultaGeneral.FlatAppearance.BorderSize = 0;
            this.btnConsultaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeneral.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeneral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(240, 12);
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.Size = new System.Drawing.Size(88, 28);
            this.btnConsultaGeneral.TabIndex = 46;
            this.btnConsultaGeneral.Text = "Consulta general";
            this.btnConsultaGeneral.UseVisualStyleBackColor = false;
            this.btnConsultaGeneral.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // consultaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 203);
            this.Controls.Add(this.btnConsultaPersona);
            this.Controls.Add(this.btnConsultaGenera);
            this.Controls.Add(this.panelConsultaNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultaNomina";
            this.Text = "consultaNomina";
            this.Load += new System.EventHandler(this.consultaNomina_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelConsultaNomina;
        private System.Windows.Forms.Button btnConsultaPersona;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnConsultaGenera;
        private System.Windows.Forms.Button btnConsultaGeneral;
    }
}