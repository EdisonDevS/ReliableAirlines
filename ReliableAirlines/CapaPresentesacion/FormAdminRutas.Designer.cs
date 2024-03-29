﻿namespace CapaPresentesacion
{
    partial class FormCrearRuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrearRuta = new System.Windows.Forms.Button();
            this.btnAgragarCiudad = new System.Windows.Forms.Button();
            this.cbbAerOrigen = new System.Windows.Forms.ComboBox();
            this.cbbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPaisOrigen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbEstadoOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbEstadoDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbPaisDestino = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbAerDestino = new System.Windows.Forms.ComboBox();
            this.cbbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.btnVerRutas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la ruta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(265, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 44);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad de origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aeropuerto de origen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado de la ruta:";
            // 
            // btnCrearRuta
            // 
            this.btnCrearRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnCrearRuta.FlatAppearance.BorderSize = 0;
            this.btnCrearRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRuta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRuta.ForeColor = System.Drawing.Color.White;
            this.btnCrearRuta.Location = new System.Drawing.Point(888, 325);
            this.btnCrearRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearRuta.Name = "btnCrearRuta";
            this.btnCrearRuta.Size = new System.Drawing.Size(176, 54);
            this.btnCrearRuta.TabIndex = 12;
            this.btnCrearRuta.Text = "Guardar ruta";
            this.btnCrearRuta.UseVisualStyleBackColor = false;
            this.btnCrearRuta.Click += new System.EventHandler(this.btnCrearRuta_Click);
            // 
            // btnAgragarCiudad
            // 
            this.btnAgragarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnAgragarCiudad.FlatAppearance.BorderSize = 0;
            this.btnAgragarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarCiudad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragarCiudad.ForeColor = System.Drawing.Color.White;
            this.btnAgragarCiudad.Location = new System.Drawing.Point(13, 10);
            this.btnAgragarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgragarCiudad.Name = "btnAgragarCiudad";
            this.btnAgragarCiudad.Size = new System.Drawing.Size(1051, 59);
            this.btnAgragarCiudad.TabIndex = 15;
            this.btnAgragarCiudad.Text = "Agregar ciudad o aeropuerto";
            this.btnAgragarCiudad.UseVisualStyleBackColor = false;
            this.btnAgragarCiudad.Click += new System.EventHandler(this.btnAgragarCiudad_Click);
            // 
            // cbbAerOrigen
            // 
            this.cbbAerOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerOrigen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAerOrigen.FormattingEnabled = true;
            this.cbbAerOrigen.Location = new System.Drawing.Point(301, 283);
            this.cbbAerOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbAerOrigen.Name = "cbbAerOrigen";
            this.cbbAerOrigen.Size = new System.Drawing.Size(200, 45);
            this.cbbAerOrigen.TabIndex = 16;
            this.cbbAerOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbAerOrigen_SelectedIndexChanged);
            // 
            // cbbCiudadOrigen
            // 
            this.cbbCiudadOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudadOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudadOrigen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCiudadOrigen.FormattingEnabled = true;
            this.cbbCiudadOrigen.Location = new System.Drawing.Point(257, 232);
            this.cbbCiudadOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCiudadOrigen.Name = "cbbCiudadOrigen";
            this.cbbCiudadOrigen.Size = new System.Drawing.Size(221, 45);
            this.cbbCiudadOrigen.TabIndex = 18;
            this.cbbCiudadOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbCiudadOrigen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 37);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pais de origen:";
            // 
            // cbbPaisOrigen
            // 
            this.cbbPaisOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisOrigen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPaisOrigen.FormattingEnabled = true;
            this.cbbPaisOrigen.Location = new System.Drawing.Point(216, 130);
            this.cbbPaisOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPaisOrigen.Name = "cbbPaisOrigen";
            this.cbbPaisOrigen.Size = new System.Drawing.Size(218, 45);
            this.cbbPaisOrigen.TabIndex = 21;
            this.cbbPaisOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbPaisOrigen_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 37);
            this.label8.TabIndex = 22;
            this.label8.Text = "Estado de origen:";
            // 
            // cbbEstadoOrigen
            // 
            this.cbbEstadoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstadoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoOrigen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstadoOrigen.FormattingEnabled = true;
            this.cbbEstadoOrigen.Location = new System.Drawing.Point(247, 182);
            this.cbbEstadoOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstadoOrigen.Name = "cbbEstadoOrigen";
            this.cbbEstadoOrigen.Size = new System.Drawing.Size(217, 45);
            this.cbbEstadoOrigen.TabIndex = 23;
            this.cbbEstadoOrigen.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoOrigen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(563, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Estado de destino:";
            // 
            // cbbEstadoDestino
            // 
            this.cbbEstadoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstadoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstadoDestino.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstadoDestino.FormattingEnabled = true;
            this.cbbEstadoDestino.Location = new System.Drawing.Point(823, 180);
            this.cbbEstadoDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstadoDestino.Name = "cbbEstadoDestino";
            this.cbbEstadoDestino.Size = new System.Drawing.Size(195, 45);
            this.cbbEstadoDestino.TabIndex = 33;
            this.cbbEstadoDestino.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoDestino_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(563, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pais de destino:";
            // 
            // cbbPaisDestino
            // 
            this.cbbPaisDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbPaisDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPaisDestino.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPaisDestino.FormattingEnabled = true;
            this.cbbPaisDestino.Location = new System.Drawing.Point(794, 128);
            this.cbbPaisDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPaisDestino.Name = "cbbPaisDestino";
            this.cbbPaisDestino.Size = new System.Drawing.Size(195, 45);
            this.cbbPaisDestino.TabIndex = 31;
            this.cbbPaisDestino.SelectedIndexChanged += new System.EventHandler(this.cbbPaisDestino_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(563, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 37);
            this.label9.TabIndex = 27;
            this.label9.Text = "Aeropuerto de destino:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(563, 237);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 37);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ciudad de destino:";
            // 
            // cbbAerDestino
            // 
            this.cbbAerDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbAerDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbAerDestino.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAerDestino.FormattingEnabled = true;
            this.cbbAerDestino.Location = new System.Drawing.Point(879, 282);
            this.cbbAerDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbbAerDestino.Name = "cbbAerDestino";
            this.cbbAerDestino.Size = new System.Drawing.Size(176, 45);
            this.cbbAerDestino.TabIndex = 28;
            // 
            // cbbCiudadDestino
            // 
            this.cbbCiudadDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCiudadDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCiudadDestino.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCiudadDestino.FormattingEnabled = true;
            this.cbbCiudadDestino.Location = new System.Drawing.Point(835, 232);
            this.cbbCiudadDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCiudadDestino.Name = "cbbCiudadDestino";
            this.cbbCiudadDestino.Size = new System.Drawing.Size(195, 45);
            this.cbbCiudadDestino.TabIndex = 29;
            this.cbbCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.cbbCiudadDestino_SelectedIndexChanged);
            // 
            // cbbEstado
            // 
            this.cbbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbbEstado.Location = new System.Drawing.Point(247, 342);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(169, 45);
            this.cbbEstado.TabIndex = 34;
            // 
            // btnVerRutas
            // 
            this.btnVerRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVerRutas.FlatAppearance.BorderSize = 0;
            this.btnVerRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerRutas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRutas.ForeColor = System.Drawing.Color.White;
            this.btnVerRutas.Location = new System.Drawing.Point(704, 325);
            this.btnVerRutas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerRutas.Name = "btnVerRutas";
            this.btnVerRutas.Size = new System.Drawing.Size(176, 54);
            this.btnVerRutas.TabIndex = 35;
            this.btnVerRutas.Text = "Ver rutas";
            this.btnVerRutas.UseVisualStyleBackColor = false;
            this.btnVerRutas.Click += new System.EventHandler(this.btnVerRutas_Click);
            // 
            // FormCrearRuta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 392);
            this.Controls.Add(this.btnVerRutas);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbEstadoDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbPaisDestino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbAerDestino);
            this.Controls.Add(this.cbbCiudadDestino);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbEstadoOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbPaisOrigen);
            this.Controls.Add(this.btnAgragarCiudad);
            this.Controls.Add(this.btnCrearRuta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbAerOrigen);
            this.Controls.Add(this.cbbCiudadOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCrearRuta";
            this.Text = "crearRuta";
            this.Load += new System.EventHandler(this.FormCrearRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrearRuta;
        private System.Windows.Forms.Button btnAgragarCiudad;
        private System.Windows.Forms.ComboBox cbbAerOrigen;
        private System.Windows.Forms.ComboBox cbbCiudadOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPaisOrigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbEstadoOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbEstadoDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbPaisDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbAerDestino;
        private System.Windows.Forms.ComboBox cbbCiudadDestino;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Button btnVerRutas;
    }
}