﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegociacion;

namespace CapaPresentesacion
{
    public partial class FormAdminAeronavesAeronave : Form
    {
        CnAeronaves aeronaves = new CnAeronaves();
        public FormAdminAeronavesAeronave()
        {
            InitializeComponent();
            cbbMatricula.DataSource = aeronaves.ConsultarMatriculas();
            cbbMatricula.DisplayMember = "idAeronave";
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCturista.Text) || string.IsNullOrWhiteSpace(txtEqui.Text) || string.IsNullOrWhiteSpace(txtPclase.Text) || 
                string.IsNullOrWhiteSpace(txtProv.Text) || string.IsNullOrWhiteSpace(txtTipo.Text) || string.IsNullOrWhiteSpace(cbbEstadoActual.Text) || 
                string.IsNullOrWhiteSpace(cbbMatricula.Text))
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
            else
            {
                aeronaves.ActualizarDatos(cbbMatricula.Text, txtTipo.Text, Convert.ToInt32(txtPclase.Text), Convert.ToInt32(txtCturista.Text),
                                      txtProv.Text, Convert.ToInt32(txtEqui.Text), dtpAdqui.Text, cbbEstadoActual.Text);
                MessageBox.Show("Se han guardado los cambios correctamente");
            }
            
        }

        private void cbbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable datos = new DataTable();
                datos = aeronaves.ConsultaPorMatricula(cbbMatricula.Text);
                txtTipo.Text = datos.Rows[0][1].ToString();
                txtProv.Text = datos.Rows[0][4].ToString();
                txtPclase.Text = datos.Rows[0][2].ToString();
                txtCturista.Text = datos.Rows[0][3].ToString();
                txtEqui.Text = datos.Rows[0][5].ToString();
                dtpAdqui.Text = datos.Rows[0][6].ToString();
                cbbEstadoActual.Text = datos.Rows[0][7].ToString();

                txtTipo.Enabled = true;
                txtProv.Enabled = true;
                txtPclase.Enabled = true;
                txtCturista.Enabled = true;
                txtEqui.Enabled = true;
                dtpAdqui.Enabled = true;
                btnGuardarCambios.Enabled = true;
                cbbEstadoActual.Enabled = true;
            }
            catch(Exception)
            {

            }
        }
    }
}
