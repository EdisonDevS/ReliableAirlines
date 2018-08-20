namespace CapaPresentesacion
{
    partial class FormGeneralBuzonRedactar
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
            this.panelRedactar = new System.Windows.Forms.Panel();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.btnMensajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelRedactar
            // 
            this.panelRedactar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRedactar.Location = new System.Drawing.Point(0, 36);
            this.panelRedactar.Name = "panelRedactar";
            this.panelRedactar.Size = new System.Drawing.Size(984, 655);
            this.panelRedactar.TabIndex = 8;
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnSolicitud.FlatAppearance.BorderSize = 0;
            this.btnSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitud.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnSolicitud.Location = new System.Drawing.Point(484, 0);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Size = new System.Drawing.Size(500, 35);
            this.btnSolicitud.TabIndex = 7;
            this.btnSolicitud.Text = "Solicitud";
            this.btnSolicitud.UseVisualStyleBackColor = false;
            this.btnSolicitud.Click += new System.EventHandler(this.btnSolicitud_Click);
            // 
            // btnMensajes
            // 
            this.btnMensajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnMensajes.FlatAppearance.BorderSize = 0;
            this.btnMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensajes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensajes.ForeColor = System.Drawing.Color.White;
            this.btnMensajes.Location = new System.Drawing.Point(0, 0);
            this.btnMensajes.Name = "btnMensajes";
            this.btnMensajes.Size = new System.Drawing.Size(500, 35);
            this.btnMensajes.TabIndex = 6;
            this.btnMensajes.Text = "Mensaje";
            this.btnMensajes.UseVisualStyleBackColor = false;
            this.btnMensajes.Click += new System.EventHandler(this.btnMensajes_Click);
            // 
            // FormVentanaRedactar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.panelRedactar);
            this.Controls.Add(this.btnSolicitud);
            this.Controls.Add(this.btnMensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormVentanaRedactar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaRedactar";
            this.Load += new System.EventHandler(this.FormVentanaRedactar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRedactar;
        private System.Windows.Forms.Button btnSolicitud;
        private System.Windows.Forms.Button btnMensajes;
    }
}