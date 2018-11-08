namespace CapaPresentesacion
{
    partial class FormCajaVentasVenta
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
            this.btnGenerarGasto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbEstadoOrigen = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbPaisOrigen = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbbAerOrigen = new System.Windows.Forms.ComboBox();
            this.cbbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.cbbAerDes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCiuDes = new System.Windows.Forms.ComboBox();
            this.l = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbEstDes = new System.Windows.Forms.ComboBox();
            this.cbbPaisDes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarGasto
            // 
            this.btnGenerarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnGenerarGasto.FlatAppearance.BorderSize = 0;
            this.btnGenerarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarGasto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGasto.ForeColor = System.Drawing.Color.White;
            this.btnGenerarGasto.Location = new System.Drawing.Point(394, 198);
            this.btnGenerarGasto.Name = "btnGenerarGasto";
            this.btnGenerarGasto.Size = new System.Drawing.Size(98, 26);
            this.btnGenerarGasto.TabIndex = 101;
            this.btnGenerarGasto.Text = "Validar reserva";
            this.btnGenerarGasto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nombres:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(16, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 1);
            this.panel1.TabIndex = 97;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 33);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 105;
            this.label4.Text = "Fecha de salida:";
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(383, 75);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(109, 23);
            this.btnVer.TabIndex = 106;
            this.btnVer.Text = "Ver vuelos disponibles";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Location = new System.Drawing.Point(16, 101);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.Size = new System.Drawing.Size(476, 69);
            this.dgvVuelos.TabIndex = 107;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.textBox3.Location = new System.Drawing.Point(70, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 33);
            this.textBox3.TabIndex = 108;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.textBox4.Location = new System.Drawing.Point(376, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 33);
            this.textBox4.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(313, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Apellidos:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.textBox5.Location = new System.Drawing.Point(123, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 33);
            this.textBox5.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 111;
            this.label6.Text = "Identificaión:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "C.C",
            "T.I",
            "C.E"});
            this.comboBox1.Location = new System.Drawing.Point(82, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 32);
            this.comboBox1.TabIndex = 113;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 24);
            this.label17.TabIndex = 122;
            this.label17.Text = "Estado de origen:";
            // 
            // cbbEstadoOrigen
            // 
            this.cbbEstadoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstadoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbEstadoOrigen.FormattingEnabled = true;
            this.cbbEstadoOrigen.Location = new System.Drawing.Point(129, 24);
            this.cbbEstadoOrigen.Name = "cbbEstadoOrigen";
            this.cbbEstadoOrigen.Size = new System.Drawing.Size(116, 30);
            this.cbbEstadoOrigen.TabIndex = 123;
            this.cbbEstadoOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoOrigen_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 24);
            this.label18.TabIndex = 120;
            this.label18.Text = "Pais de origen:";
            // 
            // cbbPaisOrigen
            // 
            this.cbbPaisOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbPaisOrigen.FormattingEnabled = true;
            this.cbbPaisOrigen.Location = new System.Drawing.Point(129, 8);
            this.cbbPaisOrigen.Name = "cbbPaisOrigen";
            this.cbbPaisOrigen.Size = new System.Drawing.Size(116, 30);
            this.cbbPaisOrigen.TabIndex = 121;
            this.cbbPaisOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbPaisOrigen_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(12, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(236, 24);
            this.label19.TabIndex = 117;
            this.label19.Text = "Aeropuerto de origen:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(12, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(194, 24);
            this.label20.TabIndex = 116;
            this.label20.Text = "Ciudad de origen:";
            // 
            // cbbAerOrigen
            // 
            this.cbbAerOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbAerOrigen.FormattingEnabled = true;
            this.cbbAerOrigen.Location = new System.Drawing.Point(129, 56);
            this.cbbAerOrigen.Name = "cbbAerOrigen";
            this.cbbAerOrigen.Size = new System.Drawing.Size(116, 30);
            this.cbbAerOrigen.TabIndex = 118;
            // 
            // cbbCiudadOrigen
            // 
            this.cbbCiudadOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudadOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudadOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbCiudadOrigen.FormattingEnabled = true;
            this.cbbCiudadOrigen.Location = new System.Drawing.Point(129, 40);
            this.cbbCiudadOrigen.Name = "cbbCiudadOrigen";
            this.cbbCiudadOrigen.Size = new System.Drawing.Size(116, 30);
            this.cbbCiudadOrigen.TabIndex = 119;
            this.cbbCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbCiudadOrigen_SelectedIndexChanged);
            // 
            // cbbAerDes
            // 
            this.cbbAerDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbAerDes.FormattingEnabled = true;
            this.cbbAerDes.Location = new System.Drawing.Point(381, 56);
            this.cbbAerDes.Name = "cbbAerDes";
            this.cbbAerDes.Size = new System.Drawing.Size(116, 30);
            this.cbbAerDes.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 124;
            this.label1.Text = "Ciudad de destino:";
            // 
            // cbbCiuDes
            // 
            this.cbbCiuDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiuDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiuDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbCiuDes.FormattingEnabled = true;
            this.cbbCiuDes.Location = new System.Drawing.Point(381, 40);
            this.cbbCiuDes.Name = "cbbCiuDes";
            this.cbbCiuDes.Size = new System.Drawing.Size(116, 30);
            this.cbbCiuDes.TabIndex = 127;
            this.cbbCiuDes.SelectedIndexChanged += new System.EventHandler(this.cbbCiuDes_SelectedIndexChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.l.ForeColor = System.Drawing.Color.White;
            this.l.Location = new System.Drawing.Point(264, 24);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(196, 24);
            this.l.TabIndex = 130;
            this.l.Text = "Estado de destino:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(264, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 24);
            this.label7.TabIndex = 128;
            this.label7.Text = "Pais de destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(264, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 24);
            this.label8.TabIndex = 125;
            this.label8.Text = "Aeropuerto de destino:";
            // 
            // cbbEstDes
            // 
            this.cbbEstDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbEstDes.FormattingEnabled = true;
            this.cbbEstDes.Location = new System.Drawing.Point(381, 24);
            this.cbbEstDes.Name = "cbbEstDes";
            this.cbbEstDes.Size = new System.Drawing.Size(116, 30);
            this.cbbEstDes.TabIndex = 131;
            this.cbbEstDes.SelectedIndexChanged += new System.EventHandler(this.cbbEstDes_SelectedIndexChanged);
            // 
            // cbbPaisDes
            // 
            this.cbbPaisDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbPaisDes.FormattingEnabled = true;
            this.cbbPaisDes.Location = new System.Drawing.Point(381, 8);
            this.cbbPaisDes.Name = "cbbPaisDes";
            this.cbbPaisDes.Size = new System.Drawing.Size(116, 30);
            this.cbbPaisDes.TabIndex = 129;
            this.cbbPaisDes.SelectedIndexChanged += new System.EventHandler(this.cbbPaisDes_SelectedIndexChanged);
            // 
            // FormCajaVentasVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(538, 256);
            this.Controls.Add(this.cbbAerDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCiuDes);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbEstDes);
            this.Controls.Add(this.cbbPaisDes);
            this.Controls.Add(this.cbbAerOrigen);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbbCiudadOrigen);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbbEstadoOrigen);
            this.Controls.Add(this.cbbPaisOrigen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dgvVuelos);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGenerarGasto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCajaVentasVenta";
            this.Text = "FormCajaVentasVenta";
            this.Load += new System.EventHandler(this.FormCajaVentasVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarGasto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbEstadoOrigen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbbPaisOrigen;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbAerOrigen;
        private System.Windows.Forms.ComboBox cbbCiudadOrigen;
        private System.Windows.Forms.ComboBox cbbAerDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCiuDes;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbEstDes;
        private System.Windows.Forms.ComboBox cbbPaisDes;
    }
}