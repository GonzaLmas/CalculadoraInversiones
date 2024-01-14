using Calculadora_Inversiones.Interfaces;
using Calculadora_Inversiones.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Inversiones.Servicios
{
    public class CedearRepo : CedearInterface
    {
        public IEnumerable<CedearModel> GetCedearModels()
        {
            var sp = "sp_GetCedears";

            using (IDbConnection connection = new SqlConnection(DBConnection.GetStringConnection()))
            {
                return connection.Query<CedearModel>(sp, commandType: CommandType.StoredProcedure);
            }
        }

        Task<IEnumerable<CedearModel>> CedearInterface.GetCedearModels()
        {
            throw new NotImplementedException();
        }
    }
}
