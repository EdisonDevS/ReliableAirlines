﻿namespace CapaPresentesacion
{
    partial class FormVistaPrincipalVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaPrincipalVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnMiCuenta = new System.Windows.Forms.Button();
            this.btnBuzon = new System.Windows.Forms.Button();
            this.btnReembolso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reliable\r\nAirlines\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(245, 36);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(729, 615);
            this.panelContainer.TabIndex = 4;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.panelSuperior.Controls.Add(this.lblRuta);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(245, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(729, 36);
            this.panelSuperior.TabIndex = 2;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(3, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblRuta.Size = new System.Drawing.Size(67, 29);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Inicio";
            // 
            // btnVenta
            // 
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(0, 167);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(278, 55);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.pictureBox1);
            this.panelLateral.Controls.Add(this.btnMiCuenta);
            this.panelLateral.Controls.Add(this.btnBuzon);
            this.panelLateral.Controls.Add(this.btnReembolso);
            this.panelLateral.Controls.Add(this.btnVenta);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(245, 651);
            this.panelLateral.TabIndex = 3;
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
            this.btnMiCuenta.Location = new System.Drawing.Point(0, 559);
            this.btnMiCuenta.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMiCuenta.Name = "btnMiCuenta";
            this.btnMiCuenta.Size = new System.Drawing.Size(278, 55);
            this.btnMiCuenta.TabIndex = 4;
            this.btnMiCuenta.Text = "Mi cuenta";
            this.btnMiCuenta.UseVisualStyleBackColor = true;
            // 
            // btnBuzon
            // 
            this.btnBuzon.FlatAppearance.BorderSize = 0;
            this.btnBuzon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuzon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuzon.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuzon.ForeColor = System.Drawing.Color.White;
            this.btnBuzon.Image = ((System.Drawing.Image)(resources.GetObject("btnBuzon.Image")));
            this.btnBuzon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuzon.Location = new System.Drawing.Point(0, 422);
            this.btnBuzon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuzon.Name = "btnBuzon";
            this.btnBuzon.Size = new System.Drawing.Size(278, 55);
            this.btnBuzon.TabIndex = 3;
            this.btnBuzon.Text = "Buzón";
            this.btnBuzon.UseVisualStyleBackColor = true;
            // 
            // btnReembolso
            // 
            this.btnReembolso.FlatAppearance.BorderSize = 0;
            this.btnReembolso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReembolso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReembolso.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReembolso.ForeColor = System.Drawing.Color.White;
            this.btnReembolso.Image = ((System.Drawing.Image)(resources.GetObject("btnReembolso.Image")));
            this.btnReembolso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReembolso.Location = new System.Drawing.Point(0, 296);
            this.btnReembolso.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnReembolso.Name = "btnReembolso";
            this.btnReembolso.Size = new System.Drawing.Size(278, 55);
            this.btnReembolso.TabIndex = 2;
            this.btnReembolso.Text = "Reembolso";
            this.btnReembolso.UseVisualStyleBackColor = true;
            // 
            // FormVistaPrincipalVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 651);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLateral);
            this.Name = "FormVistaPrincipalVentas";
            this.Text = "FormVistaPrincipalVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnMiCuenta;
        private System.Windows.Forms.Button btnBuzon;
        private System.Windows.Forms.Button btnReembolso;
    }
}