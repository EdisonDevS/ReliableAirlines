using System;
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
    public partial class FormClientesReservasReservar : Form
    {
        CnLocaciones locaciones = new CnLocaciones();
        CnVuelos Vuelo = new CnVuelos();
        CnSesion sesion;
        public FormClientesReservasReservar(CnSesion datos)
        {
            this.sesion = datos;
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            dgvVuelos.DataSource = Vuelo.CargarVuelosFecha(dtpSalida.Text, Convert.ToInt32(cbbAerOrigen.SelectedValue),
                Convert.ToInt32(cbbAerDes.SelectedValue));
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            CnAdministracionUsuarios usuario = new CnAdministracionUsuarios();

            try
            {
                CnVentas venta = new CnVentas();
                if (dgvVuelos.SelectedRows.Count == 1)
                {
                    int clase = 2;
                    if (rbCturista.Checked == false)
                    {
                        clase = 1;
                    }

                    venta.nuevoTiquete(sesion.documento, 1, Convert.ToInt32(dgvVuelos.CurrentRow.Cells[0].Value.ToString()), clase);

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un vuelo de la lista");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error intentando hacer la operación" + ex);
            }

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
    }
}
