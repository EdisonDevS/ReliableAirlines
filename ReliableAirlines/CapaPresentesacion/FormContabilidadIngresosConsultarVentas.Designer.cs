namespace CapaPresentesacion
{
    partial class FormContabilidadIngresosConsultarVentas
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.dtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIdentificación = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 47;
            this.label2.Text = "Desde:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(132, 26);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(201, 40);
            this.dtpInicio.TabIndex = 48;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpFinal.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(132, 74);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(201, 40);
            this.dtpFinal.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hasta:";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(24, 126);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(159, 58);
            this.btnCargar.TabIndex = 52;
            this.btnCargar.Text = "Gargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.Location = new System.Drawing.Point(22, 192);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.Name = "dgvVentas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.Size = new System.Drawing.Size(1274, 253);
            this.dgvVentas.TabIndex = 82;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(452, 629);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(98, 33);
            this.lblValor.TabIndex = 170;
            this.lblValor.Text = "Valor: ";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.ForeColor = System.Drawing.Color.White;
            this.lblClase.Location = new System.Drawing.Point(18, 629);
            this.lblClase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(103, 33);
            this.lblClase.TabIndex = 169;
            this.lblClase.Text = "Clase: ";
            // 
            // dtpHoraLlegada
            // 
            this.dtpHoraLlegada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraLlegada.Location = new System.Drawing.Point(306, 733);
            this.dtpHoraLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraLlegada.Name = "dtpHoraLlegada";
            this.dtpHoraLlegada.Size = new System.Drawing.Size(83, 32);
            this.dtpHoraLlegada.TabIndex = 168;
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLlegada.Location = new System.Drawing.Point(154, 733);
            this.dtpLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(144, 32);
            this.dtpLlegada.TabIndex = 167;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 730);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 32);
            this.label8.TabIndex = 166;
            this.label8.Text = "Llegada:";
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(306, 698);
            this.dtpHoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(83, 32);
            this.dtpHoraSalida.TabIndex = 165;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(154, 698);
            this.dtpSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(144, 32);
            this.dtpSalida.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 508);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 33);
            this.label4.TabIndex = 157;
            this.label4.Text = "Información de la reserva:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 698);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 32);
            this.label9.TabIndex = 163;
            this.label9.Text = "Salida:";
            // 
            // lblIdentificación
            // 
            this.lblIdentificación.AutoSize = true;
            this.lblIdentificación.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificación.ForeColor = System.Drawing.Color.White;
            this.lblIdentificación.Location = new System.Drawing.Point(967, 563);
            this.lblIdentificación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificación.Name = "lblIdentificación";
            this.lblIdentificación.Size = new System.Drawing.Size(210, 33);
            this.lblIdentificación.TabIndex = 162;
            this.lblIdentificación.Text = "Identificación: ";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.White;
            this.lblDestino.Location = new System.Drawing.Point(452, 596);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(127, 33);
            this.lblDestino.TabIndex = 161;
            this.lblDestino.Text = "Destino: ";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(18, 563);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(147, 33);
            this.lblNombres.TabIndex = 158;
            this.lblNombres.Text = "Nombres: ";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(18, 596);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(118, 33);
            this.lblOrigen.TabIndex = 160;
            this.lblOrigen.Text = "Origen: ";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(452, 563);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(149, 33);
            this.lblApellidos.TabIndex = 159;
            this.lblApellidos.Text = "Apellidos: ";
            // 
            // FormContabilidadIngresosConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 806);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.dtpHoraLlegada);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblIdentificación);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContabilidadIngresosConsultarVentas";
            this.Text = "FormContabilidadIngresosConsultarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegada;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIdentificación;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblApellidos;
    }
}