using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteriaEscolar.Base_de_datos
{
    internal class DataAcces
    {
        private string cadena = "server=localhost;" + "Database=cafeteriadb;" + "Uid=root;" + "Password=;" + "Port=3306;";

        public MySqlConnection Dataacces()
        {
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
