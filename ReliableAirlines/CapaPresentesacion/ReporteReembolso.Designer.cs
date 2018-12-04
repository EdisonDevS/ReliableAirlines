namespace CapaPresentesacion
{
    partial class ReporteReembolso
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportReembolso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosReembolsoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosReembolsoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportReembolso
            // 
            this.ReportReembolso.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosReembolso";
            reportDataSource1.Value = this.DatosReembolsoBindingSource;
            this.ReportReembolso.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportReembolso.LocalReport.ReportEmbeddedResource = "CapaPresentesacion.InformeReembolso.rdlc";
            this.ReportReembolso.Location = new System.Drawing.Point(0, 0);
            this.ReportReembolso.Name = "ReportReembolso";
            this.ReportReembolso.ServerReport.BearerToken = null;
            this.ReportReembolso.Size = new System.Drawing.Size(910, 704);
            this.ReportReembolso.TabIndex = 0;
            this.ReportReembolso.Load += new System.EventHandler(this.ReportReembolso_Load);
            // 
            // DatosReembolsoBindingSource
            // 
            this.DatosReembolsoBindingSource.DataSource = typeof(CapaPresentesacion.DatosReembolso);
            // 
            // ReporteReembolso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 704);
            this.Controls.Add(this.ReportReembolso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteReembolso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteReembolso";
            this.Load += new System.EventHandler(this.ReporteReembolso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosReembolsoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportReembolso;
        private System.Windows.Forms.BindingSource DatosReembolsoBindingSource;
    }
}