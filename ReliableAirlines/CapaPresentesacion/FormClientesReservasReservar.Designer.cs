namespace CapaPresentesacion
{
    partial class FormClientesReservasReservar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbCturista = new System.Windows.Forms.RadioButton();
            this.rbPclase = new System.Windows.Forms.RadioButton();
            this.cbbAerDes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCiuDes = new System.Windows.Forms.ComboBox();
            this.l = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbEstDes = new System.Windows.Forms.ComboBox();
            this.cbbPaisDes = new System.Windows.Forms.ComboBox();
            this.cbbAerOrigen = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbEstadoOrigen = new System.Windows.Forms.ComboBox();
            this.cbbPaisOrigen = new System.Windows.Forms.ComboBox();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCturista
            // 
            this.rbCturista.AutoSize = true;
            this.rbCturista.Checked = true;
            this.rbCturista.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.rbCturista.ForeColor = System.Drawing.Color.White;
            this.rbCturista.Location = new System.Drawing.Point(553, 286);
            this.rbCturista.Name = "rbCturista";
            this.rbCturista.Size = new System.Drawing.Size(195, 37);
            this.rbCturista.TabIndex = 165;
            this.rbCturista.TabStop = true;
            this.rbCturista.Text = "Clase turista";
            this.rbCturista.UseVisualStyleBackColor = true;
            // 
            // rbPclase
            // 
            this.rbPclase.AutoSize = true;
            this.rbPclase.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.rbPclase.ForeColor = System.Drawing.Color.White;
            this.rbPclase.Location = new System.Drawing.Point(428, 286);
            this.rbPclase.Name = "rbPclase";
            this.rbPclase.Size = new System.Drawing.Size(212, 37);
            this.rbPclase.TabIndex = 164;
            this.rbPclase.Text = "Primera clase";
            this.rbPclase.UseVisualStyleBackColor = true;
            // 
            // cbbAerDes
            // 
            this.cbbAerDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbAerDes.FormattingEnabled = true;
            this.cbbAerDes.Location = new System.Drawing.Point(500, 86);
            this.cbbAerDes.Margin = new System.Windows.Forms.Padding(4);
            this.cbbAerDes.Name = "cbbAerDes";
            this.cbbAerDes.Size = new System.Drawing.Size(153, 38);
            this.cbbAerDes.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 153;
            this.label1.Text = "Ciudad de destino:";
            // 
            // cbbCiuDes
            // 
            this.cbbCiuDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiuDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiuDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbCiuDes.FormattingEnabled = true;
            this.cbbCiuDes.Location = new System.Drawing.Point(500, 66);
            this.cbbCiuDes.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCiuDes.Name = "cbbCiuDes";
            this.cbbCiuDes.Size = new System.Drawing.Size(153, 38);
            this.cbbCiuDes.TabIndex = 156;
            this.cbbCiuDes.SelectedIndexChanged += new System.EventHandler(this.cbbCiuDes_SelectedIndexChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.l.ForeColor = System.Drawing.Color.White;
            this.l.Location = new System.Drawing.Point(344, 47);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(259, 33);
            this.l.TabIndex = 159;
            this.l.Text = "Estado de destino:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(344, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 33);
            this.label7.TabIndex = 157;
            this.label7.Text = "Pais de destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(344, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 33);
            this.label8.TabIndex = 154;
            this.label8.Text = "Aeropuerto de destino:";
            // 
            // cbbEstDes
            // 
            this.cbbEstDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbEstDes.FormattingEnabled = true;
            this.cbbEstDes.Location = new System.Drawing.Point(500, 47);
            this.cbbEstDes.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstDes.Name = "cbbEstDes";
            this.cbbEstDes.Size = new System.Drawing.Size(153, 38);
            this.cbbEstDes.TabIndex = 160;
            this.cbbEstDes.SelectedIndexChanged += new System.EventHandler(this.cbbEstDes_SelectedIndexChanged);
            // 
            // cbbPaisDes
            // 
            this.cbbPaisDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisDes.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbPaisDes.FormattingEnabled = true;
            this.cbbPaisDes.Location = new System.Drawing.Point(500, 27);
            this.cbbPaisDes.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPaisDes.Name = "cbbPaisDes";
            this.cbbPaisDes.Size = new System.Drawing.Size(153, 38);
            this.cbbPaisDes.TabIndex = 158;
            this.cbbPaisDes.SelectedIndexChanged += new System.EventHandler(this.cbbPaisDes_SelectedIndexChanged);
            // 
            // cbbAerOrigen
            // 
            this.cbbAerOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbAerOrigen.FormattingEnabled = true;
            this.cbbAerOrigen.Location = new System.Drawing.Point(164, 86);
            this.cbbAerOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbAerOrigen.Name = "cbbAerOrigen";
            this.cbbAerOrigen.Size = new System.Drawing.Size(153, 38);
            this.cbbAerOrigen.TabIndex = 147;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(8, 67);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(257, 33);
            this.label20.TabIndex = 145;
            this.label20.Text = "Ciudad de origen:";
            // 
            // cbbCiudadOrigen
            // 
            this.cbbCiudadOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudadOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudadOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbCiudadOrigen.FormattingEnabled = true;
            this.cbbCiudadOrigen.Location = new System.Drawing.Point(164, 66);
            this.cbbCiudadOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCiudadOrigen.Name = "cbbCiudadOrigen";
            this.cbbCiudadOrigen.Size = new System.Drawing.Size(153, 38);
            this.cbbCiudadOrigen.TabIndex = 148;
            this.cbbCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbCiudadOrigen_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 47);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(246, 33);
            this.label17.TabIndex = 151;
            this.label17.Text = "Estado de origen:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(8, 28);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 33);
            this.label18.TabIndex = 149;
            this.label18.Text = "Pais de origen:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(8, 87);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(308, 33);
            this.label19.TabIndex = 146;
            this.label19.Text = "Aeropuerto de origen:";
            // 
            // cbbEstadoOrigen
            // 
            this.cbbEstadoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstadoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbEstadoOrigen.FormattingEnabled = true;
            this.cbbEstadoOrigen.Location = new System.Drawing.Point(164, 47);
            this.cbbEstadoOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstadoOrigen.Name = "cbbEstadoOrigen";
            this.cbbEstadoOrigen.Size = new System.Drawing.Size(153, 38);
            this.cbbEstadoOrigen.TabIndex = 152;
            this.cbbEstadoOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoOrigen_SelectedIndexChanged);
            // 
            // cbbPaisOrigen
            // 
            this.cbbPaisOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbPaisOrigen.FormattingEnabled = true;
            this.cbbPaisOrigen.Location = new System.Drawing.Point(164, 27);
            this.cbbPaisOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPaisOrigen.Name = "cbbPaisOrigen";
            this.cbbPaisOrigen.Size = new System.Drawing.Size(153, 38);
            this.cbbPaisOrigen.TabIndex = 150;
            this.cbbPaisOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbPaisOrigen_SelectedIndexChanged);
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.AllowUserToAddRows = false;
            this.dgvVuelos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.dgvVuelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvVuelos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVuelos.DefaultCellStyle = dataGridViewCellStyle43;
            this.dgvVuelos.Location = new System.Drawing.Point(13, 145);
            this.dgvVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVuelos.Name = "dgvVuelos";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvVuelos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVuelos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVuelos.Size = new System.Drawing.Size(635, 136);
            this.dgvVuelos.TabIndex = 142;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(503, 109);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(145, 28);
            this.btnVer.TabIndex = 141;
            this.btnVer.Text = "Ver vuelos disponibles";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 33);
            this.label4.TabIndex = 140;
            this.label4.Text = "Fecha de salida:";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(125, 112);
            this.dtpSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(151, 40);
            this.dtpSalida.TabIndex = 139;
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnGenerarVenta.FlatAppearance.BorderSize = 0;
            this.btnGenerarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.White;
            this.btnGenerarVenta.Location = new System.Drawing.Point(517, 312);
            this.btnGenerarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(131, 32);
            this.btnGenerarVenta.TabIndex = 138;
            this.btnGenerarVenta.Text = "Reservar";
            this.btnGenerarVenta.UseVisualStyleBackColor = false;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(13, 284);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 1);
            this.panel1.TabIndex = 137;
            // 
            // FormClientesReservasReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(689, 407);
            this.Controls.Add(this.rbCturista);
            this.Controls.Add(this.rbPclase);
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
            this.Controls.Add(this.dgvVuelos);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormClientesReservasReservar";
            this.Text = "FormClientesReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCturista;
        private System.Windows.Forms.RadioButton rbPclase;
        private System.Windows.Forms.ComboBox cbbAerDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCiuDes;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbEstDes;
        private System.Windows.Forms.ComboBox cbbPaisDes;
        private System.Windows.Forms.ComboBox cbbAerOrigen;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbCiudadOrigen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbbEstadoOrigen;
        private System.Windows.Forms.ComboBox cbbPaisOrigen;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Button btnGenerarVenta;
        private System.Windows.Forms.Panel panel1;
    }
}