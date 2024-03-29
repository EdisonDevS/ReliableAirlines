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
    public partial class FormContabilidadContactos : Form
    {
        public FormContabilidadContactos()
        {
            InitializeComponent();
        }

        private void btnCrearContacto_Click(object sender, EventArgs e)
        {
            FormContabilidadContactosCrear crear = new FormContabilidadContactosCrear();
            crear.Show();
        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            FormContabilidadContactosModificar modificar = new FormContabilidadContactosModificar();
            modificar.Show();
        }
    }
}
