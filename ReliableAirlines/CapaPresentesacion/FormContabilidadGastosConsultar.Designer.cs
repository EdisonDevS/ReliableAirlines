﻿namespace CapaPresentesacion
{
    partial class FormContabilidadGastosConsultar
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
            this.panelConsultarGasto = new System.Windows.Forms.Panel();
            this.btnOtros = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelConsultarGasto
            // 
            this.panelConsultarGasto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConsultarGasto.Location = new System.Drawing.Point(0, 36);
            this.panelConsultarGasto.Name = "panelConsultarGasto";
            this.panelConsultarGasto.Size = new System.Drawing.Size(984, 655);
            this.panelConsultarGasto.TabIndex = 8;
            // 
            // btnOtros
            // 
            this.btnOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtros.ForeColor = System.Drawing.Color.White;
            this.btnOtros.Location = new System.Drawing.Point(484, 0);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(500, 35);
            this.btnOtros.TabIndex = 7;
            this.btnOtros.Text = "Otros gastos";
            this.btnOtros.UseVisualStyleBackColor = false;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // btnNomina
            // 
            this.btnNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnNomina.FlatAppearance.BorderSize = 0;
            this.btnNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomina.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomina.ForeColor = System.Drawing.Color.White;
            this.btnNomina.Location = new System.Drawing.Point(0, 0);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(500, 35);
            this.btnNomina.TabIndex = 6;
            this.btnNomina.Text = "Pago de nomina";
            this.btnNomina.UseVisualStyleBackColor = false;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // FormContabilidadGastosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.panelConsultarGasto);
            this.Controls.Add(this.btnOtros);
            this.Controls.Add(this.btnNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormContabilidadGastosConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContabilidadGastosConsulta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarGasto;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Button btnNomina;
    }
}