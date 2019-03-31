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
using System.Data;
using System.Globalization;

namespace CapaPresentesacion
{
    public partial class FormAdminVuelosConsulta : Form
    {

        CnLocaciones locaciones = new CnLocaciones();
        CnVuelos vuelo = new CnVuelos();
        CultureInfo cop = new CultureInfo("es-CO");

        public void corregirDvg()
        {
            foreach (DataGridViewRow fila in dgvVuelos.Rows)
            {
                fila.Cells[8].Value = Int32.Parse(fila.Cells[8].Value.ToString()).ToString("c", cop);
                fila.Cells[9].Value = Int32.Parse(fila.Cells[9].Value.ToString()).ToString("c", cop);
            }
        }
        public FormAdminVuelosConsulta()
        {
            InitializeComponent();
            rbNumeroVuelo.Checked = true;
            this.dgvVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable numerosDeVuelo = new DataTable();
            numerosDeVuelo = vuelo.consultaNumerosDeVuelo();
            cbbNumVuelo.DataSource = numerosDeVuelo;
            cbbNumVuelo.ValueMember = "numVuelo";
            cbbNumVuelo.DisplayMember = "numVuelo";
        }

        private void rbNumeroVuelo_CheckedChanged(object sender, EventArgs e)
        {
            cbbNumVuelo.Enabled = true;
            cbbPaisOrigen.Enabled = false;
            cbbPaisDestino.Enabled = false;
            cbbEstadoOrigen.Enabled = false;
            cbbEstadoDestino.Enabled = false;
            cbbCiudadOrigen.Enabled = false;
            cbbCiudadDestino.Enabled = false;
            cbbAerOrigen.Enabled = false;
            cbbAerDestino.Enabled = false;
            btnVer.Enabled = true;
        }

        private void rbRuta_CheckedChanged(object sender, EventArgs e)
        {
            cbbNumVuelo.Enabled = false;
            btnVer.Enabled = false;

            cbbPaisOrigen.Enabled = true;
            cbbPaisDestino.Enabled = true;
            cbbEstadoOrigen.Enabled = true;
            cbbEstadoDestino.Enabled = true;
            cbbCiudadOrigen.Enabled = true;
            cbbCiudadDestino.Enabled = true;
            cbbAerOrigen.Enabled = true;
            cbbAerDestino.Enabled = true;

            DataTable tablaPaisOrigen = new DataTable();
            tablaPaisOrigen = locaciones.ConsultarPaises();
            cbbPaisOrigen.DataSource = tablaPaisOrigen;
            cbbPaisOrigen.DisplayMember = "nombre";
            cbbPaisOrigen.ValueMember = "id";

            DataTable tablaPaisDestino = new DataTable();
            tablaPaisDestino = locaciones.ConsultarPaises();
            cbbPaisDestino.DataSource = tablaPaisDestino;
            cbbPaisDestino.DisplayMember = "nombre";
            cbbPaisDestino.ValueMember = "id";
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

        private void cbbPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaEstDestino = new DataTable();
                tablaEstDestino = locaciones.ConsultarEstados(Convert.ToInt32(cbbPaisDestino.SelectedValue));
                cbbEstadoDestino.DataSource = tablaEstDestino;
                cbbEstadoDestino.DisplayMember = "nombre";
                cbbEstadoDestino.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbEstadoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaCiuDestino = new DataTable();
                tablaCiuDestino = locaciones.ConsultarCiudades(Convert.ToInt32(cbbEstadoDestino.SelectedValue));
                cbbCiudadDestino.DataSource = tablaCiuDestino;
                cbbCiudadDestino.DisplayMember = "nombre";
                cbbCiudadDestino.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbCiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaAerDestino = new DataTable();
                tablaAerDestino = locaciones.ConsultarAeropuertos(Convert.ToInt32(cbbCiudadDestino.SelectedValue));
                cbbAerDestino.DataSource = tablaAerDestino;
                cbbAerDestino.DisplayMember = "nombre";
                cbbAerDestino.ValueMember = "idAeropuerto";
            }
            catch (Exception)
            {

            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbbNumVuelo.Text))
            {
                MessageBox.Show("Por favor digite el numero de vuelo");
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = vuelo.CargarDatos(Convert.ToInt32(cbbNumVuelo.Text));
                tabla.Columns[0].ColumnName = "Número de vuelo";
                tabla.Columns[1].ColumnName = "Origen";
                tabla.Columns[2].ColumnName = "Destino";
                tabla.Columns[3].ColumnName = "Aeronave";
                tabla.Columns[4].ColumnName = "Puestos primera clase";
                tabla.Columns[5].ColumnName = "Puestos clase turista";
                tabla.Columns[6].ColumnName = "Salida";
                tabla.Columns[7].ColumnName = "Llegada";
                tabla.Columns[8].ColumnName = "Valor primera clase";
                tabla.Columns[9].ColumnName = "Valor clase turista";
                dgvVuelos.DataSource = tabla;

                corregirDvg();
            }
            
        }

        private void cbbAerOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = vuelo.CargarDatosPorAeropuerto(Convert.ToInt32(cbbAerOrigen.SelectedValue), 
                                                        Convert.ToInt32(cbbAerDestino.SelectedValue));
                tabla.Columns[0].ColumnName = "Número de vuelo";
                tabla.Columns[1].ColumnName = "Origen";
                tabla.Columns[2].ColumnName = "Destino";
                tabla.Columns[3].ColumnName = "Aeronave";
                tabla.Columns[4].ColumnName = "Puestos primera clase";
                tabla.Columns[5].ColumnName = "Puestos clase turista";
                tabla.Columns[6].ColumnName = "Salida";
                tabla.Columns[7].ColumnName = "Llegada";
                tabla.Columns[8].ColumnName = "Valor primera clase";
                tabla.Columns[9].ColumnName = "Valor clase turista";
                dgvVuelos.DataSource = tabla;

                
            }
            catch (Exception ex)
            {

            }

        }

        private void cbbAerDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = vuelo.CargarDatosPorAeropuerto(Convert.ToInt32(cbbAerOrigen.SelectedValue),
                                                        Convert.ToInt32(cbbAerDestino.SelectedValue));
                tabla.Columns[0].ColumnName = "Número de vuelo";
                tabla.Columns[1].ColumnName = "Origen";
                tabla.Columns[2].ColumnName = "Destino";
                tabla.Columns[3].ColumnName = "Aeronave";
                tabla.Columns[4].ColumnName = "Puestos primera clase";
                tabla.Columns[5].ColumnName = "Puestos clase turista";
                tabla.Columns[6].ColumnName = "Salida";
                tabla.Columns[7].ColumnName = "Llegada";
                tabla.Columns[8].ColumnName = "Valor primera clase";
                tabla.Columns[9].ColumnName = "Valor clase turista";
                dgvVuelos.DataSource = tabla;


            }
            catch (Exception ex)
            {
                
            }
        }

        private void FormAdminVuelosConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
