namespace CapaPresentesacion
{
    partial class FormContabilidadGeneralEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // graGeneral
            // 
            chartArea1.Name = "ChartArea1";
            this.graGeneral.ChartAreas.Add(chartArea1);
            this.graGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.graGeneral.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.graGeneral.Legends.Add(legend1);
            this.graGeneral.Location = new System.Drawing.Point(0, 77);
            this.graGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.graGeneral.Name = "graGeneral";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graGeneral.Series.Add(series1);
            this.graGeneral.Size = new System.Drawing.Size(1252, 477);
            this.graGeneral.TabIndex = 0;
            this.graGeneral.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtAño.Location = new System.Drawing.Point(96, 6);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 41);
            this.txtAño.TabIndex = 2;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(213, 6);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(98, 41);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // FormContabilidadGeneralEstadistica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 554);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContabilidadGeneralEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContabilidadGeneralEstadistica";
            ((System.ComponentModel.ISupportInitialize)(this.graGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnVer;
    }
}