namespace CapaPresentesacion
{
    partial class FormVistaPrincipalTripulante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaPrincipalTripulante));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnMiCuenta = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnIntinerario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.panelContainer.ForeColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(245, 36);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1103, 685);
            this.panelContainer.TabIndex = 7;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.panelSuperior.Controls.Add(this.lblRuta);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(245, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1103, 36);
            this.panelSuperior.TabIndex = 5;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(4, 0);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblRuta.Size = new System.Drawing.Size(85, 37);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Inicio";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.pictureBox1);
            this.panelLateral.Controls.Add(this.btnMiCuenta);
            this.panelLateral.Controls.Add(this.btnInformes);
            this.panelLateral.Controls.Add(this.btnIntinerario);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(245, 721);
            this.panelLateral.TabIndex = 6;
            // 
            // btnMiCuenta
            // 
            this.btnMiCuenta.FlatAppearance.BorderSize = 0;
            this.btnMiCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMiCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiCuenta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiCuenta.ForeColor = System.Drawing.Color.White;
            this.btnMiCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btnMiCuenta.Image")));
            this.btnMiCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiCuenta.Location = new System.Drawing.Point(0, 570);
            this.btnMiCuenta.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnMiCuenta.Name = "btnMiCuenta";
            this.btnMiCuenta.Size = new System.Drawing.Size(278, 55);
            this.btnMiCuenta.TabIndex = 4;
            this.btnMiCuenta.Text = "Mi cuenta";
            this.btnMiCuenta.UseVisualStyleBackColor = true;
            this.btnMiCuenta.Click += new System.EventHandler(this.btnMiCuenta_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes.Image")));
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 388);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(278, 55);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnIntinerario
            // 
            this.btnIntinerario.FlatAppearance.BorderSize = 0;
            this.btnIntinerario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnIntinerario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntinerario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntinerario.ForeColor = System.Drawing.Color.White;
            this.btnIntinerario.Image = ((System.Drawing.Image)(resources.GetObject("btnIntinerario.Image")));
            this.btnIntinerario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntinerario.Location = new System.Drawing.Point(0, 206);
            this.btnIntinerario.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnIntinerario.Name = "btnIntinerario";
            this.btnIntinerario.Size = new System.Drawing.Size(278, 55);
            this.btnIntinerario.TabIndex = 1;
            this.btnIntinerario.Text = "Intinerario";
            this.btnIntinerario.UseVisualStyleBackColor = true;
            this.btnIntinerario.Click += new System.EventHandler(this.btnIntinerario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 144);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reliable\r\nAirlines\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormVistaPrincipalTripulante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVistaPrincipalTripulante";
            this.Text = "FormVistaPrincipalTripulante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnMiCuenta;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnIntinerario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}