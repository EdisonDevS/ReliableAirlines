namespace CapaPresentesacion
{
    partial class FormClientesReservas
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
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnMisVuelos = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(0, 0);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(173, 31);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar vuelo";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnMisVuelos
            // 
            this.btnMisVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnMisVuelos.FlatAppearance.BorderSize = 0;
            this.btnMisVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisVuelos.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMisVuelos.ForeColor = System.Drawing.Color.White;
            this.btnMisVuelos.Location = new System.Drawing.Point(173, 0);
            this.btnMisVuelos.Name = "btnMisVuelos";
            this.btnMisVuelos.Size = new System.Drawing.Size(173, 31);
            this.btnMisVuelos.TabIndex = 1;
            this.btnMisVuelos.Text = "Mis vuelos";
            this.btnMisVuelos.UseVisualStyleBackColor = false;
            this.btnMisVuelos.Click += new System.EventHandler(this.btnMisVuelos_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(346, 0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(173, 31);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panelContainer.Location = new System.Drawing.Point(0, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(519, 317);
            this.panelContainer.TabIndex = 3;
            // 
            // FormClientesReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(528, 357);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnMisVuelos);
            this.Controls.Add(this.btnReservar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientesReservas";
            this.Text = "FormClientesReservasMisReservas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnMisVuelos;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Panel panelContainer;
    }
}