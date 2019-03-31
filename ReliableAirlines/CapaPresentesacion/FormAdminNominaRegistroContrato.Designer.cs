namespace CapaPresentesacion
{
    partial class FormAdminNominaRegistroContrato
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbbBanco = new System.Windows.Forms.ComboBox();
            this.cbbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearContrato = new System.Windows.Forms.Button();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(13, 9);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(391, 37);
            this.lblInfo.TabIndex = 44;
            this.lblInfo.Text = "Información de contrato: ";
            // 
            // cbbBanco
            // 
            this.cbbBanco.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBanco.FormattingEnabled = true;
            this.cbbBanco.Items.AddRange(new object[] {
            "Bancolombia",
            "Davivienda",
            "Banco de Bogotá"});
            this.cbbBanco.Location = new System.Drawing.Point(774, 196);
            this.cbbBanco.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBanco.Name = "cbbBanco";
            this.cbbBanco.Size = new System.Drawing.Size(276, 45);
            this.cbbBanco.TabIndex = 70;
            // 
            // cbbTipoCuenta
            // 
            this.cbbTipoCuenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoCuenta.FormattingEnabled = true;
            this.cbbTipoCuenta.Items.AddRange(new object[] {
            "Ahorros",
            "Corriente"});
            this.cbbTipoCuenta.Location = new System.Drawing.Point(873, 128);
            this.cbbTipoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTipoCuenta.Name = "cbbTipoCuenta";
            this.cbbTipoCuenta.Size = new System.Drawing.Size(177, 45);
            this.cbbTipoCuenta.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(673, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 37);
            this.label10.TabIndex = 68;
            this.label10.Text = "Banco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(673, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 37);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tipo de cuenta:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.Location = new System.Drawing.Point(854, 56);
            this.txtCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(196, 44);
            this.txtCuenta.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(673, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 37);
            this.label8.TabIndex = 65;
            this.label8.Text = "N° de cuenta:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(118, 192);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(203, 44);
            this.txtSueldo.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 37);
            this.label7.TabIndex = 63;
            this.label7.Text = "Sueldo:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(115, 130);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(206, 44);
            this.txtPuesto.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 37);
            this.label6.TabIndex = 61;
            this.label6.Text = "Puesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 37);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tipo de contrato:";
            // 
            // btnCrearContrato
            // 
            this.btnCrearContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearContrato.FlatAppearance.BorderSize = 0;
            this.btnCrearContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearContrato.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearContrato.ForeColor = System.Drawing.Color.White;
            this.btnCrearContrato.Location = new System.Drawing.Point(913, 309);
            this.btnCrearContrato.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearContrato.Name = "btnCrearContrato";
            this.btnCrearContrato.Size = new System.Drawing.Size(151, 64);
            this.btnCrearContrato.TabIndex = 75;
            this.btnCrearContrato.Text = "Crear contrato";
            this.btnCrearContrato.UseVisualStyleBackColor = false;
            this.btnCrearContrato.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpFinal
            // 
            this.dtpFinal.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpFinal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(103, 300);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(174, 44);
            this.dtpFinal.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 37);
            this.label3.TabIndex = 78;
            this.label3.Text = "Fin:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpInicio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(103, 252);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(174, 44);
            this.dtpInicio.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 37);
            this.label4.TabIndex = 76;
            this.label4.Text = "Inicio:";
            // 
            // cbbTipo
            // 
            this.cbbTipo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "Planta",
            "Transitorio",
            "Pasante"});
            this.cbbTipo.Location = new System.Drawing.Point(229, 53);
            this.cbbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(207, 45);
            this.cbbTipo.TabIndex = 80;
            // 
            // FormAdminNominaRegistroContrato
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 386);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCrearContrato);
            this.Controls.Add(this.cbbBanco);
            this.Controls.Add(this.cbbTipoCuenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminNominaRegistroContrato";
            this.Text = "FormAdminNominaRegistroContacto";
            this.Load += new System.EventHandler(this.FormAdminNominaRegistroContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbbBanco;
        private System.Windows.Forms.ComboBox cbbTipoCuenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearContrato;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTipo;
    }
}