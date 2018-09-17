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
    public partial class FormAdminVuelosGestionExistente : Form
    {

        CnRutas ruta = new CnRutas();
        CnAeronaves aer = new CnAeronaves();
        public FormAdminVuelosGestionExistente()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            CnVuelos vuelo = new CnVuelos();
            DataTable datosPrimarios = new DataTable();
            datosPrimarios = vuelo.CargarDatos(Convert.ToInt32(txtNumVuelo.Text));

            DataTable rutas = new DataTable();
            rutas = ruta.ConsultaGralRutas();
            cbbNombreRuta.DataSource = rutas;
            cbbNombreRuta.DisplayMember = "Nombre Ruta";
            cbbNombreRuta.ValueMember = "ID Ruta";

            DataTable aeronave = new DataTable();
            aeronave = aer.ConsultarMatriculas();
            cbbMatriculaAeronave.DataSource = aeronave;
            cbbMatriculaAeronave.DisplayMember = "idAeronave";

            cbbNombreRuta.Text = datosPrimarios.Rows[0][10].ToString();
            cbbMatriculaAeronave.Text = datosPrimarios.Rows[0][2].ToString();
            
            
        }

        private void cbbNombreRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable cargar = new DataTable();
                cargar = ruta.ConsultaEspecificaRutas(Convert.ToInt32(cbbNombreRuta.SelectedValue));
                lblCiuOri.Text = cargar.Rows[0][3].ToString();
                lblCiuDes.Text = cargar.Rows[0][5].ToString();
                lblAerOri.Text = cargar.Rows[0][2].ToString();
                lblAerDes.Text = cargar.Rows[0][4].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void cbbMatriculaAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable cargar = new DataTable();
                cargar = aer.ConsultaPorMatricula(cbbMatriculaAeronave.Text);
                lblCapPclas.Text = cargar.Rows[0][2].ToString();
                lblCapCtur.Text = cargar.Rows[0][3].ToString();
                lblTipoAer.Text = cargar.Rows[0][1].ToString();
                lblEstAct.Text = cargar.Rows[0][7].ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
