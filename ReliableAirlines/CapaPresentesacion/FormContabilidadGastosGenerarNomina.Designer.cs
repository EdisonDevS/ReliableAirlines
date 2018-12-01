namespace CapaPresentesacion
{
    partial class FormContabilidadGastosGenerarNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPagoGeneral = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPagosPendientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNumeroContrato = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.btnCalcularPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagoGeneral
            // 
            this.btnPagoGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnPagoGeneral.FlatAppearance.BorderSize = 0;
            this.btnPagoGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoGeneral.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoGeneral.ForeColor = System.Drawing.Color.White;
            this.btnPagoGeneral.Location = new System.Drawing.Point(13, 13);
            this.btnPagoGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoGeneral.Name = "btnPagoGeneral";
            this.btnPagoGeneral.Size = new System.Drawing.Size(1280, 67);
            this.btnPagoGeneral.TabIndex = 25;
            this.btnPagoGeneral.Text = "Generar pago general";
            this.btnPagoGeneral.UseVisualStyleBackColor = false;
            this.btnPagoGeneral.Click += new System.EventHandler(this.btnPagoGeneral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pagos pendientes:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(13, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 1);
            this.panel1.TabIndex = 42;
            // 
            // dgvPagosPendientes
            // 
            this.dgvPagosPendientes.AllowUserToAddRows = false;
            this.dgvPagosPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPagosPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagosPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagosPendientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagosPendientes.Location = new System.Drawing.Point(13, 167);
            this.dgvPagosPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPagosPendientes.Name = "dgvPagosPendientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagosPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagosPendientes.Size = new System.Drawing.Size(1280, 207);
            this.dgvPagosPendientes.TabIndex = 83;
            this.dgvPagosPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagosPendientes_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 33);
            this.label2.TabIndex = 84;
            this.label2.Text = "Información de pago:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(7, 447);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(147, 33);
            this.lblNombre.TabIndex = 85;
            this.lblNombre.Text = "Nombres: ";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(7, 517);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(149, 33);
            this.lblApellidos.TabIndex = 86;
            this.lblApellidos.Text = "Apellidos: ";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(7, 582);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(188, 33);
            this.lblDocumento.TabIndex = 87;
            this.lblDocumento.Text = "Documento: ";
            // 
            // lblNumeroContrato
            // 
            this.lblNumeroContrato.AutoSize = true;
            this.lblNumeroContrato.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroContrato.ForeColor = System.Drawing.Color.White;
            this.lblNumeroContrato.Location = new System.Drawing.Point(7, 645);
            this.lblNumeroContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroContrato.Name = "lblNumeroContrato";
            this.lblNumeroContrato.Size = new System.Drawing.Size(301, 33);
            this.lblNumeroContrato.TabIndex = 88;
            this.lblNumeroContrato.Text = "Número de contrato: ";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.ForeColor = System.Drawing.Color.White;
            this.lblSueldo.Location = new System.Drawing.Point(7, 704);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(193, 33);
            this.lblSueldo.TabIndex = 89;
            this.lblSueldo.Text = "Sueldo/Hora: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(684, 447);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 33);
            this.label8.TabIndex = 90;
            this.label8.Text = "Días laborados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(684, 517);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 33);
            this.label9.TabIndex = 91;
            this.label9.Text = "Horas Extra:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(684, 582);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(204, 33);
            this.lblTotal.TabIndex = 92;
            this.lblTotal.Text = "Total a pagar: ";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtHora.Location = new System.Drawing.Point(908, 511);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(82, 40);
            this.txtHora.TabIndex = 95;
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtDias.Location = new System.Drawing.Point(908, 444);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(82, 40);
            this.txtDias.TabIndex = 96;
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.BackColor = System.Drawing.Color.Maroon;
            this.btnConfirmarPago.FlatAppearance.BorderSize = 0;
            this.btnConfirmarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPago.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPago.Location = new System.Drawing.Point(690, 670);
            this.btnConfirmarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(290, 67);
            this.btnConfirmarPago.TabIndex = 97;
            this.btnConfirmarPago.Text = "Confirmar pago";
            this.btnConfirmarPago.UseVisualStyleBackColor = false;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // btnCalcularPago
            // 
            this.btnCalcularPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCalcularPago.FlatAppearance.BorderSize = 0;
            this.btnCalcularPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPago.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPago.ForeColor = System.Drawing.Color.White;
            this.btnCalcularPago.Location = new System.Drawing.Point(1020, 465);
            this.btnCalcularPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularPago.Name = "btnCalcularPago";
            this.btnCalcularPago.Size = new System.Drawing.Size(249, 67);
            this.btnCalcularPago.TabIndex = 98;
            this.btnCalcularPago.Text = "Calcular pago";
            this.btnCalcularPago.UseVisualStyleBackColor = false;
            this.btnCalcularPago.Click += new System.EventHandler(this.btnCalcularPago_Click);
            // 
            // FormContabilidadGastosGenerarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 806);
            this.Controls.Add(this.btnCalcularPago);
            this.Controls.Add(this.btnConfirmarPago);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNumeroContrato);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPagosPendientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagoGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContabilidadGastosGenerarNomina";
            this.Text = "FormContabilidadGastosGenerarNomina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPagoGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPagosPendientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNumeroContrato;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnConfirmarPago;
        private System.Windows.Forms.Button btnCalcularPago;
    }
}