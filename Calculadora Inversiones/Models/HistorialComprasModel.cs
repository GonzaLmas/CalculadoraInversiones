using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Inversiones.Models
{
    public class HistorialComprasModel
    {
        public int Id { get; set; }
        public decimal MontoDeCompra { get; set; }
        public DateTime FechaDeCompra { get; set; }
        public int CantidadCedears { get; set; }
        public int IdCedear { get; set; }
        public int IdUsuario { get; set; }
    }
}
