namespace CapaPresentesacion
{
    partial class FormVentanaRecibidos
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
            this.panelRecibidos = new System.Windows.Forms.Panel();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnMensajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelRecibidos
            // 
            this.panelRecibidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRecibidos.Location = new System.Drawing.Point(0, 36);
            this.panelRecibidos.Name = "panelRecibidos";
            this.panelRecibidos.Size = new System.Drawing.Size(984, 655);
            this.panelRecibidos.TabIndex = 5;
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.ForeColor = System.Drawing.Color.White;
            this.btnSolicitudes.Location = new System.Drawing.Point(484, 0);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(500, 35);
            this.btnSolicitudes.TabIndex = 4;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
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
            this.btnMensajes.TabIndex = 3;
            this.btnMensajes.Text = "Mensajes";
            this.btnMensajes.UseVisualStyleBackColor = false;
            this.btnMensajes.Click += new System.EventHandler(this.btnMensajes_Click);
            // 
            // ventanaRecibidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.panelRecibidos);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnMensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ventanaRecibidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaRecibidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecibidos;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnMensajes;
    }
}