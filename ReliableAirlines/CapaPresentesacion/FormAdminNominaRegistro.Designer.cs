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
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
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
            this.cbbCiudades = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(242, 199);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(139, 36);
            this.dtpNacimiento.TabIndex = 20;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtDocumento.Location = new System.Drawing.Point(205, 148);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(135, 36);
            this.txtDocumento.TabIndex = 19;
            this.txtDocumento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Documento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtApellidos.Location = new System.Drawing.Point(122, 83);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(192, 36);
            this.txtApellidos.TabIndex = 15;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtNombres.Location = new System.Drawing.Point(117, 22);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(192, 36);
            this.txtNombres.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(415, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 28);
            this.label11.TabIndex = 34;
            this.label11.Text = "E.P.S:";
            // 
            // txtEPS
            // 
            this.txtEPS.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtEPS.Location = new System.Drawing.Point(468, 21);
            this.txtEPS.Margin = new System.Windows.Forms.Padding(4);
            this.txtEPS.Name = "txtEPS";
            this.txtEPS.Size = new System.Drawing.Size(290, 36);
            this.txtEPS.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(415, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 28);
            this.label12.TabIndex = 36;
            this.label12.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtDireccion.Location = new System.Drawing.Point(515, 84);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 36);
            this.txtDireccion.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(415, 156);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 28);
            this.label13.TabIndex = 38;
            this.label13.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtEmail.Location = new System.Drawing.Point(480, 151);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 36);
            this.txtEmail.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(415, 217);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 28);
            this.label14.TabIndex = 40;
            this.label14.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtTelefono.Location = new System.Drawing.Point(503, 213);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(255, 36);
            this.txtTelefono.TabIndex = 41;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(911, 306);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(153, 67);
            this.btnRegistrar.TabIndex = 42;
            this.btnRegistrar.Text = "Completar registro";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, 270);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(276, 28);
            this.label15.TabIndex = 43;
            this.label15.Text = "Información adicional:";
            // 
            // txtInfoAdicional
            // 
            this.txtInfoAdicional.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtInfoAdicional.Location = new System.Drawing.Point(21, 292);
            this.txtInfoAdicional.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoAdicional.Name = "txtInfoAdicional";
            this.txtInfoAdicional.Size = new System.Drawing.Size(367, 82);
            this.txtInfoAdicional.TabIndex = 44;
            this.txtInfoAdicional.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(778, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 28);
            this.label16.TabIndex = 45;
            this.label16.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtUsuario.Location = new System.Drawing.Point(860, 22);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(194, 36);
            this.txtUsuario.TabIndex = 46;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtContraseña.Location = new System.Drawing.Point(906, 87);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(148, 36);
            this.txtContraseña.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(778, 87);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 28);
            this.label17.TabIndex = 47;
            this.label17.Text = "Contraseña:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(778, 157);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 28);
            this.label18.TabIndex = 49;
            this.label18.Text = "contraseña:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(778, 129);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 28);
            this.label19.TabIndex = 50;
            this.label19.Text = "Verificar";
            // 
            // txtVerificaContraseña
            // 
            this.txtVerificaContraseña.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtVerificaContraseña.Location = new System.Drawing.Point(906, 154);
            this.txtVerificaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificaContraseña.Name = "txtVerificaContraseña";
            this.txtVerificaContraseña.PasswordChar = '*';
            this.txtVerificaContraseña.Size = new System.Drawing.Size(148, 36);
            this.txtVerificaContraseña.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(415, 274);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 28);
            this.label20.TabIndex = 52;
            this.label20.Text = "Ciudad:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(778, 212);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(195, 28);
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
            this.cbbTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cbbTipoUsuario.FormattingEnabled = true;
            this.cbbTipoUsuario.Items.AddRange(new object[] {
            "Admin",
            "Caja",
            "Tripulación",
            "Empleado"});
            this.cbbTipoUsuario.Location = new System.Drawing.Point(936, 211);
            this.cbbTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTipoUsuario.Name = "cbbTipoUsuario";
            this.cbbTipoUsuario.Size = new System.Drawing.Size(118, 35);
            this.cbbTipoUsuario.TabIndex = 55;
            // 
            // cbbTipoDoc
            // 
            this.cbbTipoDoc.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cbbTipoDoc.FormattingEnabled = true;
            this.cbbTipoDoc.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE"});
            this.cbbTipoDoc.Location = new System.Drawing.Point(156, 148);
            this.cbbTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTipoDoc.Name = "cbbTipoDoc";
            this.cbbTipoDoc.Size = new System.Drawing.Size(48, 35);
            this.cbbTipoDoc.TabIndex = 56;
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
            this.cbbCiudades.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cbbCiudades.FormattingEnabled = true;
            this.cbbCiudades.Location = new System.Drawing.Point(503, 269);
            this.cbbCiudades.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCiudades.Name = "cbbCiudades";
            this.cbbCiudades.Size = new System.Drawing.Size(255, 35);
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
            this.cbbEstado.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbbEstado.Location = new System.Drawing.Point(859, 262);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(120, 35);
            this.cbbEstado.TabIndex = 62;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(778, 265);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 28);
            this.label22.TabIndex = 61;
            this.label22.Text = "Estado:";
            // 
            // FormAdminNominaRegistro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 386);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbbCiudades);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombres);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminNominaRegistro";
            this.Text = "registroNomina";
            this.Load += new System.EventHandler(this.registroEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
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
        private System.Windows.Forms.ComboBox cbbCiudades;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label22;
    }
}