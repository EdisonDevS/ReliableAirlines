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
    public partial class FormEstadisticaCiudadGrafica : Form
    {
        public FormEstadisticaCiudadGrafica()
        {
            InitializeComponent();

            DataTable ciudades = new DataTable();
            CnAdministracionUsuarios cargar = new CnAdministracionUsuarios();
            ciudades = cargar.CargarCiudades();
            cbbCiudades.DataSource = ciudades;
            cbbCiudades.ValueMember = "id";
            cbbCiudades.DisplayMember = "nombre";
        }

        string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
        private void cargarGrafico()
        {
            graCiudades.Series.Clear();
            graCiudades.Series.Add("Pasajeros Salientes");
            graCiudades.Series["Pasajeros Salientes"].IsValueShownAsLabel = true;
            graCiudades.Series.Add("Pasajeros Entrantes");
            graCiudades.Series["Pasajeros Entrantes"].IsValueShownAsLabel = true;
            CnLocaciones ciudad = new CnLocaciones();
            for (int i = 0; i < 12; i++)
            {
                graCiudades.Series["Pasajeros Salientes"].Points.AddXY(meses[i], ciudad.consultaPasajerosSalientes(i + 1, txtAño.Text, Int32.Parse(cbbCiudades.SelectedValue.ToString())));
                graCiudades.Series["Pasajeros Entrantes"].Points.AddXY(meses[i], ciudad.consultaPasajerosEntrantes(i + 1, txtAño.Text, Int32.Parse(cbbCiudades.SelectedValue.ToString())));
            }
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            cargarGrafico();
        }
    }
}
