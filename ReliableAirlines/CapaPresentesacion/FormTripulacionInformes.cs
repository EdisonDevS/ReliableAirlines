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
    public partial class FormTripulacionInformes : Form
    {
        CnRegistros registro = new CnRegistros();
        CnSesion sesion = new CnSesion();
        public FormTripulacionInformes(CnSesion usuario)
        {
            InitializeComponent();
            this.sesion = usuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtComentarios.Text) || string.IsNullOrWhiteSpace(txtVuelo.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                string calificacion = "";

                if (rbNormal.Checked)
                    calificacion = "Normal";
                else
                    calificacion = "Anormal";

                try
                {
                    registro.generarRegistroTripulacion(Int32.Parse(txtVuelo.Text), calificacion, txtComentarios.Text, sesion.documento);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error durante el guardado del registro");
                }
            }
            
        }
    }
}
