namespace CapaPresentesacion
{
    partial class FormAdminNomina
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
            this.panelEleccionNomina = new System.Windows.Forms.Panel();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btnConultaNomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelEleccionNomina
            // 
            this.panelEleccionNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEleccionNomina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEleccionNomina.Location = new System.Drawing.Point(0, 24);
            this.panelEleccionNomina.Name = "panelEleccionNomina";
            this.panelEleccionNomina.Size = new System.Drawing.Size(497, 203);
            this.panelEleccionNomina.TabIndex = 0;
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnActualizarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnActualizarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(164, 27);
            this.btnActualizarEmpleado.TabIndex = 1;
            this.btnActualizarEmpleado.Text = "Actualizar datos";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnRegistrarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(158, 0);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(181, 27);
            this.btnRegistrarEmpleado.TabIndex = 2;
            this.btnRegistrarEmpleado.Text = "Registrar nuevo empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = false;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConultaNomina
            // 
            this.btnConultaNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnConultaNomina.FlatAppearance.BorderSize = 0;
            this.btnConultaNomina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConultaNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConultaNomina.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConultaNomina.ForeColor = System.Drawing.Color.White;
            this.btnConultaNomina.Location = new System.Drawing.Point(333, 0);
            this.btnConultaNomina.Name = "btnConultaNomina";
            this.btnConultaNomina.Size = new System.Drawing.Size(164, 27);
            this.btnConultaNomina.TabIndex = 3;
            this.btnConultaNomina.Text = "Consultar nómina";
            this.btnConultaNomina.UseVisualStyleBackColor = false;
            this.btnConultaNomina.Click += new System.EventHandler(this.btnConultaNomina_Click);
            // 
            // menuNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 227);
            this.Controls.Add(this.btnConultaNomina);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.panelEleccionNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuNomina";
            this.Text = "menuNomina";
            this.Load += new System.EventHandler(this.menuNomina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEleccionNomina;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Button btnConultaNomina;
    }
}