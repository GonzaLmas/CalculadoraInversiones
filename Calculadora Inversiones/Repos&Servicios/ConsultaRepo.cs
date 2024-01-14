using Calculadora_Inversiones.Interfaces;
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

    public class ConsultaRepo : ConsultaInterface
    {
        public async Task<IEnumerable<CedearModel>> GetCedearModels()
        {
            using (IDbConnection connection = new SqlConnection(DBConnection.GetStringConnection()))
            {
                return await connection.QueryAsync<CedearModel>(@"SELECT Cedear, Descripcion FROM Cedear");
            }
        }
    }
}
