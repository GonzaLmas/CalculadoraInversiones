using Calculadora_Inversiones.Models;
using Calculadora_Inversiones.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Inversiones
{
    public partial class frmCompraNueva : Form
    {
        CedearRepo cedearRepo = new CedearRepo();
        UsuarioRepo usuarioRepo = new UsuarioRepo();

        decimal montoCompraNueva = 0;
        DateTime dtpCompraNueva;
        int cantidadCedearsCompraNueva = 0;
        int idCedearCompraNueva = -1;
        string cedearCompraNueva;
        int idUsuarioCompraNueva = -1;
        string usuarioCompraNueva;

        public frmCompraNueva()
        {
            InitializeComponent();

            cboCedearsCompra.DataSource = cedearRepo.GetCedearModels();
            cboCedearsCompra.DisplayMember = "Nombre";
            cboCedearsCompra.ValueMember = "Id";

            cboUsuarios.DataSource = usuarioRepo.GetUsuarios();
            cboUsuarios.DisplayMember = "Nombre";
            cboUsuarios.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            HistorialComprasRepo historialComprasRepo = new HistorialComprasRepo();

            try
            {
                if (decimal.Parse(txtMontoCompraNueva.Text) > 0 && decimal.Parse(txtMontoCompraNueva.Text) < 300000)
                {
                    if (txtMontoCompraNueva.Text != "" && nupCompraNueva.Value != 0)
                    {
                        montoCompraNueva = decimal.Parse(txtMontoCompraNueva.Text);
                        dtpCompraNueva = dtpCompra.Value;
                        cantidadCedearsCompraNueva = int.Parse(nupCompraNueva.Value.ToString());
                        idCedearCompraNueva = cboCedearsCompra.SelectedIndex + 1;
                        idUsuarioCompraNueva = cboUsuarios.SelectedIndex + 1;

                        historialComprasRepo.NuevaCompra(montoCompraNueva, dtpCompraNueva, cantidadCedearsCompraNueva,
                                                           idCedearCompraNueva, idUsuarioCompraNueva);

                        MessageBox.Show("La compra se agregó correctamente.", "Felicitaciones");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Complete todos los campos.", "Advertencia");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido entre 0 y 300.000 en el campo Monto de la Compra.", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Advertencia");
            }
        }
    }
}
