namespace CapaPresentesacion
{
    partial class FormEstadisticaCiudadGrafica
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
            this.btnVer = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graCiudades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbCiudades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.graCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(403, 5);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(98, 41);
            this.btnVer.TabIndex = 53;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtAño.Location = new System.Drawing.Point(96, 5);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 41);
            this.txtAño.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 51;
            this.label1.Text = "Año:";
            // 
            // graCiudades
            // 
            chartArea1.Name = "ChartArea1";
            this.graCiudades.ChartAreas.Add(chartArea1);
            this.graCiudades.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.graCiudades.Legends.Add(legend1);
            this.graCiudades.Location = new System.Drawing.Point(0, 77);
            this.graCiudades.Margin = new System.Windows.Forms.Padding(4);
            this.graCiudades.Name = "graCiudades";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graCiudades.Series.Add(series1);
            this.graCiudades.Size = new System.Drawing.Size(1252, 477);
            this.graCiudades.TabIndex = 50;
            this.graCiudades.Text = "chart1";
            // 
            // cbbCiudades
            // 
            this.cbbCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudades.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.cbbCiudades.FormattingEnabled = true;
            this.cbbCiudades.Location = new System.Drawing.Point(203, 5);
            this.cbbCiudades.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCiudades.Name = "cbbCiudades";
            this.cbbCiudades.Size = new System.Drawing.Size(193, 41);
            this.cbbCiudades.TabIndex = 54;
            // 
            // FormEstadisticaCiudadGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 554);
            this.Controls.Add(this.cbbCiudades);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graCiudades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEstadisticaCiudadGrafica";
            this.Text = "FormEstadisticaCiudadGrafica";
            ((System.ComponentModel.ISupportInitialize)(this.graCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graCiudades;
        private System.Windows.Forms.ComboBox cbbCiudades;
    }
}