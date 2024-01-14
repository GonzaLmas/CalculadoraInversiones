using Calculadora_Inversiones.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_Inversiones.Servicios
{
    public class HistorialComprasRepo
    {
        public IEnumerable<HistorialComprasModel> NuevaCompra(decimal montoDeCompra, DateTime fechaDeCompra, 
                                                              int CantidadCedears, int idCedear, int idUsuario)
        {
            var sp = "sp_NuevaCompra";

            using (IDbConnection connection = new SqlConnection(DBConnection.GetStringConnection()))
            {
                var parametros = new DynamicParameters();
                parametros.Add("@montoDeCompra", montoDeCompra);
                parametros.Add("@fechaDeCompra", fechaDeCompra);
                parametros.Add("@cantidadCedears", CantidadCedears);
                parametros.Add("@idCedears", idCedear);
                parametros.Add("@idUsuario", idUsuario);

                return connection.Query<HistorialComprasModel>(sp, parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<HistorialComprasModel> GetHistorialCompras()
        {
            var sp = "sp_GetHistorialCompras";

            using (IDbConnection connection = new SqlConnection(DBConnection.GetStringConnection()))
            {
                var results = connection.Query<HistorialComprasModel>(sp, commandType: CommandType.StoredProcedure);

                return results;
            }
        }
    }
}
