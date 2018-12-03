namespace CapaPresentesacion
{
    partial class FormReporteTiquetes
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
            this.ReporteTiquete = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReporteTiquete
            // 
            this.ReporteTiquete.AutoSize = true;
            this.ReporteTiquete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteTiquete.LocalReport.ReportEmbeddedResource = "CapaPresentesacion.ReporteTiquete.rdlc";
            this.ReporteTiquete.Location = new System.Drawing.Point(0, 0);
            this.ReporteTiquete.Name = "ReporteTiquete";
            this.ReporteTiquete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReporteTiquete.ServerReport.BearerToken = null;
            this.ReporteTiquete.Size = new System.Drawing.Size(910, 369);
            this.ReporteTiquete.TabIndex = 0;
            this.ReporteTiquete.Load += new System.EventHandler(this.ReporteTiquete_Load);
            // 
            // FormReporteTiquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 369);
            this.Controls.Add(this.ReporteTiquete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReporteTiquetes";
            this.Text = "ReporteTiquetes";
            this.Load += new System.EventHandler(this.ReporteTiquetes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteTiquete;
    }
}