namespace CapaPresentesacion
{
    partial class FormEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadistica));
            this.pnlActivoAfluencia = new System.Windows.Forms.Panel();
            this.panelEleccionEstadistica = new System.Windows.Forms.Panel();
            this.pnlActivoCiudades = new System.Windows.Forms.Panel();
            this.pnlActivoOtro = new System.Windows.Forms.Panel();
            this.btnAfluencia = new System.Windows.Forms.Button();
            this.btnCiudad = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlActivoAfluencia
            // 
            this.pnlActivoAfluencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlActivoAfluencia.Location = new System.Drawing.Point(111, 142);
            this.pnlActivoAfluencia.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActivoAfluencia.Name = "pnlActivoAfluencia";
            this.pnlActivoAfluencia.Size = new System.Drawing.Size(107, 10);
            this.pnlActivoAfluencia.TabIndex = 20;
            this.pnlActivoAfluencia.Visible = false;
            // 
            // panelEleccionEstadistica
            // 
            this.panelEleccionEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEleccionEstadistica.Location = new System.Drawing.Point(16, 159);
            this.panelEleccionEstadistica.Margin = new System.Windows.Forms.Padding(4);
            this.panelEleccionEstadistica.Name = "panelEleccionEstadistica";
            this.panelEleccionEstadistica.Size = new System.Drawing.Size(663, 279);
            this.panelEleccionEstadistica.TabIndex = 24;
            // 
            // pnlActivoCiudades
            // 
            this.pnlActivoCiudades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlActivoCiudades.Location = new System.Drawing.Point(293, 142);
            this.pnlActivoCiudades.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActivoCiudades.Name = "pnlActivoCiudades";
            this.pnlActivoCiudades.Size = new System.Drawing.Size(107, 10);
            this.pnlActivoCiudades.TabIndex = 22;
            this.pnlActivoCiudades.Visible = false;
            // 
            // pnlActivoOtro
            // 
            this.pnlActivoOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlActivoOtro.Location = new System.Drawing.Point(477, 142);
            this.pnlActivoOtro.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActivoOtro.Name = "pnlActivoOtro";
            this.pnlActivoOtro.Size = new System.Drawing.Size(107, 10);
            this.pnlActivoOtro.TabIndex = 22;
            this.pnlActivoOtro.Visible = false;
            // 
            // btnAfluencia
            // 
            this.btnAfluencia.FlatAppearance.BorderSize = 0;
            this.btnAfluencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfluencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfluencia.ForeColor = System.Drawing.Color.White;
            this.btnAfluencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAfluencia.Image")));
            this.btnAfluencia.Location = new System.Drawing.Point(111, 15);
            this.btnAfluencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfluencia.Name = "btnAfluencia";
            this.btnAfluencia.Size = new System.Drawing.Size(107, 137);
            this.btnAfluencia.TabIndex = 19;
            this.btnAfluencia.Text = "Afluencia";
            this.btnAfluencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAfluencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAfluencia.UseVisualStyleBackColor = true;
            this.btnAfluencia.Click += new System.EventHandler(this.btnAfluencia_Click);
            // 
            // btnCiudad
            // 
            this.btnCiudad.FlatAppearance.BorderSize = 0;
            this.btnCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiudad.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiudad.ForeColor = System.Drawing.Color.White;
            this.btnCiudad.Image = ((System.Drawing.Image)(resources.GetObject("btnCiudad.Image")));
            this.btnCiudad.Location = new System.Drawing.Point(293, 15);
            this.btnCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnCiudad.Name = "btnCiudad";
            this.btnCiudad.Size = new System.Drawing.Size(107, 137);
            this.btnCiudad.TabIndex = 21;
            this.btnCiudad.Text = "Ciudad";
            this.btnCiudad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCiudad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCiudad.UseVisualStyleBackColor = true;
            this.btnCiudad.Click += new System.EventHandler(this.btnCiudad_Click);
            // 
            // btnOtros
            // 
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtros.ForeColor = System.Drawing.Color.White;
            this.btnOtros.Image = ((System.Drawing.Image)(resources.GetObject("btnOtros.Image")));
            this.btnOtros.Location = new System.Drawing.Point(477, 15);
            this.btnOtros.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(107, 137);
            this.btnOtros.TabIndex = 21;
            this.btnOtros.Text = "Pendiente";
            this.btnOtros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOtros.UseVisualStyleBackColor = true;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(972, 597);
            this.Controls.Add(this.pnlActivoOtro);
            this.Controls.Add(this.btnOtros);
            this.Controls.Add(this.pnlActivoCiudades);
            this.Controls.Add(this.btnCiudad);
            this.Controls.Add(this.panelEleccionEstadistica);
            this.Controls.Add(this.pnlActivoAfluencia);
            this.Controls.Add(this.btnAfluencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstadistica";
            this.Text = "FormEstadistica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActivoAfluencia;
        private System.Windows.Forms.Panel panelEleccionEstadistica;
        private System.Windows.Forms.Panel pnlActivoCiudades;
        private System.Windows.Forms.Panel pnlActivoOtro;
        private System.Windows.Forms.Button btnAfluencia;
        private System.Windows.Forms.Button btnCiudad;
        private System.Windows.Forms.Button btnOtros;
    }
}