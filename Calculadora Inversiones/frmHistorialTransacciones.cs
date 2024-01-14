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
    public partial class frmHistorialTransacciones : Form
    {
        HistorialComprasRepo historialComprasRepo = new HistorialComprasRepo();

        public frmHistorialTransacciones()
        {
            InitializeComponent();

            dgvHistorialCompras.DataSource = historialComprasRepo.GetHistorialCompras();
            dgvHistorialCompras.Columns[0].Visible = false;
            dgvHistorialCompras.Columns[6].Visible = false;
            dgvHistorialCompras.Columns[7].Visible = false;
        }

    }
}
