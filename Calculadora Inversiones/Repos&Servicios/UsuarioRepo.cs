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
    public class UsuarioRepo
    {
        public IEnumerable<UsuarioModel> GetUsuarios()
        {
            var sp = "sp_GetUsuarios";

            using (IDbConnection connection = new SqlConnection(DBConnection.GetStringConnection()))
            {
                var results = connection.Query<UsuarioModel>(sp, commandType: CommandType.StoredProcedure);

                return results;
            }
        }
    }
}
