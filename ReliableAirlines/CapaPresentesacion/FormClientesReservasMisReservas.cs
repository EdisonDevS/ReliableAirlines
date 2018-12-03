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

        }
    }
}
