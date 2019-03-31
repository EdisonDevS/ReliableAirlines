namespace CapaPresentesacion
{
    partial class FormEstadisticaAfluencia
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
            this.btnGraficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnGraficar.FlatAppearance.BorderSize = 0;
            this.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficar.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.ForeColor = System.Drawing.Color.White;
            this.btnGraficar.Location = new System.Drawing.Point(13, 13);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(1051, 414);
            this.btnGraficar.TabIndex = 74;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEstadisticaAfluencia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 440);
            this.Controls.Add(this.btnGraficar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstadisticaAfluencia";
            this.Text = "FormEstadisticaAfluencia";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGraficar;
    }
}