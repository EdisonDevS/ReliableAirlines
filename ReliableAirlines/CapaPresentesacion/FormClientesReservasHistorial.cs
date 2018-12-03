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
    public partial class FormClientesReservasHistorial : Form
    {

        CnVuelos vuelo = new CnVuelos();
        CnSesion sesion;
        public FormClientesReservasHistorial(CnSesion infoUsuario)
        {
            this.sesion = infoUsuario;
            InitializeComponent();
            this.dgvVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVuelos.DataSource = vuelo.ConsultaHistorialVuelos(sesion.documento);
            reemplazarEstados();
        }

        public void reemplazarEstados()
        {
            foreach (DataGridViewRow fila in dgvVuelos.Rows)
            {

                switch (fila.Cells["Estado"].Value.ToString())
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
                    case "6":
                        fila.Cells["Estado"].Value = "Reembolsado";
                        break;
                    default:
                        break;
                }

            }
        }

        private void FormClientesReservasHistorial_Load(object sender, EventArgs e)
        {

        }

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
