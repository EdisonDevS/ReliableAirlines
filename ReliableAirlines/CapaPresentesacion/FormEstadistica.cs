﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentesacion
{
    public partial class FormEstadistica : Form
    {
        public FormEstadistica()
        {
            InitializeComponent();
        }
        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelEleccionEstadistica.Controls.Count > 0)
                this.panelEleccionEstadistica.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelEleccionEstadistica.Controls.Add(hijo);
            this.panelEleccionEstadistica.Tag = hijo;
            hijo.Show();
        }
        private void btnAfluencia_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormEstadisticaAfluencia());
        }
    }
}
