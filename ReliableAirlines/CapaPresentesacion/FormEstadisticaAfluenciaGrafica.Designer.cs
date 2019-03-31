namespace CapaPresentesacion
{
    partial class FormEstadisticaAfluenciaGrafica
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
            this.graAfluencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNombreRuta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.graAfluencia)).BeginInit();
            this.SuspendLayout();
            // 
            // graAfluencia
            // 
            chartArea1.Name = "ChartArea1";
            this.graAfluencia.ChartAreas.Add(chartArea1);
            this.graAfluencia.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.graAfluencia.Legends.Add(legend1);
            this.graAfluencia.Location = new System.Drawing.Point(0, 77);
            this.graAfluencia.Margin = new System.Windows.Forms.Padding(4);
            this.graAfluencia.Name = "graAfluencia";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graAfluencia.Series.Add(series1);
            this.graAfluencia.Size = new System.Drawing.Size(1252, 477);
            this.graAfluencia.TabIndex = 0;
            this.graAfluencia.Text = "chart1";
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(403, 6);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(98, 41);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtAño.Location = new System.Drawing.Point(96, 6);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 41);
            this.txtAño.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año:";
            // 
            // cbbNombreRuta
            // 
            this.cbbNombreRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbNombreRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNombreRuta.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.cbbNombreRuta.FormattingEnabled = true;
            this.cbbNombreRuta.Location = new System.Drawing.Point(203, 6);
            this.cbbNombreRuta.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNombreRuta.Name = "cbbNombreRuta";
            this.cbbNombreRuta.Size = new System.Drawing.Size(193, 41);
            this.cbbNombreRuta.TabIndex = 49;
            // 
            // FormEstadisticaAfluenciaGrafica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 554);
            this.Controls.Add(this.cbbNombreRuta);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graAfluencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstadisticaAfluenciaGrafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEstadisticaAfluenciaGrafica";
            ((System.ComponentModel.ISupportInitialize)(this.graAfluencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graAfluencia;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNombreRuta;
    }
}