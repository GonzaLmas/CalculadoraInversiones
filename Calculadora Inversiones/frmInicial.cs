using Calculadora_Inversiones.Servicios;

namespace Calculadora_Inversiones
{
    public partial class frmInicial : Form
    {
        CedearRepo cedearRepo = new CedearRepo();
        frmCompraNueva frmCompraNueva = new frmCompraNueva();
        frmHistorialTransacciones frmHistorialTransacciones = new frmHistorialTransacciones();

        public frmInicial()
        {
            InitializeComponent();

            cboCedears.DataSource = cedearRepo.GetCedearModels();
            cboCedears.DisplayMember = "Nombre";
            cboCedears.ValueMember = "Id";
        }


        public void CalculoGanancia(double montoCompra, double montoGanancia)
        {
            double porcentajeGananciaTemp = 0;
            double porcentajeGanancia = 0;

            porcentajeGananciaTemp = (montoGanancia * 100) / montoCompra;
            porcentajeGanancia = porcentajeGananciaTemp - 100;

            if (porcentajeGanancia > 0)
            {
                txtPorcentajeGanancia.Text = porcentajeGanancia.ToString() + "%";
                txtPorcentajeGanancia.BackColor = Color.LightGreen;
            }
            else if (porcentajeGanancia < 0)
            {
                txtPorcentajeGanancia.Text = porcentajeGanancia.ToString() + "%";
                txtPorcentajeGanancia.BackColor = Color.IndianRed;
            }
            else
            {
                txtPorcentajeGanancia.Text = porcentajeGanancia.ToString() + "%";
                txtPorcentajeGanancia.BackColor = Color.DodgerBlue;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cboCedears.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Cedear", "Alerta");
            }
            else
            {
                if (txtMontoCompra.Text != "" && txtMontoGanancia.Text != "")
                {
                    CalculoGanancia(double.Parse(txtMontoCompra.Text), double.Parse(txtMontoGanancia.Text));
                }
                else if (txtMontoCompra.Text == "" && txtMontoGanancia.Text == "")
                {
                    MessageBox.Show("Debe ingresar el monto de la compra y el monto de la ganancia del Cedear", "Alerta");
                }
                else if (txtMontoCompra.Text == "")
                {
                    MessageBox.Show("Debe ingresar el monto de la compra del Cedear", "Alerta");
                }
                else if (txtMontoGanancia.Text == "")
                {
                    MessageBox.Show("Debe ingresar el monto de la ganancia del Cedear", "Alerta");
                }
            }
        }

        private void registrarNuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompraNueva.ShowDialog();
        }

        private void visualizarElHistorialDeTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialTransacciones.Show();
        }
    }
}
