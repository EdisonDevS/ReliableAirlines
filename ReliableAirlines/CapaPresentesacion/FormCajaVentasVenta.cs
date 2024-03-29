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
    public partial class FormCajaVentasVenta : Form
    {
        CnLocaciones locaciones = new CnLocaciones();
        CnVuelos Vuelo = new CnVuelos();
        public FormCajaVentasVenta()
        {
            InitializeComponent();
            this.dgvVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            

            DataTable tablaPaisOrigen = new DataTable();
            tablaPaisOrigen = locaciones.ConsultarPaises();
            cbbPaisOrigen.DataSource = tablaPaisOrigen;
            cbbPaisOrigen.DisplayMember = "nombre";
            cbbPaisOrigen.ValueMember = "id";

            DataTable tablaPaisDestino = new DataTable();
            tablaPaisDestino = locaciones.ConsultarPaises();
            cbbPaisDes.DataSource = tablaPaisDestino;
            cbbPaisDes.DisplayMember = "nombre";
            cbbPaisDes.ValueMember = "id";
        }

        private void FormCajaVentasVenta_Load(object sender, EventArgs e)
        {

        }

        private void cbbPaisOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaEstOrigen = new DataTable();
                tablaEstOrigen = locaciones.ConsultarEstados(Convert.ToInt32(cbbPaisOrigen.SelectedValue));
                cbbEstadoOrigen.DataSource = tablaEstOrigen;
                cbbEstadoOrigen.DisplayMember = "nombre";
                cbbEstadoOrigen.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbEstadoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaCiuOrigen = new DataTable();
                tablaCiuOrigen = locaciones.ConsultarCiudades(Convert.ToInt32(cbbEstadoOrigen.SelectedValue));
                cbbCiudadOrigen.DataSource = tablaCiuOrigen;
                cbbCiudadOrigen.DisplayMember = "nombre";
                cbbCiudadOrigen.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaAerOrigen = new DataTable();
                tablaAerOrigen = locaciones.ConsultarAeropuertos(Convert.ToInt32(cbbCiudadOrigen.SelectedValue));
                cbbAerOrigen.DataSource = tablaAerOrigen;
                cbbAerOrigen.DisplayMember = "nombre";
                cbbAerOrigen.ValueMember = "idAeropuerto";
            }
            catch (Exception)
            {

            }
        }

        private void cbbPaisDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaEstDestino = new DataTable();
                tablaEstDestino = locaciones.ConsultarEstados(Convert.ToInt32(cbbPaisDes.SelectedValue));
                cbbEstDes.DataSource = tablaEstDestino;
                cbbEstDes.DisplayMember = "nombre";
                cbbEstDes.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbEstDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaCiuDestino = new DataTable();
                tablaCiuDestino = locaciones.ConsultarCiudades(Convert.ToInt32(cbbEstDes.SelectedValue));
                cbbCiuDes.DataSource = tablaCiuDestino;
                cbbCiuDes.DisplayMember = "nombre";
                cbbCiuDes.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbCiuDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaAerDestino = new DataTable();
                tablaAerDestino = locaciones.ConsultarAeropuertos(Convert.ToInt32(cbbCiuDes.SelectedValue));
                cbbAerDes.DataSource = tablaAerDestino;
                cbbAerDes.DisplayMember = "nombre";
                cbbAerDes.ValueMember = "idAeropuerto";
            }
            catch (Exception)
            {

            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dgvVuelos.DataSource = Vuelo.CargarVuelosFecha(dtpSalida.Text, Convert.ToInt32(cbbAerOrigen.SelectedValue),
                Convert.ToInt32(cbbAerDes.SelectedValue));

        }

        private void btnValidarUsuario_Click(object sender, EventArgs e)
        {
            CnAdministracionUsuarios usuario = new CnAdministracionUsuarios();
            DataTable usuarios = new DataTable();
            usuarios = usuario.validarUsuario(txtDocumento.Text);

            if (usuarios.Rows.Count > 0)
            {
                lblNombre.Text = lblNombre.Text + usuarios.Rows[0][5].ToString();
                lblApellido.Text = lblApellido.Text + usuarios.Rows[0][6].ToString();
            }
            else
            {
                FormRegistroCliente registro = new FormRegistroCliente();
                registro.Show();
            }
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            CnAdministracionUsuarios usuario = new CnAdministracionUsuarios();
            DataTable usuarios = new DataTable();
            usuarios = usuario.validarUsuario(txtDocumento.Text);

            if (usuarios.Rows.Count > 0)
            {
                int clase = 2;
                CnVentas venta = new CnVentas();
                try
                {
                    
                    
                    if (dgvVuelos.SelectedRows.Count == 1)
                    {
                        
                        if (rbCturista.Checked == false)
                        {
                            clase = 1;
                        }
                        
                        venta.nuevoTiquete(txtDocumento.Text, 2, Convert.ToInt32(dgvVuelos.CurrentRow.Cells[0].Value.ToString()), clase);

                        DatosTiquete tiquete = new DatosTiquete();
                        ReporteTiquetes reporteTiquete = new ReporteTiquetes();

                        if (clase == 1)
                            tiquete.Clase = "Primera";
                        else
                            tiquete.Clase = "Turista";

                        tiquete.Vuelo = dgvVuelos.CurrentRow.Cells[0].Value.ToString();
                        tiquete.ID = venta.consultaIDTiquete(Int32.Parse(tiquete.Vuelo), txtDocumento.Text).ToString();
                        tiquete.Origen = cbbCiudadOrigen.Text;
                        tiquete.Destino = cbbCiuDes.Text;
                        tiquete.Llegada = dgvVuelos.CurrentRow.Cells[4].Value.ToString();
                        tiquete.Salida = dgvVuelos.CurrentRow.Cells[3].Value.ToString();
                        tiquete.Nombre = usuarios.Rows[0][5].ToString() + " " + usuarios.Rows[0][6].ToString();
                        tiquete.Documento = txtDocumento.Text;

                        reporteTiquete.Tiquete.Add(tiquete);
                        reporteTiquete.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un vuelo de la lista");
                    }

                }
                catch (Exception ex)
                {
                    DatosTiquete tiquete = new DatosTiquete();
                    ReporteTiquetes reporteTiquete = new ReporteTiquetes();

                    if (clase == 1)
                        tiquete.Clase = "Primera";
                    else
                        tiquete.Clase = "Turista";

                    tiquete.Vuelo = dgvVuelos.CurrentRow.Cells[0].Value.ToString();
                    tiquete.ID = venta.consultaIDTiquete(Int32.Parse(tiquete.Vuelo), txtDocumento.Text).ToString();
                    tiquete.Origen = cbbCiudadOrigen.Text;
                    tiquete.Destino = cbbCiuDes.Text;
                    tiquete.Llegada = dgvVuelos.CurrentRow.Cells[4].Value.ToString();
                    tiquete.Salida = dgvVuelos.CurrentRow.Cells[3].Value.ToString();
                    tiquete.Nombre = usuarios.Rows[0][5].ToString() + " " + usuarios.Rows[0][6].ToString();
                    tiquete.Documento = txtDocumento.Text;

                    reporteTiquete.Tiquete.Add(tiquete);
                    reporteTiquete.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("El usuario debe de estar registrado primero! ");
            }
        }
    }
}
