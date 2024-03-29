﻿namespace CapaPresentesacion
{
    partial class FormAdminAeronaves
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
            this.panelAeronaves = new System.Windows.Forms.Panel();
            this.btnRegistrarAeronave = new System.Windows.Forms.Button();
            this.btnAdministrarAeronave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelAeronaves
            // 
            this.panelAeronaves.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAeronaves.Location = new System.Drawing.Point(0, 54);
            this.panelAeronaves.Margin = new System.Windows.Forms.Padding(4);
            this.panelAeronaves.Name = "panelAeronaves";
            this.panelAeronaves.Size = new System.Drawing.Size(1077, 386);
            this.panelAeronaves.TabIndex = 9;
            this.panelAeronaves.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAeronaves_Paint);
            // 
            // btnRegistrarAeronave
            // 
            this.btnRegistrarAeronave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnRegistrarAeronave.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAeronave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAeronave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAeronave.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAeronave.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarAeronave.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarAeronave.Name = "btnRegistrarAeronave";
            this.btnRegistrarAeronave.Size = new System.Drawing.Size(539, 50);
            this.btnRegistrarAeronave.TabIndex = 13;
            this.btnRegistrarAeronave.Text = "Registrar aeronave";
            this.btnRegistrarAeronave.UseVisualStyleBackColor = false;
            this.btnRegistrarAeronave.Click += new System.EventHandler(this.btnRegistrarAeronave_Click);
            // 
            // btnAdministrarAeronave
            // 
            this.btnAdministrarAeronave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnAdministrarAeronave.FlatAppearance.BorderSize = 0;
            this.btnAdministrarAeronave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdministrarAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarAeronave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarAeronave.ForeColor = System.Drawing.Color.White;
            this.btnAdministrarAeronave.Location = new System.Drawing.Point(539, 0);
            this.btnAdministrarAeronave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministrarAeronave.Name = "btnAdministrarAeronave";
            this.btnAdministrarAeronave.Size = new System.Drawing.Size(538, 50);
            this.btnAdministrarAeronave.TabIndex = 12;
            this.btnAdministrarAeronave.Text = "Administrar aeronave";
            this.btnAdministrarAeronave.UseVisualStyleBackColor = false;
            this.btnAdministrarAeronave.Click += new System.EventHandler(this.btnAdministrarAeronave_Click);
            // 
            // FormAdminAeronaves
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 440);
            this.Controls.Add(this.btnAdministrarAeronave);
            this.Controls.Add(this.btnRegistrarAeronave);
            this.Controls.Add(this.panelAeronaves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminAeronaves";
            this.Text = "menuAeronaves";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAeronaves;
        private System.Windows.Forms.Button btnRegistrarAeronave;
        private System.Windows.Forms.Button btnAdministrarAeronave;
    }
}