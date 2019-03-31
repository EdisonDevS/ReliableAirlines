namespace CapaPresentesacion
{
    partial class FormAdminVuelosGestionNuevo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVlrPclase = new System.Windows.Forms.TextBox();
            this.txtVlrCturista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVerTripulante = new System.Windows.Forms.Button();
            this.btnAgregarTripu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCrearVuelo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNombreTrip = new System.Windows.Forms.Label();
            this.lblPuestoTip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cbbNombreRuta = new System.Windows.Forms.ComboBox();
            this.cbbMatriculaAeronave = new System.Windows.Forms.ComboBox();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.cbbAgregarComo = new System.Windows.Forms.ComboBox();
            this.lblCiuOri = new System.Windows.Forms.Label();
            this.lblCiuDes = new System.Windows.Forms.Label();
            this.lblAerOri = new System.Windows.Forms.Label();
            this.lblAerDes = new System.Windows.Forms.Label();
            this.lblCapPclas = new System.Windows.Forms.Label();
            this.lblCapCtur = new System.Windows.Forms.Label();
            this.lblEstAct = new System.Windows.Forms.Label();
            this.lblTipoAer = new System.Windows.Forms.Label();
            this.txtNumVuelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTripulacion = new System.Windows.Forms.DataGridView();
            this.cbbTripulante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad de origen:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(684, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad de destino:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Aeropueto de origen:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(684, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Aeropueto de destino:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Matricula de la aeronave:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salida:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(98, 324);
            this.dtpSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(143, 32);
            this.dtpSalida.TabIndex = 13;
            this.dtpSalida.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpHoraLlegada
            // 
            this.dtpHoraLlegada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraLlegada.Location = new System.Drawing.Point(937, 326);
            this.dtpHoraLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraLlegada.Name = "dtpHoraLlegada";
            this.dtpHoraLlegada.Size = new System.Drawing.Size(81, 32);
            this.dtpHoraLlegada.TabIndex = 17;
            this.dtpHoraLlegada.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLlegada.Location = new System.Drawing.Point(785, 326);
            this.dtpLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(143, 32);
            this.dtpLlegada.TabIndex = 16;
            this.dtpLlegada.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(684, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Llegada:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 393);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Valor primera clase:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtVlrPclase
            // 
            this.txtVlrPclase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrPclase.Location = new System.Drawing.Point(231, 390);
            this.txtVlrPclase.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrPclase.Name = "txtVlrPclase";
            this.txtVlrPclase.Size = new System.Drawing.Size(291, 32);
            this.txtVlrPclase.TabIndex = 19;
            this.txtVlrPclase.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtVlrCturista
            // 
            this.txtVlrCturista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrCturista.Location = new System.Drawing.Point(884, 393);
            this.txtVlrCturista.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrCturista.Name = "txtVlrCturista";
            this.txtVlrCturista.Size = new System.Drawing.Size(291, 32);
            this.txtVlrCturista.TabIndex = 21;
            this.txtVlrCturista.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(687, 399);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Valor clase turista:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 513);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(355, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Añadir tripulante por identificación:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnVerTripulante
            // 
            this.btnVerTripulante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVerTripulante.Enabled = false;
            this.btnVerTripulante.FlatAppearance.BorderSize = 0;
            this.btnVerTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTripulante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTripulante.ForeColor = System.Drawing.Color.White;
            this.btnVerTripulante.Location = new System.Drawing.Point(724, 555);
            this.btnVerTripulante.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTripulante.Name = "btnVerTripulante";
            this.btnVerTripulante.Size = new System.Drawing.Size(120, 41);
            this.btnVerTripulante.TabIndex = 24;
            this.btnVerTripulante.Text = "Ver";
            this.btnVerTripulante.UseVisualStyleBackColor = false;
            this.btnVerTripulante.Click += new System.EventHandler(this.btnVerTripulante_Click);
            // 
            // btnAgregarTripu
            // 
            this.btnAgregarTripu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnAgregarTripu.Enabled = false;
            this.btnAgregarTripu.FlatAppearance.BorderSize = 0;
            this.btnAgregarTripu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTripu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTripu.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTripu.Location = new System.Drawing.Point(667, 604);
            this.btnAgregarTripu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTripu.Name = "btnAgregarTripu";
            this.btnAgregarTripu.Size = new System.Drawing.Size(177, 69);
            this.btnAgregarTripu.TabIndex = 25;
            this.btnAgregarTripu.Text = "Añadir a la tripulación";
            this.btnAgregarTripu.UseVisualStyleBackColor = false;
            this.btnAgregarTripu.Click += new System.EventHandler(this.btnAgregarTripu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 607);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Añadir como:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnCrearVuelo
            // 
            this.btnCrearVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearVuelo.FlatAppearance.BorderSize = 0;
            this.btnCrearVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVuelo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVuelo.ForeColor = System.Drawing.Color.White;
            this.btnCrearVuelo.Location = new System.Drawing.Point(23, 431);
            this.btnCrearVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearVuelo.Name = "btnCrearVuelo";
            this.btnCrearVuelo.Size = new System.Drawing.Size(1276, 52);
            this.btnCrearVuelo.TabIndex = 28;
            this.btnCrearVuelo.Text = "Crear vuelo y seleccionar tripulantes";
            this.btnCrearVuelo.UseVisualStyleBackColor = false;
            this.btnCrearVuelo.Click += new System.EventHandler(this.btnCrearVuelo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 53);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "Información de ruta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 23);
            this.label14.TabIndex = 30;
            this.label14.Text = "Nombre de ruta:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, 172);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(253, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "Información de aeronave:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(17, 298);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 22);
            this.label16.TabIndex = 33;
            this.label16.Text = "Fecha y hora de vuelo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(16, 369);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 22);
            this.label17.TabIndex = 34;
            this.label17.Text = "Valores de tiquetes:";
            // 
            // lblNombreTrip
            // 
            this.lblNombreTrip.AutoSize = true;
            this.lblNombreTrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTrip.ForeColor = System.Drawing.Color.White;
            this.lblNombreTrip.Location = new System.Drawing.Point(27, 541);
            this.lblNombreTrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTrip.Name = "lblNombreTrip";
            this.lblNombreTrip.Size = new System.Drawing.Size(223, 23);
            this.lblNombreTrip.TabIndex = 35;
            this.lblNombreTrip.Text = "Nombres y apellidos: ";
            // 
            // lblPuestoTip
            // 
            this.lblPuestoTip.AutoSize = true;
            this.lblPuestoTip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoTip.ForeColor = System.Drawing.Color.White;
            this.lblPuestoTip.Location = new System.Drawing.Point(27, 573);
            this.lblPuestoTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuestoTip.Name = "lblPuestoTip";
            this.lblPuestoTip.Size = new System.Drawing.Size(86, 23);
            this.lblPuestoTip.TabIndex = 36;
            this.lblPuestoTip.Text = "Puesto: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(19, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 1);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(19, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 1);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(19, 291);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 1);
            this.panel3.TabIndex = 42;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(19, 364);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1280, 1);
            this.panel4.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel5.Location = new System.Drawing.Point(19, 427);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1280, 1);
            this.panel5.TabIndex = 42;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(27, 489);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(254, 22);
            this.label24.TabIndex = 43;
            this.label24.Text = "Miembros de la tripulación:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(687, 195);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(187, 23);
            this.label25.TabIndex = 44;
            this.label25.Text = "Tipo de aeronave:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(17, 232);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(268, 23);
            this.label26.TabIndex = 45;
            this.label26.Text = "Capacidad primera clase:";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(684, 232);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(250, 23);
            this.label27.TabIndex = 46;
            this.label27.Text = "Capacidad clase turista:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(17, 262);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(148, 23);
            this.label28.TabIndex = 47;
            this.label28.Text = "Estado actual:";
            // 
            // cbbNombreRuta
            // 
            this.cbbNombreRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbNombreRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNombreRuta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNombreRuta.FormattingEnabled = true;
            this.cbbNombreRuta.Location = new System.Drawing.Point(193, 75);
            this.cbbNombreRuta.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNombreRuta.Name = "cbbNombreRuta";
            this.cbbNombreRuta.Size = new System.Drawing.Size(337, 31);
            this.cbbNombreRuta.TabIndex = 48;
            this.cbbNombreRuta.SelectedIndexChanged += new System.EventHandler(this.cbbNombreRuta_SelectedIndexChanged);
            // 
            // cbbMatriculaAeronave
            // 
            this.cbbMatriculaAeronave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbMatriculaAeronave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMatriculaAeronave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMatriculaAeronave.FormattingEnabled = true;
            this.cbbMatriculaAeronave.Location = new System.Drawing.Point(287, 195);
            this.cbbMatriculaAeronave.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMatriculaAeronave.Name = "cbbMatriculaAeronave";
            this.cbbMatriculaAeronave.Size = new System.Drawing.Size(207, 31);
            this.cbbMatriculaAeronave.TabIndex = 49;
            this.cbbMatriculaAeronave.SelectedIndexChanged += new System.EventHandler(this.cbbMatriculaAeronave_SelectedIndexChanged);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(249, 324);
            this.dtpHoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(84, 32);
            this.dtpHoraSalida.TabIndex = 14;
            this.dtpHoraSalida.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cbbAgregarComo
            // 
            this.cbbAgregarComo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAgregarComo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAgregarComo.Enabled = false;
            this.cbbAgregarComo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAgregarComo.FormattingEnabled = true;
            this.cbbAgregarComo.Items.AddRange(new object[] {
            "Piloto",
            "Copiloto",
            "Auxiliar"});
            this.cbbAgregarComo.Location = new System.Drawing.Point(177, 604);
            this.cbbAgregarComo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbAgregarComo.Name = "cbbAgregarComo";
            this.cbbAgregarComo.Size = new System.Drawing.Size(271, 31);
            this.cbbAgregarComo.TabIndex = 50;
            // 
            // lblCiuOri
            // 
            this.lblCiuOri.AutoSize = true;
            this.lblCiuOri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiuOri.ForeColor = System.Drawing.Color.White;
            this.lblCiuOri.Location = new System.Drawing.Point(212, 112);
            this.lblCiuOri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiuOri.Name = "lblCiuOri";
            this.lblCiuOri.Size = new System.Drawing.Size(0, 23);
            this.lblCiuOri.TabIndex = 51;
            // 
            // lblCiuDes
            // 
            this.lblCiuDes.AutoSize = true;
            this.lblCiuDes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiuDes.ForeColor = System.Drawing.Color.White;
            this.lblCiuDes.Location = new System.Drawing.Point(889, 114);
            this.lblCiuDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiuDes.Name = "lblCiuDes";
            this.lblCiuDes.Size = new System.Drawing.Size(0, 23);
            this.lblCiuDes.TabIndex = 52;
            // 
            // lblAerOri
            // 
            this.lblAerOri.AutoSize = true;
            this.lblAerOri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAerOri.ForeColor = System.Drawing.Color.White;
            this.lblAerOri.Location = new System.Drawing.Point(270, 136);
            this.lblAerOri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAerOri.Name = "lblAerOri";
            this.lblAerOri.Size = new System.Drawing.Size(0, 23);
            this.lblAerOri.TabIndex = 53;
            // 
            // lblAerDes
            // 
            this.lblAerDes.AutoSize = true;
            this.lblAerDes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAerDes.ForeColor = System.Drawing.Color.White;
            this.lblAerDes.Location = new System.Drawing.Point(947, 140);
            this.lblAerDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAerDes.Name = "lblAerDes";
            this.lblAerDes.Size = new System.Drawing.Size(0, 23);
            this.lblAerDes.TabIndex = 54;
            // 
            // lblCapPclas
            // 
            this.lblCapPclas.AutoSize = true;
            this.lblCapPclas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapPclas.ForeColor = System.Drawing.Color.White;
            this.lblCapPclas.Location = new System.Drawing.Point(293, 232);
            this.lblCapPclas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapPclas.Name = "lblCapPclas";
            this.lblCapPclas.Size = new System.Drawing.Size(0, 23);
            this.lblCapPclas.TabIndex = 55;
            // 
            // lblCapCtur
            // 
            this.lblCapCtur.AutoSize = true;
            this.lblCapCtur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapCtur.ForeColor = System.Drawing.Color.White;
            this.lblCapCtur.Location = new System.Drawing.Point(942, 232);
            this.lblCapCtur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapCtur.Name = "lblCapCtur";
            this.lblCapCtur.Size = new System.Drawing.Size(0, 23);
            this.lblCapCtur.TabIndex = 56;
            // 
            // lblEstAct
            // 
            this.lblEstAct.AutoSize = true;
            this.lblEstAct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstAct.ForeColor = System.Drawing.Color.White;
            this.lblEstAct.Location = new System.Drawing.Point(173, 262);
            this.lblEstAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstAct.Name = "lblEstAct";
            this.lblEstAct.Size = new System.Drawing.Size(0, 23);
            this.lblEstAct.TabIndex = 57;
            // 
            // lblTipoAer
            // 
            this.lblTipoAer.AutoSize = true;
            this.lblTipoAer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAer.ForeColor = System.Drawing.Color.White;
            this.lblTipoAer.Location = new System.Drawing.Point(882, 198);
            this.lblTipoAer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAer.Name = "lblTipoAer";
            this.lblTipoAer.Size = new System.Drawing.Size(0, 23);
            this.lblTipoAer.TabIndex = 64;
            // 
            // txtNumVuelo
            // 
            this.txtNumVuelo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVuelo.Location = new System.Drawing.Point(205, 7);
            this.txtNumVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumVuelo.Name = "txtNumVuelo";
            this.txtNumVuelo.Size = new System.Drawing.Size(151, 37);
            this.txtNumVuelo.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 67;
            this.label5.Text = "N° de vuelo:";
            // 
            // dgvTripulacion
            // 
            this.dgvTripulacion.AllowUserToAddRows = false;
            this.dgvTripulacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTripulacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTripulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTripulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTripulacion.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTripulacion.Location = new System.Drawing.Point(962, 491);
            this.dgvTripulacion.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTripulacion.Name = "dgvTripulacion";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTripulacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTripulacion.Size = new System.Drawing.Size(337, 182);
            this.dgvTripulacion.TabIndex = 82;
            // 
            // cbbTripulante
            // 
            this.cbbTripulante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbTripulante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTripulante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTripulante.FormattingEnabled = true;
            this.cbbTripulante.Location = new System.Drawing.Point(388, 510);
            this.cbbTripulante.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTripulante.Name = "cbbTripulante";
            this.cbbTripulante.Size = new System.Drawing.Size(456, 31);
            this.cbbTripulante.TabIndex = 134;
            // 
            // FormAdminVuelosGestionNuevo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 695);
            this.Controls.Add(this.cbbTripulante);
            this.Controls.Add(this.dgvTripulacion);
            this.Controls.Add(this.txtNumVuelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTipoAer);
            this.Controls.Add(this.lblEstAct);
            this.Controls.Add(this.lblCapCtur);
            this.Controls.Add(this.lblCapPclas);
            this.Controls.Add(this.lblAerDes);
            this.Controls.Add(this.lblAerOri);
            this.Controls.Add(this.lblCiuDes);
            this.Controls.Add(this.lblCiuOri);
            this.Controls.Add(this.cbbAgregarComo);
            this.Controls.Add(this.cbbMatriculaAeronave);
            this.Controls.Add(this.cbbNombreRuta);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPuestoTip);
            this.Controls.Add(this.lblNombreTrip);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCrearVuelo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAgregarTripu);
            this.Controls.Add(this.btnVerTripulante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVlrCturista);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVlrPclase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpHoraLlegada);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminVuelosGestionNuevo";
            this.Load += new System.EventHandler(this.nuevoVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTripulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegada;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVlrPclase;
        private System.Windows.Forms.TextBox txtVlrCturista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVerTripulante;
        private System.Windows.Forms.Button btnAgregarTripu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCrearVuelo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblNombreTrip;
        private System.Windows.Forms.Label lblPuestoTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbbNombreRuta;
        private System.Windows.Forms.ComboBox cbbMatriculaAeronave;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.ComboBox cbbAgregarComo;
        private System.Windows.Forms.Label lblCiuOri;
        private System.Windows.Forms.Label lblCiuDes;
        private System.Windows.Forms.Label lblAerOri;
        private System.Windows.Forms.Label lblAerDes;
        private System.Windows.Forms.Label lblCapPclas;
        private System.Windows.Forms.Label lblCapCtur;
        private System.Windows.Forms.Label lblEstAct;
        private System.Windows.Forms.Label lblTipoAer;
        private System.Windows.Forms.TextBox txtNumVuelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTripulacion;
        private System.Windows.Forms.ComboBox cbbTripulante;
    }
}