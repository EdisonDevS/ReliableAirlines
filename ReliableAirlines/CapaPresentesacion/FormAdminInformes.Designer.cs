namespace CapaPresentesacion
{
    partial class FormAdminInformes
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
            this.btnInformeEmpleado = new System.Windows.Forms.Button();
            this.btnInformeVuelos = new System.Windows.Forms.Button();
            this.panelInformes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnInformeEmpleado
            // 
            this.btnInformeEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnInformeEmpleado.FlatAppearance.BorderSize = 0;
            this.btnInformeEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInformeEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnInformeEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnInformeEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformeEmpleado.Name = "btnInformeEmpleado";
            this.btnInformeEmpleado.Size = new System.Drawing.Size(539, 50);
            this.btnInformeEmpleado.TabIndex = 16;
            this.btnInformeEmpleado.Text = "Informes de empleados";
            this.btnInformeEmpleado.UseVisualStyleBackColor = false;
            this.btnInformeEmpleado.Click += new System.EventHandler(this.btnInformeEmpleado_Click);
            // 
            // btnInformeVuelos
            // 
            this.btnInformeVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnInformeVuelos.FlatAppearance.BorderSize = 0;
            this.btnInformeVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInformeVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeVuelos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeVuelos.ForeColor = System.Drawing.Color.White;
            this.btnInformeVuelos.Location = new System.Drawing.Point(539, 0);
            this.btnInformeVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformeVuelos.Name = "btnInformeVuelos";
            this.btnInformeVuelos.Size = new System.Drawing.Size(538, 50);
            this.btnInformeVuelos.TabIndex = 15;
            this.btnInformeVuelos.Text = "Informes de vuelos";
            this.btnInformeVuelos.UseVisualStyleBackColor = false;
            this.btnInformeVuelos.Click += new System.EventHandler(this.btnInformeVuelos_Click);
            // 
            // panelInformes
            // 
            this.panelInformes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInformes.Location = new System.Drawing.Point(0, 54);
            this.panelInformes.Margin = new System.Windows.Forms.Padding(4);
            this.panelInformes.Name = "panelInformes";
            this.panelInformes.Size = new System.Drawing.Size(1077, 386);
            this.panelInformes.TabIndex = 14;
            // 
            // FormAdminInformes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 440);
            this.Controls.Add(this.btnInformeVuelos);
            this.Controls.Add(this.btnInformeEmpleado);
            this.Controls.Add(this.panelInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminInformes";
            this.Text = "FormAdminInformes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInformeEmpleado;
        private System.Windows.Forms.Button btnInformeVuelos;
        private System.Windows.Forms.Panel panelInformes;
    }
}