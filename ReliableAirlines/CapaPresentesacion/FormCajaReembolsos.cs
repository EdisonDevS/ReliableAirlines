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
    public partial class FormCajaReembolsos : Form
    {
        CnSesion sesion = new CnSesion();
        CnVentas venta = new CnVentas();

        public FormCajaReembolsos(CnSesion usuario)
        {
            InitializeComponent();
            this.sesion = usuario;
            dtpHoraSalida.CustomFormat = "HH:mm";
            dtpHoraLlegada.CustomFormat = "HH:mm";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();

            datos = venta.obtenerInfoVentaReembolso(Int32.Parse(txtReserva.Text));

            lblNombres.Text = "Nombres: ";
            lblApellidos.Text = "Apellidos: ";
            lblIdentificación.Text = "Identificación";
            lblOrigen.Text = "Origen";
            lblDestino.Text = "Destino";

            lblNombres.Text += datos.Rows[0][0].ToString();
            lblApellidos.Text += datos.Rows[0][1].ToString();
            lblIdentificación.Text += datos.Rows[0][2].ToString();
            dtpSalida.Text = datos.Rows[0][3].ToString();
            dtpLlegada.Text = datos.Rows[0][4].ToString();
            lblOrigen.Text += datos.Rows[0][5].ToString();
            lblDestino.Text += datos.Rows[0][6].ToString();

            if (datos.Rows[0][7].ToString() == "1")
            {
                lblClase.Text += "Primera clase";
                lblValor.Text += datos.Rows[0][9].ToString();
            }
            else
            {
                lblClase.Text += "Clase turista";
                lblValor.Text += datos.Rows[0][8].ToString();
            }

        }

        private void btnGenerarGasto_Click(object sender, EventArgs e)
        {
            try
            {
                venta.gererarReembolso(sesion.documento, txtJustificacion.Text, Int32.Parse(txtReserva.Text));
                MessageBox.Show("Reembolso autorizado correctamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error generando el reembolso");
            }
        }
    }
}
