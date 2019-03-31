namespace CapaPresentesacion
{
    partial class FormAdminVuelosGestion
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
            this.btnNuevoVuelo = new System.Windows.Forms.Button();
            this.btnVueloExistente = new System.Windows.Forms.Button();
            this.panelAdminVuelo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNuevoVuelo
            // 
            this.btnNuevoVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnNuevoVuelo.FlatAppearance.BorderSize = 0;
            this.btnNuevoVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoVuelo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVuelo.ForeColor = System.Drawing.Color.White;
            this.btnNuevoVuelo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoVuelo.Name = "btnNuevoVuelo";
            this.btnNuevoVuelo.Size = new System.Drawing.Size(667, 43);
            this.btnNuevoVuelo.TabIndex = 0;
            this.btnNuevoVuelo.Text = "Nuevo vuelo";
            this.btnNuevoVuelo.UseVisualStyleBackColor = false;
            this.btnNuevoVuelo.Click += new System.EventHandler(this.btnNuevoVuelo_Click);
            // 
            // btnVueloExistente
            // 
            this.btnVueloExistente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            this.btnVueloExistente.FlatAppearance.BorderSize = 0;
            this.btnVueloExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVueloExistente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVueloExistente.ForeColor = System.Drawing.Color.White;
            this.btnVueloExistente.Location = new System.Drawing.Point(645, 0);
            this.btnVueloExistente.Margin = new System.Windows.Forms.Padding(4);
            this.btnVueloExistente.Name = "btnVueloExistente";
            this.btnVueloExistente.Size = new System.Drawing.Size(667, 43);
            this.btnVueloExistente.TabIndex = 1;
            this.btnVueloExistente.Text = "Vuelo existente";
            this.btnVueloExistente.UseVisualStyleBackColor = false;
            this.btnVueloExistente.Click += new System.EventHandler(this.btnVueloExistente_Click);
            // 
            // panelAdminVuelo
            // 
            this.panelAdminVuelo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdminVuelo.Location = new System.Drawing.Point(0, 43);
            this.panelAdminVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.panelAdminVuelo.Name = "panelAdminVuelo";
            this.panelAdminVuelo.Size = new System.Drawing.Size(1312, 678);
            this.panelAdminVuelo.TabIndex = 2;
            // 
            // FormAdminVuelosGestion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 721);
            this.Controls.Add(this.panelAdminVuelo);
            this.Controls.Add(this.btnVueloExistente);
            this.Controls.Add(this.btnNuevoVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminVuelosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administracionVuelos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoVuelo;
        private System.Windows.Forms.Button btnVueloExistente;
        private System.Windows.Forms.Panel panelAdminVuelo;
    }
}