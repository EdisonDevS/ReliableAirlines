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
            this.pnlActivoGeneral = new System.Windows.Forms.Panel();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panelEleccionContabilidad = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlActivoGeneral
            // 
            this.pnlActivoGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlActivoGeneral.Location = new System.Drawing.Point(210, 115);
            this.pnlActivoGeneral.Name = "pnlActivoGeneral";
            this.pnlActivoGeneral.Size = new System.Drawing.Size(80, 8);
            this.pnlActivoGeneral.TabIndex = 20;
            this.pnlActivoGeneral.Visible = false;
            // 
            // btnGeneral
            // 
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.White;
            this.btnGeneral.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneral.Image")));
            this.btnGeneral.Location = new System.Drawing.Point(210, 12);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(80, 111);
            this.btnGeneral.TabIndex = 19;
            this.btnGeneral.Text = "Pendiente";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGeneral.UseVisualStyleBackColor = true;
            // 
            // panelEleccionContabilidad
            // 
            this.panelEleccionContabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEleccionContabilidad.Location = new System.Drawing.Point(12, 129);
            this.panelEleccionContabilidad.Name = "panelEleccionContabilidad";
            this.panelEleccionContabilidad.Size = new System.Drawing.Size(497, 227);
            this.panelEleccionContabilidad.TabIndex = 24;
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(729, 485);
            this.Controls.Add(this.panelEleccionContabilidad);
            this.Controls.Add(this.pnlActivoGeneral);
            this.Controls.Add(this.btnGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstadistica";
            this.Text = "FormEstadistica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActivoGeneral;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Panel panelEleccionContabilidad;
    }
}