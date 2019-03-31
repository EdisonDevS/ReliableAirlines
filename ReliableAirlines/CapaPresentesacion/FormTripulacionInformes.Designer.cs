namespace CapaPresentesacion
{
    partial class FormTripulacionInformes
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
            this.txtComentarios = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbAnormal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtVuelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtComentarios.Location = new System.Drawing.Point(16, 133);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(1074, 457);
            this.txtComentarios.TabIndex = 0;
            this.txtComentarios.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 30);
            this.label6.TabIndex = 63;
            this.label6.Text = "Número de vuelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "Calificaión:";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.rbNormal.ForeColor = System.Drawing.Color.White;
            this.rbNormal.Location = new System.Drawing.Point(193, 55);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(4);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(121, 34);
            this.rbNormal.TabIndex = 66;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbAnormal
            // 
            this.rbAnormal.AutoSize = true;
            this.rbAnormal.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.rbAnormal.ForeColor = System.Drawing.Color.White;
            this.rbAnormal.Location = new System.Drawing.Point(317, 55);
            this.rbAnormal.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnormal.Name = "rbAnormal";
            this.rbAnormal.Size = new System.Drawing.Size(135, 34);
            this.rbAnormal.TabIndex = 67;
            this.rbAnormal.TabStop = true;
            this.rbAnormal.Text = "Anormal";
            this.rbAnormal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "Comentarios:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(870, 598);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 74);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.Text = "Guardar informe";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtVuelo
            // 
            this.txtVuelo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtVuelo.Location = new System.Drawing.Point(248, 12);
            this.txtVuelo.Name = "txtVuelo";
            this.txtVuelo.Size = new System.Drawing.Size(357, 37);
            this.txtVuelo.TabIndex = 70;
            // 
            // FormTripulacionInformes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1103, 685);
            this.Controls.Add(this.txtVuelo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbAnormal);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComentarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTripulacionInformes";
            this.Text = "FormTripulacionInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtComentarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbAnormal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtVuelo;
    }
}