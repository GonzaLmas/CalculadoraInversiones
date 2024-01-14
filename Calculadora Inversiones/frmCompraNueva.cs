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

        public frmCompraNueva()
        {
            InitializeComponent();

            cboCedearsCompra.DataSource = cedearRepo.GetCedearModels();
            cboCedearsCompra.DisplayMember = "Nombre";
            cboCedearsCompra.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
