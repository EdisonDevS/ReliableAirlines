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
    public partial class FormEstadisticaAfluenciaGrafica : Form
    {
        CnRutas ruta = new CnRutas();
        public FormEstadisticaAfluenciaGrafica()
        {
            InitializeComponent();

            DataTable rutas = new DataTable();
            rutas = ruta.ConsultaGralRutas();
            cbbNombreRuta.DataSource = rutas;
            cbbNombreRuta.DisplayMember = "Nombre Ruta";
            cbbNombreRuta.ValueMember = "ID Ruta";
        }

        string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

        private void cargarGrafico()
        {
            graAfluencia.Series.Clear();
            graAfluencia.Series.Add("Personas");
            graAfluencia.Series["Personas"].IsValueShownAsLabel = true;
            CnRutas rutas = new CnRutas();
            for (int i = 0; i < 12; i++)
            {
                graAfluencia.Series["Personas"].Points.AddXY(meses[i], rutas.consultaSumaPasajerosMes(i + 1, txtAño.Text, Int32.Parse(cbbNombreRuta.SelectedValue.ToString())));
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAño.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                cargarGrafico();
            }
        }
    }
}
