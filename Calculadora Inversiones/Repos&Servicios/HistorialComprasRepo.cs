using Calculadora_Inversiones.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Inversiones.Servicios
{
    public class HistorialComprasRepo
    {
        public IEnumerable<HistorialComprasModel> NuevaCompra()
        {
            var sp = "sp_NuevaCompra";

            using (IDbConnection connection = new SqlConnection(DBConnection.GetStringConnection()))
            {
                return connection.Query<HistorialComprasModel>(sp, new { }, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<HistorialComprasModel> GetHistorialCompras()
        {
            var sp = "sp_HistorialCompras";

            using (IDbConnection connection = new SqlConnection(DBConnection.GetStringConnection()))
            {
                var results = connection.Query<HistorialComprasModel>(sp, commandType: CommandType.StoredProcedure);

                return results;
            }

        }
    }
}
