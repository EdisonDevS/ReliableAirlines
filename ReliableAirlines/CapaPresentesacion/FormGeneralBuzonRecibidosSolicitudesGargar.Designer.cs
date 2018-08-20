namespace CapaPresentesacion
{
    partial class FormGeneralBuzonRecibidosSolicitudesGargar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerSeleccionado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVerSeleccionado
            // 
            this.btnVerSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVerSeleccionado.FlatAppearance.BorderSize = 0;
            this.btnVerSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSeleccionado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSeleccionado.ForeColor = System.Drawing.Color.White;
            this.btnVerSeleccionado.Location = new System.Drawing.Point(774, 295);
            this.btnVerSeleccionado.Name = "btnVerSeleccionado";
            this.btnVerSeleccionado.Size = new System.Drawing.Size(158, 56);
            this.btnVerSeleccionado.TabIndex = 31;
            this.btnVerSeleccionado.Text = "Ver Seleccionado";
            this.btnVerSeleccionado.UseVisualStyleBackColor = false;
            this.btnVerSeleccionado.Click += new System.EventHandler(this.btnVerSeleccionado_Click);
            // 
            // FormGeneralBuzonRecibidosSolicitudesGargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(944, 363);
            this.Controls.Add(this.btnVerSeleccionado);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGeneralBuzonRecibidosSolicitudesGargar";
            this.Text = "FormGeneralBuzonRecibidosSolicitudesGargar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerSeleccionado;
    }
}