namespace CapaPresentesacion
{
    partial class FormCrearLocacion
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
            this.btnCrearCiudad = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbCiuEstado = new System.Windows.Forms.ComboBox();
            this.cbbCiuPais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbAerEstado = new System.Windows.Forms.ComboBox();
            this.cbbAerCiudad = new System.Windows.Forms.ComboBox();
            this.cbbAerPais = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCrearAeropuerto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAeropuerto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbEstPais = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCrearEstado = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCrearPais = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbCiudad = new System.Windows.Forms.RadioButton();
            this.rbAeropuerto = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCiudad
            // 
            this.btnCrearCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearCiudad.Enabled = false;
            this.btnCrearCiudad.FlatAppearance.BorderSize = 0;
            this.btnCrearCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCiudad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCiudad.ForeColor = System.Drawing.Color.White;
            this.btnCrearCiudad.Location = new System.Drawing.Point(648, 93);
            this.btnCrearCiudad.Name = "btnCrearCiudad";
            this.btnCrearCiudad.Size = new System.Drawing.Size(112, 36);
            this.btnCrearCiudad.TabIndex = 15;
            this.btnCrearCiudad.Text = "Guardar ruta";
            this.btnCrearCiudad.UseVisualStyleBackColor = false;
            this.btnCrearCiudad.Click += new System.EventHandler(this.btnCrearCiudad_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(371, 96);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(271, 33);
            this.txtCiudad.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de la nueva ciudad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.cbbCiuEstado);
            this.panel1.Controls.Add(this.cbbCiuPais);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCrearCiudad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Location = new System.Drawing.Point(12, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 137);
            this.panel1.TabIndex = 17;
            // 
            // cbbCiuEstado
            // 
            this.cbbCiuEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiuEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiuEstado.Enabled = false;
            this.cbbCiuEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbbCiuEstado.FormattingEnabled = true;
            this.cbbCiuEstado.Location = new System.Drawing.Point(371, 55);
            this.cbbCiuEstado.Name = "cbbCiuEstado";
            this.cbbCiuEstado.Size = new System.Drawing.Size(271, 32);
            this.cbbCiuEstado.TabIndex = 19;
            // 
            // cbbCiuPais
            // 
            this.cbbCiuPais.Enabled = false;
            this.cbbCiuPais.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbbCiuPais.FormattingEnabled = true;
            this.cbbCiuPais.Location = new System.Drawing.Point(371, 15);
            this.cbbCiuPais.Name = "cbbCiuPais";
            this.cbbCiuPais.Size = new System.Drawing.Size(271, 32);
            this.cbbCiuPais.TabIndex = 18;
            this.cbbCiuPais.SelectedIndexChanged += new System.EventHandler(this.cbbCiuPais_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "País:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Agregar ciudad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel2.Location = new System.Drawing.Point(12, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 1);
            this.panel2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Agregar aeropuerto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel3.Controls.Add(this.cbbAerEstado);
            this.panel3.Controls.Add(this.cbbAerCiudad);
            this.panel3.Controls.Add(this.cbbAerPais);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnCrearAeropuerto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAeropuerto);
            this.panel3.Location = new System.Drawing.Point(12, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 178);
            this.panel3.TabIndex = 44;
            // 
            // cbbAerEstado
            // 
            this.cbbAerEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerEstado.Enabled = false;
            this.cbbAerEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbbAerEstado.FormattingEnabled = true;
            this.cbbAerEstado.Location = new System.Drawing.Point(367, 51);
            this.cbbAerEstado.Name = "cbbAerEstado";
            this.cbbAerEstado.Size = new System.Drawing.Size(271, 32);
            this.cbbAerEstado.TabIndex = 23;
            this.cbbAerEstado.SelectedIndexChanged += new System.EventHandler(this.cbbAerEstado_SelectedIndexChanged);
            // 
            // cbbAerCiudad
            // 
            this.cbbAerCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerCiudad.Enabled = false;
            this.cbbAerCiudad.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbbAerCiudad.FormattingEnabled = true;
            this.cbbAerCiudad.Location = new System.Drawing.Point(367, 91);
            this.cbbAerCiudad.Name = "cbbAerCiudad";
            this.cbbAerCiudad.Size = new System.Drawing.Size(271, 32);
            this.cbbAerCiudad.TabIndex = 17;
            // 
            // cbbAerPais
            // 
            this.cbbAerPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerPais.Enabled = false;
            this.cbbAerPais.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbbAerPais.FormattingEnabled = true;
            this.cbbAerPais.Location = new System.Drawing.Point(367, 11);
            this.cbbAerPais.Name = "cbbAerPais";
            this.cbbAerPais.Size = new System.Drawing.Size(271, 32);
            this.cbbAerPais.TabIndex = 22;
            this.cbbAerPais.SelectedIndexChanged += new System.EventHandler(this.cbbAerPais_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(27, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "País:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ciudad del aeropuerto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(27, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "Estado";
            // 
            // btnCrearAeropuerto
            // 
            this.btnCrearAeropuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearAeropuerto.Enabled = false;
            this.btnCrearAeropuerto.FlatAppearance.BorderSize = 0;
            this.btnCrearAeropuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearAeropuerto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAeropuerto.ForeColor = System.Drawing.Color.White;
            this.btnCrearAeropuerto.Location = new System.Drawing.Point(644, 128);
            this.btnCrearAeropuerto.Name = "btnCrearAeropuerto";
            this.btnCrearAeropuerto.Size = new System.Drawing.Size(112, 36);
            this.btnCrearAeropuerto.TabIndex = 15;
            this.btnCrearAeropuerto.Text = "Guardar ruta";
            this.btnCrearAeropuerto.UseVisualStyleBackColor = false;
            this.btnCrearAeropuerto.Click += new System.EventHandler(this.btnCrearAeropuerto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre del nuevo aeropuerto:";
            // 
            // txtAeropuerto
            // 
            this.txtAeropuerto.Enabled = false;
            this.txtAeropuerto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAeropuerto.Location = new System.Drawing.Point(367, 131);
            this.txtAeropuerto.Name = "txtAeropuerto";
            this.txtAeropuerto.Size = new System.Drawing.Size(271, 33);
            this.txtAeropuerto.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel4.Location = new System.Drawing.Point(12, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 1);
            this.panel4.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Agregar estado";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel5.Controls.Add(this.cbbEstPais);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btnCrearEstado);
            this.panel5.Controls.Add(this.txtEstado);
            this.panel5.Location = new System.Drawing.Point(12, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 104);
            this.panel5.TabIndex = 44;
            // 
            // cbbEstPais
            // 
            this.cbbEstPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstPais.Enabled = false;
            this.cbbEstPais.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cbbEstPais.FormattingEnabled = true;
            this.cbbEstPais.Location = new System.Drawing.Point(371, 15);
            this.cbbEstPais.Name = "cbbEstPais";
            this.cbbEstPais.Size = new System.Drawing.Size(271, 32);
            this.cbbEstPais.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "País:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nombre del nuevo estado:";
            // 
            // btnCrearEstado
            // 
            this.btnCrearEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearEstado.Enabled = false;
            this.btnCrearEstado.FlatAppearance.BorderSize = 0;
            this.btnCrearEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEstado.ForeColor = System.Drawing.Color.White;
            this.btnCrearEstado.Location = new System.Drawing.Point(648, 55);
            this.btnCrearEstado.Name = "btnCrearEstado";
            this.btnCrearEstado.Size = new System.Drawing.Size(112, 36);
            this.btnCrearEstado.TabIndex = 15;
            this.btnCrearEstado.Text = "Guardar ruta";
            this.btnCrearEstado.UseVisualStyleBackColor = false;
            this.btnCrearEstado.Click += new System.EventHandler(this.btnCrearEstado_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(371, 58);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(271, 33);
            this.txtEstado.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel6.Location = new System.Drawing.Point(12, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(776, 1);
            this.panel6.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 48;
            this.label11.Text = "Agregar país";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.btnCrearPais);
            this.panel7.Controls.Add(this.txtPais);
            this.panel7.Location = new System.Drawing.Point(12, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(776, 60);
            this.panel7.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(27, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Nombre del nuevo país:";
            // 
            // btnCrearPais
            // 
            this.btnCrearPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearPais.FlatAppearance.BorderSize = 0;
            this.btnCrearPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPais.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPais.ForeColor = System.Drawing.Color.White;
            this.btnCrearPais.Location = new System.Drawing.Point(648, 12);
            this.btnCrearPais.Name = "btnCrearPais";
            this.btnCrearPais.Size = new System.Drawing.Size(112, 36);
            this.btnCrearPais.TabIndex = 15;
            this.btnCrearPais.Text = "Guardar ruta";
            this.btnCrearPais.UseVisualStyleBackColor = false;
            this.btnCrearPais.Click += new System.EventHandler(this.btnCrearPais_Click);
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(371, 15);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(271, 33);
            this.txtPais.TabIndex = 14;
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Checked = true;
            this.rbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPais.ForeColor = System.Drawing.Color.White;
            this.rbPais.Location = new System.Drawing.Point(16, 16);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(14, 13);
            this.rbPais.TabIndex = 18;
            this.rbPais.TabStop = true;
            this.rbPais.UseVisualStyleBackColor = true;
            this.rbPais.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEstado.ForeColor = System.Drawing.Color.White;
            this.rbEstado.Location = new System.Drawing.Point(16, 112);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(14, 13);
            this.rbEstado.TabIndex = 50;
            this.rbEstado.UseVisualStyleBackColor = true;
            this.rbEstado.CheckedChanged += new System.EventHandler(this.rbEstado_CheckedChanged);
            // 
            // rbCiudad
            // 
            this.rbCiudad.AutoSize = true;
            this.rbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCiudad.ForeColor = System.Drawing.Color.White;
            this.rbCiudad.Location = new System.Drawing.Point(16, 257);
            this.rbCiudad.Name = "rbCiudad";
            this.rbCiudad.Size = new System.Drawing.Size(14, 13);
            this.rbCiudad.TabIndex = 51;
            this.rbCiudad.UseVisualStyleBackColor = true;
            this.rbCiudad.CheckedChanged += new System.EventHandler(this.rbCiudad_CheckedChanged);
            // 
            // rbAeropuerto
            // 
            this.rbAeropuerto.AutoSize = true;
            this.rbAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAeropuerto.ForeColor = System.Drawing.Color.White;
            this.rbAeropuerto.Location = new System.Drawing.Point(16, 431);
            this.rbAeropuerto.Name = "rbAeropuerto";
            this.rbAeropuerto.Size = new System.Drawing.Size(14, 13);
            this.rbAeropuerto.TabIndex = 52;
            this.rbAeropuerto.UseVisualStyleBackColor = true;
            this.rbAeropuerto.CheckedChanged += new System.EventHandler(this.rbAeropuerto_CheckedChanged);
            // 
            // FormCrearLocacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(804, 645);
            this.Controls.Add(this.rbAeropuerto);
            this.Controls.Add(this.rbCiudad);
            this.Controls.Add(this.rbEstado);
            this.Controls.Add(this.rbPais);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCrearLocacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCrearCiudad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbAerCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearAeropuerto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAeropuerto;
        private System.Windows.Forms.ComboBox cbbCiuEstado;
        private System.Windows.Forms.ComboBox cbbCiuPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbbEstPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCrearEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCrearPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbCiudad;
        private System.Windows.Forms.RadioButton rbAeropuerto;
        private System.Windows.Forms.ComboBox cbbAerEstado;
        private System.Windows.Forms.ComboBox cbbAerPais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}