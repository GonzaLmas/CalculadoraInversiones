namespace Calculadora_Inversiones
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();

            cboCedears.Items.Add("AAPL, Apple");
            cboCedears.Items.Add("EEM, Emerging Markets");
            cboCedears.Items.Add("GOOGL, Alphabeth");
            cboCedears.Items.Add("META, Meta");
            cboCedears.Items.Add("QQQ, Nasdaq 100");
            cboCedears.Items.Add("SPY, S&P 500");
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
            if(cboCedears.SelectedIndex == -1)
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
    }
}
