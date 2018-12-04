namespace CapaPresentesacion
{
    partial class ReportePagoNomina
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
            this.ReporteNomina = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReporteNomina
            // 
            this.ReporteNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteNomina.LocalReport.ReportEmbeddedResource = "CapaPresentesacion.InformePagoNomina.rdlc";
            this.ReporteNomina.Location = new System.Drawing.Point(0, 0);
            this.ReporteNomina.Name = "ReporteNomina";
            this.ReporteNomina.ServerReport.BearerToken = null;
            this.ReporteNomina.Size = new System.Drawing.Size(910, 704);
            this.ReporteNomina.TabIndex = 0;
            this.ReporteNomina.Load += new System.EventHandler(this.ReporteNomina_Load);
            // 
            // ReportePagoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 704);
            this.Controls.Add(this.ReporteNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportePagoNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePagoNomina";
            this.Load += new System.EventHandler(this.ReportePagoNomina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteNomina;
    }
}