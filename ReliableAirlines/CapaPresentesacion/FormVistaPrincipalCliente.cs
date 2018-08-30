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
    public partial class FormVistaPrincipalCliente : Form
    {
        public FormVistaPrincipalCliente()
        {
            InitializeComponent();
        }
        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(hijo);
            this.panelContainer.Tag = hijo;
            hijo.Show();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            btnReservas.BackColor = Color.FromArgb(23, 185, 120);
            btnBuzon.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnBuzon_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzon());
            btnReservas.BackColor = Color.FromArgb(44, 61, 79);
            btnBuzon.BackColor = Color.FromArgb(23, 185, 120);
            btnMiCuenta.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormMiCuenta());
            btnReservas.BackColor = Color.FromArgb(44, 61, 79);
            btnBuzon.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(23, 185, 120);
        }
    }
}
