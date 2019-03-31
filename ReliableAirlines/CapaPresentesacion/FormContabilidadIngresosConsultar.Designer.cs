namespace CapaPresentesacion
{
    partial class FormContabilidadIngresosConsultar
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
            this.panelConsultarIngreso = new System.Windows.Forms.Panel();
            this.btnExternos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelConsultarIngreso
            // 
            this.panelConsultarIngreso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConsultarIngreso.Location = new System.Drawing.Point(0, 42);
            this.panelConsultarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsultarIngreso.Name = "panelConsultarIngreso";
            this.panelConsultarIngreso.Size = new System.Drawing.Size(1312, 679);
            this.panelConsultarIngreso.TabIndex = 11;
            // 
            // btnExternos
            // 
            this.btnExternos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnExternos.FlatAppearance.BorderSize = 0;
            this.btnExternos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExternos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExternos.ForeColor = System.Drawing.Color.White;
            this.btnExternos.Location = new System.Drawing.Point(645, 0);
            this.btnExternos.Margin = new System.Windows.Forms.Padding(4);
            this.btnExternos.Name = "btnExternos";
            this.btnExternos.Size = new System.Drawing.Size(667, 43);
            this.btnExternos.TabIndex = 10;
            this.btnExternos.Text = "Ingresos externos";
            this.btnExternos.UseVisualStyleBackColor = false;
            this.btnExternos.Click += new System.EventHandler(this.btnExternos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(0, 0);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(667, 43);
            this.btnVentas.TabIndex = 9;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // FormContabilidadIngresosConsultar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 721);
            this.Controls.Add(this.panelConsultarIngreso);
            this.Controls.Add(this.btnExternos);
            this.Controls.Add(this.btnVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContabilidadIngresosConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContabilidadIngresosConsultar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarIngreso;
        private System.Windows.Forms.Button btnExternos;
        private System.Windows.Forms.Button btnVentas;
    }
}