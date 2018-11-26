namespace CapaPresentesacion
{
    partial class FormContabilidadGastosIngresosGenerarOtros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorGasto = new System.Windows.Forms.TextBox();
            this.dtpFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFuente = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtDescripcionGasto = new System.Windows.Forms.RichTextBox();
            this.cbbReceptor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "Valor:";
            // 
            // txtValorGasto
            // 
            this.txtValorGasto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtValorGasto.Location = new System.Drawing.Point(132, 361);
            this.txtValorGasto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorGasto.Name = "txtValorGasto";
            this.txtValorGasto.Size = new System.Drawing.Size(267, 40);
            this.txtValorGasto.TabIndex = 49;
            // 
            // dtpFechaGasto
            // 
            this.dtpFechaGasto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpFechaGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGasto.Location = new System.Drawing.Point(132, 446);
            this.dtpFechaGasto.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaGasto.Name = "dtpFechaGasto";
            this.dtpFechaGasto.Size = new System.Drawing.Size(201, 40);
            this.dtpFechaGasto.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha:";
            // 
            // lblFuente
            // 
            this.lblFuente.AutoSize = true;
            this.lblFuente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuente.ForeColor = System.Drawing.Color.White;
            this.lblFuente.Location = new System.Drawing.Point(16, 546);
            this.lblFuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuente.Name = "lblFuente";
            this.lblFuente.Size = new System.Drawing.Size(142, 32);
            this.lblFuente.TabIndex = 52;
            this.lblFuente.Text = "Receptor:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(1129, 724);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(167, 68);
            this.btnGenerar.TabIndex = 54;
            this.btnGenerar.Text = "Generar gasto";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerarGasto_Click);
            // 
            // txtDescripcionGasto
            // 
            this.txtDescripcionGasto.Location = new System.Drawing.Point(22, 46);
            this.txtDescripcionGasto.Name = "txtDescripcionGasto";
            this.txtDescripcionGasto.Size = new System.Drawing.Size(1084, 283);
            this.txtDescripcionGasto.TabIndex = 55;
            this.txtDescripcionGasto.Text = "";
            // 
            // cbbReceptor
            // 
            this.cbbReceptor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbReceptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbReceptor.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbReceptor.FormattingEnabled = true;
            this.cbbReceptor.Location = new System.Drawing.Point(166, 543);
            this.cbbReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.cbbReceptor.Name = "cbbReceptor";
            this.cbbReceptor.Size = new System.Drawing.Size(940, 38);
            this.cbbReceptor.TabIndex = 156;
            // 
            // FormContabilidadGastosIngresosGenerarOtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 806);
            this.Controls.Add(this.cbbReceptor);
            this.Controls.Add(this.txtDescripcionGasto);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblFuente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaGasto);
            this.Controls.Add(this.txtValorGasto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContabilidadGastosIngresosGenerarOtros";
            this.Text = "FormContabilidadGastosGenerarOtros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaGasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFuente;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox txtDescripcionGasto;
        private System.Windows.Forms.ComboBox cbbReceptor;
    }
}