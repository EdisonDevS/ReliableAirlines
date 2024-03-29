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
    public partial class FormContabilidadIngresosGenerar : Form
    {
        public FormContabilidadIngresosGenerar()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelGenerarIngreso.Controls.Count > 0)
                this.panelGenerarIngreso.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelGenerarIngreso.Controls.Add(hijo);
            this.panelGenerarIngreso.Tag = hijo;
            hijo.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(23, 185, 120);
            btnExternos.BackColor = Color.FromArgb(44, 61, 79);
            abrirFormularioHijo(new FormContabilidadIngresosGenerarVentas());
        }
        private void btnExternos_Click(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(44, 61, 79);
            btnExternos.BackColor = Color.FromArgb(23, 185, 120);
            abrirFormularioHijo(new FormContabilidadGastosIngresosGenerarExternos(1));
        }

        private void panelGenerarIngreso_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
