namespace CapaPresentesacion
{
    partial class FormAdminNominaRegistro
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEPS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInfoAdicional = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVerificaContraseña = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cbbTipoDoc = new System.Windows.Forms.ComboBox();
            this.cbbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cbbBanco = new System.Windows.Forms.ComboBox();
            this.cbbTipoContra = new System.Windows.Forms.ComboBox();
            this.cbbCiudades = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tipo de contrato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(110, 66);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(64, 31);
            this.dtpNacimiento.TabIndex = 20;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(108, 46);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(66, 20);
            this.txtDocumento.TabIndex = 19;
            this.txtDocumento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Documento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(60, 26);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(114, 20);
            this.txtApellidos.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(60, 6);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(114, 20);
            this.txtNombres.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(60, 115);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(114, 20);
            this.txtPuesto.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(60, 133);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(114, 20);
            this.txtSueldo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "N° de cuenta:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(78, 151);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(96, 20);
            this.txtCuenta.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tipo de cuenta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Banco:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(195, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "E.P.S:";
            // 
            // txtEPS
            // 
            this.txtEPS.Location = new System.Drawing.Point(228, 6);
            this.txtEPS.Name = "txtEPS";
            this.txtEPS.Size = new System.Drawing.Size(114, 20);
            this.txtEPS.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(195, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(245, 25);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(97, 20);
            this.txtDireccion.TabIndex = 37;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(195, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(114, 20);
            this.txtEmail.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(195, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 23);
            this.label14.TabIndex = 40;
            this.label14.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(245, 63);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(97, 20);
            this.txtTelefono.TabIndex = 41;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(397, 174);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 28);
            this.btnRegistrar.TabIndex = 42;
            this.btnRegistrar.Text = "Completar registro";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(195, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 23);
            this.label15.TabIndex = 43;
            this.label15.Text = "Información adicional:";
            // 
            // txtInfoAdicional
            // 
            this.txtInfoAdicional.Location = new System.Drawing.Point(199, 135);
            this.txtInfoAdicional.Name = "txtInfoAdicional";
            this.txtInfoAdicional.Size = new System.Drawing.Size(143, 67);
            this.txtInfoAdicional.TabIndex = 44;
            this.txtInfoAdicional.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(344, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 23);
            this.label16.TabIndex = 45;
            this.label16.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(401, 6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(84, 20);
            this.txtUsuario.TabIndex = 46;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(401, 29);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(84, 20);
            this.txtContraseña.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(344, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 23);
            this.label17.TabIndex = 47;
            this.label17.Text = "Contraseña:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(344, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 23);
            this.label18.TabIndex = 49;
            this.label18.Text = "contraseña:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(344, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 23);
            this.label19.TabIndex = 50;
            this.label19.Text = "Verificar";
            // 
            // txtVerificaContraseña
            // 
            this.txtVerificaContraseña.Location = new System.Drawing.Point(401, 68);
            this.txtVerificaContraseña.Name = "txtVerificaContraseña";
            this.txtVerificaContraseña.PasswordChar = '*';
            this.txtVerificaContraseña.Size = new System.Drawing.Size(84, 20);
            this.txtVerificaContraseña.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(195, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 23);
            this.label20.TabIndex = 52;
            this.label20.Text = "Ciudad:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(344, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 23);
            this.label21.TabIndex = 54;
            this.label21.Text = "Tipo de usuario:";
            // 
            // cbbTipoUsuario
            // 
            this.cbbTipoUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Caja",
            "Tripulación",
            "Empleado"});
            this.cbbTipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbTipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTipoUsuario.FormattingEnabled = true;
            this.cbbTipoUsuario.Items.AddRange(new object[] {
            "Admin",
            "Caja",
            "Tripulación",
            "Empleado"});
            this.cbbTipoUsuario.Location = new System.Drawing.Point(348, 114);
            this.cbbTipoUsuario.Name = "cbbTipoUsuario";
            this.cbbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbbTipoUsuario.TabIndex = 55;
            // 
            // cbbTipoDoc
            // 
            this.cbbTipoDoc.FormattingEnabled = true;
            this.cbbTipoDoc.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE"});
            this.cbbTipoDoc.Location = new System.Drawing.Point(69, 46);
            this.cbbTipoDoc.Name = "cbbTipoDoc";
            this.cbbTipoDoc.Size = new System.Drawing.Size(37, 21);
            this.cbbTipoDoc.TabIndex = 56;
            // 
            // cbbTipoCuenta
            // 
            this.cbbTipoCuenta.FormattingEnabled = true;
            this.cbbTipoCuenta.Items.AddRange(new object[] {
            "Ahorros",
            "Corriente"});
            this.cbbTipoCuenta.Location = new System.Drawing.Point(116, 168);
            this.cbbTipoCuenta.Name = "cbbTipoCuenta";
            this.cbbTipoCuenta.Size = new System.Drawing.Size(58, 21);
            this.cbbTipoCuenta.TabIndex = 57;
            // 
            // cbbBanco
            // 
            this.cbbBanco.FormattingEnabled = true;
            this.cbbBanco.Items.AddRange(new object[] {
            "Bancolombia",
            "Davivienda",
            "Banco de Bogotá"});
            this.cbbBanco.Location = new System.Drawing.Point(69, 185);
            this.cbbBanco.Name = "cbbBanco";
            this.cbbBanco.Size = new System.Drawing.Size(105, 21);
            this.cbbBanco.TabIndex = 58;
            // 
            // cbbTipoContra
            // 
            this.cbbTipoContra.FormattingEnabled = true;
            this.cbbTipoContra.Items.AddRange(new object[] {
            "Planta",
            "Temporal",
            "Pasante"});
            this.cbbTipoContra.Location = new System.Drawing.Point(116, 96);
            this.cbbTipoContra.Name = "cbbTipoContra";
            this.cbbTipoContra.Size = new System.Drawing.Size(58, 21);
            this.cbbTipoContra.TabIndex = 59;
            // 
            // cbbCiudades
            // 
            this.cbbCiudades.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Caja",
            "Tripulación",
            "Empleado"});
            this.cbbCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudades.FormattingEnabled = true;
            this.cbbCiudades.Location = new System.Drawing.Point(245, 82);
            this.cbbCiudades.Name = "cbbCiudades";
            this.cbbCiudades.Size = new System.Drawing.Size(97, 21);
            this.cbbCiudades.TabIndex = 60;
            // 
            // cbbEstado
            // 
            this.cbbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Caja",
            "Tripulación",
            "Empleado"});
            this.cbbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbbEstado.Location = new System.Drawing.Point(388, 136);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(97, 21);
            this.cbbEstado.TabIndex = 62;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(347, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 23);
            this.label22.TabIndex = 61;
            this.label22.Text = "Estado";
            // 
            // FormAdminNominaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 209);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbbCiudades);
            this.Controls.Add(this.cbbTipoContra);
            this.Controls.Add(this.cbbBanco);
            this.Controls.Add(this.cbbTipoCuenta);
            this.Controls.Add(this.cbbTipoDoc);
            this.Controls.Add(this.cbbTipoUsuario);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtVerificaContraseña);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtInfoAdicional);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEPS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminNominaRegistro";
            this.Text = "registroNomina";
            this.Load += new System.EventHandler(this.registroEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEPS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox txtInfoAdicional;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtVerificaContraseña;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbbTipoUsuario;
        private System.Windows.Forms.ComboBox cbbTipoDoc;
        private System.Windows.Forms.ComboBox cbbTipoCuenta;
        private System.Windows.Forms.ComboBox cbbBanco;
        private System.Windows.Forms.ComboBox cbbTipoContra;
        private System.Windows.Forms.ComboBox cbbCiudades;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label22;
    }
}