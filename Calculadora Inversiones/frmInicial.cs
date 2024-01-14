using Calculadora_Inversiones.Servicios;

namespace Calculadora_Inversiones
{
    public partial class frmInicial : Form
    {
        CedearRepo cedearRepo = new CedearRepo();

        public frmInicial()
        {
            InitializeComponent();

            // Combobox hardcodeado para usar de manera simple la app
            cboCedears.Items.Add("EJ1");
            cboCedears.Items.Add("EJ2");
            cboCedears.Items.Add("EJ3");
            cboCedears.Items.Add("EJ4");
            cboCedears.Items.Add("EJ5");
            cboCedears.Items.Add("EJ6");
            cboCedears.Items.Add("EJ6");
            cboCedears.Items.Add("EJ7");
            cboCedears.Items.Add("EJ8");
            cboCedears.Items.Add("EJ9");
            cboCedears.Items.Add("EJ10");

            // Combobox cargado con registros traídos de la db para funcionalidad ideal y completa
            //cboCedears.DataSource = cedearRepo.GetCedearModels();
            //cboCedears.DisplayMember = "Nombre";
            //cboCedears.ValueMember = "Id";
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
            frmCompraNueva frmCompraNueva = new frmCompraNueva();
            frmCompraNueva.ShowDialog();
        }

        private void visualizarElHistorialDeTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialTransacciones frmHistorialTransacciones = new frmHistorialTransacciones();
            frmHistorialTransacciones.Show();
        }
    }
}
