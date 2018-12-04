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
    public partial class FormContabilidadGastosGenerarNomina : Form
    {
        CnMovimientosFinancieros mov = new CnMovimientosFinancieros();
        DataTable datos = new DataTable();
        int totalPago = 0;
        public FormContabilidadGastosGenerarNomina()
        {
            InitializeComponent();
            this.dgvPagosPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable data = new DataTable();
            data = mov.consultarPagosPendientes();
            dgvPagosPendientes.DataSource = data;
        }

        private void btnPagoGeneral_Click(object sender, EventArgs e)
        {
            FormContabilidadGastosGenerarNominaGeneral generar = new FormContabilidadGastosGenerarNominaGeneral();
            generar.Show();
        }

        private void dgvPagosPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            lblNombre.Text = "Nombres: ";
            lblApellidos.Text = "Apellidos: ";
            lblDocumento.Text = "Documentos: ";
            lblNumeroContrato.Text = "Número de contrato: ";
            lblSueldo.Text = "Sueldo/Hora: ";
            datos = mov.consultarDatosPago(dgvPagosPendientes.CurrentRow.Cells[0].Value.ToString());
            lblNombre.Text += datos.Rows[0][0].ToString();
            lblApellidos.Text += datos.Rows[0][1].ToString();
            lblDocumento.Text += datos.Rows[0][2].ToString();
            lblNumeroContrato.Text += datos.Rows[0][3].ToString();
            lblSueldo.Text += datos.Rows[0][4].ToString();
        }

        private void btnCalcularPago_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "Total a pagar: ";

            int horasExtra=0, HorasDias=0, sueldoxHora=0;
            try
            {
                horasExtra = Int32.Parse(txtHora.Text);
            }
            catch (Exception)
            {

            }
            try
            {
                HorasDias = Int32.Parse(txtDias.Text) * 8;
            }
            catch (Exception)
            {

            }
            
            sueldoxHora = Int32.Parse(datos.Rows[0][4].ToString());

            totalPago = (horasExtra + HorasDias) * sueldoxHora;

            lblTotal.Text += totalPago;
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "Total a pagar: ")
                MessageBox.Show("Debe calcular el total a pagar primero");
            else
            {
                int id = Int32.Parse(dgvPagosPendientes.CurrentRow.Cells[4].Value.ToString());

                try
                {
                    mov.validarPago(id, Int32.Parse(txtDias.Text), Int32.Parse(txtHora.Text), totalPago.ToString());
                    MessageBox.Show("Se ha validado el pago correctamente");


                    //Impresion del recibo
                    DataTable paga = new DataTable();
                    paga = mov.consultarDatosPagoRealizado(Int32.Parse(dgvPagosPendientes.CurrentRow.Cells[4].Value.ToString()));
                    ReportePagoNomina recibo = new ReportePagoNomina();
                    DatosPagoNomina datosPago = new DatosPagoNomina();
                    datosPago.Dias = paga.Rows[0][5].ToString();
                    datosPago.Horas = paga.Rows[0][6].ToString();
                    datosPago.Nombre = paga.Rows[0][0].ToString() + " " + paga.Rows[0][1].ToString();
                    datosPago.IDContrato = paga.Rows[0][3].ToString();
                    datosPago.PagoDias = (Int32.Parse(paga.Rows[0][5].ToString()) * Int32.Parse(paga.Rows[0][4].ToString()) * 8).ToString();
                    datosPago.PagoHoras = (Int32.Parse(paga.Rows[0][6].ToString()) * Int32.Parse(paga.Rows[0][4].ToString())).ToString();
                    datosPago.Total = paga.Rows[0][7].ToString();
                    datosPago.Sueldo = paga.Rows[0][4].ToString();
                    datosPago.Fecha = dgvPagosPendientes.CurrentRow.Cells[5].Value.ToString().Substring(0, 10);
                    datosPago.Documento = paga.Rows[0][2].ToString();

                    recibo.pago.Add(datosPago);

                    recibo.ShowDialog();


                    DataTable data = new DataTable();
                    data = mov.consultarPagosPendientes();
                    dgvPagosPendientes.DataSource = data;

                }
                catch(Exception)
                {
                    MessageBox.Show("Ha ocurrido un error validando el pago");
                }
                
              
            }
        }
    }
}
