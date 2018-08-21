namespace CapaPresentesacion
{
    partial class FormVentasVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentasVenta));
            this.pnlActivoNomina = new System.Windows.Forms.Panel();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelEleccionAdmin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlActivoNomina
            // 
            this.pnlActivoNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlActivoNomina.Location = new System.Drawing.Point(106, 115);
            this.pnlActivoNomina.Name = "pnlActivoNomina";
            this.pnlActivoNomina.Size = new System.Drawing.Size(80, 8);
            this.pnlActivoNomina.TabIndex = 18;
            this.pnlActivoNomina.Visible = false;
            // 
            // btnVenta
            // 
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.Location = new System.Drawing.Point(106, 12);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(80, 111);
            this.btnVenta.TabIndex = 17;
            this.btnVenta.Text = "Venta";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // panelEleccionAdmin
            // 
            this.panelEleccionAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEleccionAdmin.Location = new System.Drawing.Point(25, 230);
            this.panelEleccionAdmin.Name = "panelEleccionAdmin";
            this.panelEleccionAdmin.Size = new System.Drawing.Size(497, 227);
            this.panelEleccionAdmin.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(324, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 8);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // btnValidacion
            // 
            this.btnValidacion.FlatAppearance.BorderSize = 0;
            this.btnValidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidacion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacion.ForeColor = System.Drawing.Color.White;
            this.btnValidacion.Image = ((System.Drawing.Image)(resources.GetObject("btnValidacion.Image")));
            this.btnValidacion.Location = new System.Drawing.Point(324, 12);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(80, 111);
            this.btnValidacion.TabIndex = 20;
            this.btnValidacion.Text = "Validacion";
            this.btnValidacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValidacion.UseVisualStyleBackColor = true;
            // 
            // FormVentasVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1053, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnValidacion);
            this.Controls.Add(this.panelEleccionAdmin);
            this.Controls.Add(this.pnlActivoNomina);
            this.Controls.Add(this.btnVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentasVenta";
            this.Text = "FormVentasVenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActivoNomina;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelEleccionAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnValidacion;
    }
}