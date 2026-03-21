using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace ControlRutasCormex.Data
{
    public class Conexion
    {
        private string cadena = "Server=NOBODY-PC;Database=ControlRutasCormex;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
