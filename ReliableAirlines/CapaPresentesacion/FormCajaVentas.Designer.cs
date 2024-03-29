﻿namespace CapaPresentesacion
{
    partial class FormCajaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCajaVentas));
            this.pnlActivoVenta = new System.Windows.Forms.Panel();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelEleccionVentas = new System.Windows.Forms.Panel();
            this.panelActivoValidacion = new System.Windows.Forms.Panel();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlActivoVenta
            // 
            this.pnlActivoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlActivoVenta.Location = new System.Drawing.Point(248, 212);
            this.pnlActivoVenta.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActivoVenta.Name = "pnlActivoVenta";
            this.pnlActivoVenta.Size = new System.Drawing.Size(182, 10);
            this.pnlActivoVenta.TabIndex = 18;
            this.pnlActivoVenta.Visible = false;
            // 
            // btnVenta
            // 
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.Location = new System.Drawing.Point(248, 13);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(182, 211);
            this.btnVenta.TabIndex = 17;
            this.btnVenta.Text = "Venta";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelEleccionVentas
            // 
            this.panelEleccionVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEleccionVentas.Location = new System.Drawing.Point(13, 233);
            this.panelEleccionVentas.Margin = new System.Windows.Forms.Padding(4);
            this.panelEleccionVentas.Name = "panelEleccionVentas";
            this.panelEleccionVentas.Size = new System.Drawing.Size(1077, 440);
            this.panelEleccionVentas.TabIndex = 19;
            // 
            // panelActivoValidacion
            // 
            this.panelActivoValidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panelActivoValidacion.Location = new System.Drawing.Point(672, 212);
            this.panelActivoValidacion.Margin = new System.Windows.Forms.Padding(4);
            this.panelActivoValidacion.Name = "panelActivoValidacion";
            this.panelActivoValidacion.Size = new System.Drawing.Size(186, 10);
            this.panelActivoValidacion.TabIndex = 21;
            this.panelActivoValidacion.Visible = false;
            // 
            // btnValidacion
            // 
            this.btnValidacion.FlatAppearance.BorderSize = 0;
            this.btnValidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidacion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacion.ForeColor = System.Drawing.Color.White;
            this.btnValidacion.Image = ((System.Drawing.Image)(resources.GetObject("btnValidacion.Image")));
            this.btnValidacion.Location = new System.Drawing.Point(672, 13);
            this.btnValidacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(186, 211);
            this.btnValidacion.TabIndex = 20;
            this.btnValidacion.Text = "Validación";
            this.btnValidacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValidacion.UseVisualStyleBackColor = true;
            this.btnValidacion.Click += new System.EventHandler(this.btnValidacion_Click);
            // 
            // FormCajaVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1103, 685);
            this.Controls.Add(this.panelActivoValidacion);
            this.Controls.Add(this.btnValidacion);
            this.Controls.Add(this.panelEleccionVentas);
            this.Controls.Add(this.pnlActivoVenta);
            this.Controls.Add(this.btnVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCajaVentas";
            this.Text = "FormVentasVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActivoVenta;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelEleccionVentas;
        private System.Windows.Forms.Panel panelActivoValidacion;
        private System.Windows.Forms.Button btnValidacion;
    }
}