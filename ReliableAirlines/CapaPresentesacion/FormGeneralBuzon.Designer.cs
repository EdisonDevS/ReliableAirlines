namespace CapaPresentesacion
{
    partial class FormGeneralBuzon
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
            this.btnRedactar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecibidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRedactar
            // 
            this.btnRedactar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnRedactar.FlatAppearance.BorderSize = 0;
            this.btnRedactar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedactar.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedactar.ForeColor = System.Drawing.Color.White;
            this.btnRedactar.Location = new System.Drawing.Point(12, 63);
            this.btnRedactar.Name = "btnRedactar";
            this.btnRedactar.Size = new System.Drawing.Size(229, 100);
            this.btnRedactar.TabIndex = 80;
            this.btnRedactar.Text = "Enviar";
            this.btnRedactar.UseVisualStyleBackColor = false;
            this.btnRedactar.Click += new System.EventHandler(this.btnRedactar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(247, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 100);
            this.panel1.TabIndex = 79;
            // 
            // btnRecibidos
            // 
            this.btnRecibidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnRecibidos.FlatAppearance.BorderSize = 0;
            this.btnRecibidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibidos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibidos.ForeColor = System.Drawing.Color.White;
            this.btnRecibidos.Location = new System.Drawing.Point(256, 63);
            this.btnRecibidos.Name = "btnRecibidos";
            this.btnRecibidos.Size = new System.Drawing.Size(229, 100);
            this.btnRecibidos.TabIndex = 78;
            this.btnRecibidos.Text = "Recibidos";
            this.btnRecibidos.UseVisualStyleBackColor = false;
            this.btnRecibidos.Click += new System.EventHandler(this.btnRecibidos_Click);
            // 
            // menuBuzon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 227);
            this.Controls.Add(this.btnRedactar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRecibidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuBuzon";
            this.Text = "menuBuzon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRedactar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecibidos;
    }
}