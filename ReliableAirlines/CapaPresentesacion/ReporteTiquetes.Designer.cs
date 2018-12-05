namespace CapaPresentesacion
{
    partial class ReporteTiquetes
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
            this.ReporteTiquete = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosTiqueteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTiqueteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteTiquete
            // 
            this.ReporteTiquete.AutoSize = true;
            this.ReporteTiquete.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosTiquete";
            reportDataSource1.Value = this.DatosTiqueteBindingSource;
            this.ReporteTiquete.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteTiquete.LocalReport.ReportEmbeddedResource = "CapaPresentesacion.InformeTiquete.rdlc";
            this.ReporteTiquete.Location = new System.Drawing.Point(0, 0);
            this.ReporteTiquete.Name = "ReporteTiquete";
            this.ReporteTiquete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReporteTiquete.ServerReport.BearerToken = null;
            this.ReporteTiquete.Size = new System.Drawing.Size(910, 369);
            this.ReporteTiquete.TabIndex = 0;
            this.ReporteTiquete.Load += new System.EventHandler(this.ReporteTiquete_Load);
            // 
            // DatosTiqueteBindingSource
            // 
            this.DatosTiqueteBindingSource.DataSource = typeof(CapaPresentesacion.DatosTiquete);
            // 
            // ReporteTiquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 369);
            this.Controls.Add(this.ReporteTiquete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteTiquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteTiquetes";
            this.Load += new System.EventHandler(this.ReporteTiquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTiqueteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteTiquete;
        private System.Windows.Forms.BindingSource DatosTiqueteBindingSource;
    }
}