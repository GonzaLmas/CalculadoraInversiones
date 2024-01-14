using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Inversiones.Models
{
    public class HistorialComprasModel
    {
        public int Id { get; set; }
        [DisplayName("Monto de Compra")]
        public decimal MontoDeCompra { get; set; }
        [DisplayName("Fecha de Compra")]
        public DateTime FechaDeCompra { get; set; }
        [DisplayName("Cantidad de Cedears")]
        public int CantidadCedears { get; set; }
        public string? Cedear { get; set; }
        public string? Usuario { get; set; }

        
    }
}
