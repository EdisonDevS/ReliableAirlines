using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentesacion
{
    public partial class FormMenuNomina : Form
    {
        public FormMenuNomina()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelEleccionNomina.Controls.Count > 0)
                this.panelEleccionNomina.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelEleccionNomina.Controls.Add(hijo);
            this.panelEleccionNomina.Tag = hijo;
            hijo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormActualizacionEmpleado());
            btnActualizarEmpleado.BackColor = Color.FromArgb(23, 185, 120);
            btnRegistrarEmpleado.BackColor = Color.FromArgb(46, 61, 79);
            btnConultaNomina.BackColor = Color.FromArgb(46, 61, 79);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormRegistroEmpleado());
            btnActualizarEmpleado.BackColor = Color.FromArgb(46, 61, 79);
            btnRegistrarEmpleado.BackColor = Color.FromArgb(23, 185, 120);
            btnConultaNomina.BackColor = Color.FromArgb(46, 61, 79);
        }

        private void btnConultaNomina_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormConsultaNomina());
            btnActualizarEmpleado.BackColor = Color.FromArgb(46, 61, 79);
            btnRegistrarEmpleado.BackColor = Color.FromArgb(46, 61, 79);
            btnConultaNomina.BackColor = Color.FromArgb(23, 185, 120);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuNomina_Load(object sender, EventArgs e)
        {

        }

        
    }
}
