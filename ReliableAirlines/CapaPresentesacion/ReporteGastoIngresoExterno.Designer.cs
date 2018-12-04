namespace CapaPresentesacion
{
    partial class ReporteGastoIngresoExterno
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
            this.ReporteGastoIgreso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReporteGastoIgreso
            // 
            this.ReporteGastoIgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteGastoIgreso.LocalReport.ReportEmbeddedResource = "CapaPresentesacion.InformeGastoIngresoExterno.rdlc";
            this.ReporteGastoIgreso.Location = new System.Drawing.Point(0, 0);
            this.ReporteGastoIgreso.Name = "ReporteGastoIgreso";
            this.ReporteGastoIgreso.ServerReport.BearerToken = null;
            this.ReporteGastoIgreso.Size = new System.Drawing.Size(910, 704);
            this.ReporteGastoIgreso.TabIndex = 0;
            this.ReporteGastoIgreso.Load += new System.EventHandler(this.ReporteGastoIgreso_Load);
            // 
            // ReporteGastoIngresoExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 704);
            this.Controls.Add(this.ReporteGastoIgreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteGastoIngresoExterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteGastoIngresoExterno";
            this.Load += new System.EventHandler(this.ReporteGastoIngresoExterno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteGastoIgreso;
    }
}