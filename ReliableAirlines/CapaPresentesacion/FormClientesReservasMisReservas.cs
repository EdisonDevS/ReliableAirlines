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

namespace CapaPresentesacion
{
    public partial class FormClientesReservasMisReservas : Form
    {
        CnVuelos vuelos = new CnVuelos();
        CnVentas tiquete = new CnVentas();
        CnSesion sesion;
        public FormClientesReservasMisReservas(CnSesion infoUsuario)
        {
            this.sesion = infoUsuario;
            InitializeComponent();
            this.dgvVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable datos = new DataTable();
            datos = vuelos.ConsultaVuelosPendientes(sesion.documento);
            dgvVuelos.DataSource = datos;
            reemplazarEstados();
        }

        public void reemplazarEstados()
        {
            foreach(DataGridViewRow fila in dgvVuelos.Rows)
            {
                
                switch(fila.Cells["Estado"].Value.ToString())
                {
                    case "1":
                        fila.Cells["Estado"].Value = "Sin pagar";
                        break;
                    case "2":
                        fila.Cells["Estado"].Value = "Pagado";
                        break;
                    case "3":
                        fila.Cells["Estado"].Value = "En vuelo";
                        break;
                    case "4":
                        fila.Cells["Estado"].Value = "Cancelado";
                        break;
                    case "5":
                        fila.Cells["Estado"].Value = "No pagado";
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int vuelo = Int32.Parse(dgvVuelos.CurrentRow.Cells[0].Value.ToString());
            tiquete.cancelacionDeTiquete(sesion.documento, vuelo);
        }

        private void btnVerTiquete_Click(object sender, EventArgs e)
        {
            if(dgvVuelos.CurrentRow.Cells["Estado"].Value.ToString()=="Pagado")
            {
                DataTable ciudades = new DataTable();
                ciudades = vuelos.buscarCiudadesTiquete(Int32.Parse(dgvVuelos.CurrentRow.Cells[6].Value.ToString()));
                DatosTiquete datos = new DatosTiquete();

                datos.ID = dgvVuelos.CurrentRow.Cells[6].Value.ToString();
                datos.Salida = dgvVuelos.CurrentRow.Cells[3].Value.ToString();
                datos.Llegada = dgvVuelos.CurrentRow.Cells[4].Value.ToString();
                datos.Nombre = ciudades.Rows[0][3].ToString() + " " + ciudades.Rows[0][4].ToString();
                datos.Origen = ciudades.Rows[0][0].ToString();
                datos.Destino = ciudades.Rows[0][1].ToString();
                datos.Documento = sesion.documento;
                datos.Vuelo = dgvVuelos.CurrentRow.Cells[0].Value.ToString();

                if (Int32.Parse(ciudades.Rows[0][2].ToString()) == 1)
                    datos.Clase = "Primera";
                else
                    datos.Clase = "Turista";

                FormReporteTiquetes reporte = new FormReporteTiquetes();
                reporte.Tiquete.Add(datos);
                reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha generado un tiquete para este vuelo\nVerifique que el tiquete haya sido pagado");
            }
            
        }
    }
}
