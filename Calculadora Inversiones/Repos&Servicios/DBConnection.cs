using System.Configuration;

namespace Calculadora_Inversiones.Servicios
{
    public class DBConnection
    {
        public static string GetStringConnection()
        {
            return ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
        }

    }
}
