using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Inversiones.Models
{
    public class ConsultaModel
    {
        public int Id { get; set; }
        public decimal MontoGanancia { get; set; }
        public DateTime FechaConsulta { get; set; }
        public int IdHistorialCompra { get; set; }
        public int IdUsuario { get; set; }
    }
}
