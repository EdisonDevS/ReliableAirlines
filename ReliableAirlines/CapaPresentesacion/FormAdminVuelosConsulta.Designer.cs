namespace CapaPresentesacion
{
    partial class FormAdminVuelosConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumVuelo = new System.Windows.Forms.TextBox();
            this.rbRuta = new System.Windows.Forms.RadioButton();
            this.rbNumeroVuelo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbEstadoDestino = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbPaisDestino = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbbAerDestino = new System.Windows.Forms.ComboBox();
            this.cbbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbEstadoOrigen = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbPaisOrigen = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbbAerOrigen = new System.Windows.Forms.ComboBox();
            this.cbbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de vuelo:";
            // 
            // txtNumVuelo
            // 
            this.txtNumVuelo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNumVuelo.Location = new System.Drawing.Point(185, 43);
            this.txtNumVuelo.Name = "txtNumVuelo";
            this.txtNumVuelo.Size = new System.Drawing.Size(162, 31);
            this.txtNumVuelo.TabIndex = 2;
            // 
            // rbRuta
            // 
            this.rbRuta.AutoSize = true;
            this.rbRuta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbRuta.ForeColor = System.Drawing.Color.White;
            this.rbRuta.Location = new System.Drawing.Point(12, 85);
            this.rbRuta.Name = "rbRuta";
            this.rbRuta.Size = new System.Drawing.Size(89, 25);
            this.rbRuta.TabIndex = 60;
            this.rbRuta.TabStop = true;
            this.rbRuta.Text = "Por ruta";
            this.rbRuta.UseVisualStyleBackColor = true;
            this.rbRuta.CheckedChanged += new System.EventHandler(this.rbRuta_CheckedChanged);
            // 
            // rbNumeroVuelo
            // 
            this.rbNumeroVuelo.AutoSize = true;
            this.rbNumeroVuelo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbNumeroVuelo.ForeColor = System.Drawing.Color.White;
            this.rbNumeroVuelo.Location = new System.Drawing.Point(12, 18);
            this.rbNumeroVuelo.Name = "rbNumeroVuelo";
            this.rbNumeroVuelo.Size = new System.Drawing.Size(188, 25);
            this.rbNumeroVuelo.TabIndex = 61;
            this.rbNumeroVuelo.TabStop = true;
            this.rbNumeroVuelo.Text = "Por número de vuelo";
            this.rbNumeroVuelo.UseVisualStyleBackColor = true;
            this.rbNumeroVuelo.CheckedChanged += new System.EventHandler(this.rbNumeroVuelo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(12, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 1);
            this.panel2.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(884, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 22);
            this.label12.TabIndex = 76;
            this.label12.Text = "Estado de destino:";
            // 
            // cbbEstadoDestino
            // 
            this.cbbEstadoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstadoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoDestino.Enabled = false;
            this.cbbEstadoDestino.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbEstadoDestino.FormattingEnabled = true;
            this.cbbEstadoDestino.Location = new System.Drawing.Point(1075, 136);
            this.cbbEstadoDestino.Name = "cbbEstadoDestino";
            this.cbbEstadoDestino.Size = new System.Drawing.Size(222, 30);
            this.cbbEstadoDestino.TabIndex = 77;
            this.cbbEstadoDestino.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoDestino_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(884, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 22);
            this.label14.TabIndex = 74;
            this.label14.Text = "Pais de destino:";
            // 
            // cbbPaisDestino
            // 
            this.cbbPaisDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisDestino.Enabled = false;
            this.cbbPaisDestino.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbPaisDestino.FormattingEnabled = true;
            this.cbbPaisDestino.Location = new System.Drawing.Point(1075, 103);
            this.cbbPaisDestino.Name = "cbbPaisDestino";
            this.cbbPaisDestino.Size = new System.Drawing.Size(222, 30);
            this.cbbPaisDestino.TabIndex = 75;
            this.cbbPaisDestino.SelectedIndexChanged += new System.EventHandler(this.cbbPaisDestino_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(884, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(223, 22);
            this.label15.TabIndex = 71;
            this.label15.Text = "Aeropuerto de destino:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(884, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 22);
            this.label16.TabIndex = 70;
            this.label16.Text = "Ciudad de destino:";
            // 
            // cbbAerDestino
            // 
            this.cbbAerDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerDestino.Enabled = false;
            this.cbbAerDestino.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbAerDestino.FormattingEnabled = true;
            this.cbbAerDestino.Location = new System.Drawing.Point(1113, 202);
            this.cbbAerDestino.Name = "cbbAerDestino";
            this.cbbAerDestino.Size = new System.Drawing.Size(184, 30);
            this.cbbAerDestino.TabIndex = 72;
            this.cbbAerDestino.SelectedIndexChanged += new System.EventHandler(this.cbbAerDestino_SelectedIndexChanged);
            // 
            // cbbCiudadDestino
            // 
            this.cbbCiudadDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudadDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudadDestino.Enabled = false;
            this.cbbCiudadDestino.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbCiudadDestino.FormattingEnabled = true;
            this.cbbCiudadDestino.Location = new System.Drawing.Point(1075, 169);
            this.cbbCiudadDestino.Name = "cbbCiudadDestino";
            this.cbbCiudadDestino.Size = new System.Drawing.Size(222, 30);
            this.cbbCiudadDestino.TabIndex = 73;
            this.cbbCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.cbbCiudadDestino_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(28, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 22);
            this.label17.TabIndex = 68;
            this.label17.Text = "Estado de origen:";
            // 
            // cbbEstadoOrigen
            // 
            this.cbbEstadoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstadoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoOrigen.Enabled = false;
            this.cbbEstadoOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbEstadoOrigen.FormattingEnabled = true;
            this.cbbEstadoOrigen.Location = new System.Drawing.Point(209, 144);
            this.cbbEstadoOrigen.Name = "cbbEstadoOrigen";
            this.cbbEstadoOrigen.Size = new System.Drawing.Size(215, 30);
            this.cbbEstadoOrigen.TabIndex = 69;
            this.cbbEstadoOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoOrigen_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(28, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 22);
            this.label18.TabIndex = 66;
            this.label18.Text = "Pais de origen:";
            // 
            // cbbPaisOrigen
            // 
            this.cbbPaisOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisOrigen.Enabled = false;
            this.cbbPaisOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbPaisOrigen.FormattingEnabled = true;
            this.cbbPaisOrigen.Location = new System.Drawing.Point(209, 111);
            this.cbbPaisOrigen.Name = "cbbPaisOrigen";
            this.cbbPaisOrigen.Size = new System.Drawing.Size(215, 30);
            this.cbbPaisOrigen.TabIndex = 67;
            this.cbbPaisOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbPaisOrigen_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(28, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(215, 22);
            this.label19.TabIndex = 63;
            this.label19.Text = "Aeropuerto de origen:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(28, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 22);
            this.label20.TabIndex = 62;
            this.label20.Text = "Ciudad de origen:";
            // 
            // cbbAerOrigen
            // 
            this.cbbAerOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerOrigen.Enabled = false;
            this.cbbAerOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbAerOrigen.FormattingEnabled = true;
            this.cbbAerOrigen.Location = new System.Drawing.Point(243, 210);
            this.cbbAerOrigen.Name = "cbbAerOrigen";
            this.cbbAerOrigen.Size = new System.Drawing.Size(181, 30);
            this.cbbAerOrigen.TabIndex = 64;
            this.cbbAerOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbAerOrigen_SelectedIndexChanged);
            // 
            // cbbCiudadOrigen
            // 
            this.cbbCiudadOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudadOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudadOrigen.Enabled = false;
            this.cbbCiudadOrigen.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cbbCiudadOrigen.FormattingEnabled = true;
            this.cbbCiudadOrigen.Location = new System.Drawing.Point(209, 177);
            this.cbbCiudadOrigen.Name = "cbbCiudadOrigen";
            this.cbbCiudadOrigen.Size = new System.Drawing.Size(215, 30);
            this.cbbCiudadOrigen.TabIndex = 65;
            this.cbbCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbCiudadOrigen_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(12, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1344, 1);
            this.panel3.TabIndex = 78;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(356, 43);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(87, 31);
            this.btnVer.TabIndex = 79;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(12, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1345, 1);
            this.panel4.TabIndex = 80;
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.AllowUserToAddRows = false;
            this.dgvVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVuelos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVuelos.Location = new System.Drawing.Point(12, 254);
            this.dgvVuelos.Name = "dgvVuelos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVuelos.Size = new System.Drawing.Size(1346, 418);
            this.dgvVuelos.TabIndex = 81;
            // 
            // FormAdminVuelosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvVuelos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbEstadoDestino);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbbPaisDestino);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbbAerDestino);
            this.Controls.Add(this.cbbCiudadDestino);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbbEstadoOrigen);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbbPaisOrigen);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbbAerOrigen);
            this.Controls.Add(this.cbbCiudadOrigen);
            this.Controls.Add(this.rbNumeroVuelo);
            this.Controls.Add(this.rbRuta);
            this.Controls.Add(this.txtNumVuelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdminVuelosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultarVuelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumVuelo;
        private System.Windows.Forms.RadioButton rbRuta;
        private System.Windows.Forms.RadioButton rbNumeroVuelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbEstadoDestino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbPaisDestino;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbAerDestino;
        private System.Windows.Forms.ComboBox cbbCiudadDestino;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbEstadoOrigen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbbPaisOrigen;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbAerOrigen;
        private System.Windows.Forms.ComboBox cbbCiudadOrigen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvVuelos;
    }
}