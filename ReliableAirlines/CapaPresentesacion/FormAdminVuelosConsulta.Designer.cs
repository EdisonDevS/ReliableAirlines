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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumVuelo = new System.Windows.Forms.TextBox();
            this.txtIDSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.rbRuta = new System.Windows.Forms.RadioButton();
            this.rbNumeroVuelo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // txtIDSalida
            // 
            this.txtIDSalida.Enabled = false;
            this.txtIDSalida.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtIDSalida.Location = new System.Drawing.Point(247, 110);
            this.txtIDSalida.Name = "txtIDSalida";
            this.txtIDSalida.Size = new System.Drawing.Size(162, 31);
            this.txtIDSalida.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Aeropuerto de salida:";
            // 
            // txtIDDestino
            // 
            this.txtIDDestino.Enabled = false;
            this.txtIDDestino.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtIDDestino.Location = new System.Drawing.Point(790, 113);
            this.txtIDDestino.Name = "txtIDDestino";
            this.txtIDDestino.Size = new System.Drawing.Size(162, 31);
            this.txtIDDestino.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(539, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Aeropuerto de destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ciudad de salida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(539, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ciudad de destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Capacidad actual primera clase:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(539, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Capacidad actual clase turista:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 31);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "Salida:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(223, 284);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 31);
            this.dateTimePicker2.TabIndex = 49;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(767, 284);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(151, 31);
            this.dateTimePicker3.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(539, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 51;
            this.label9.Text = "Llegada:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(632, 284);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(129, 31);
            this.dateTimePicker4.TabIndex = 50;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(13, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(237, 24);
            this.label25.TabIndex = 53;
            this.label25.Text = "Modelo de aeronave:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 24);
            this.label10.TabIndex = 54;
            this.label10.Text = "Valor primera clase:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(539, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "Valor clase turista:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Tripulación:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 227);
            this.dataGridView1.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(539, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(335, 24);
            this.label13.TabIndex = 59;
            this.label13.Text = "Capacidad de equipaje actual:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 1);
            this.panel1.TabIndex = 42;
            // 
            // FormAdminVuelosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.rbNumeroVuelo);
            this.Controls.Add(this.rbRuta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIDDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumVuelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdminVuelosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultarVuelo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumVuelo;
        private System.Windows.Forms.TextBox txtIDSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbRuta;
        private System.Windows.Forms.RadioButton rbNumeroVuelo;
        private System.Windows.Forms.Panel panel1;
    }
}