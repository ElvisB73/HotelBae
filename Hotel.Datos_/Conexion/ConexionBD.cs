using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos_.Conexion
{
    public static class ConexionBD
    {
        private static readonly string _cadena =
            "Data source =.;initial catalog =Hotel; integrated security=true";

            public static SqlConnection ObtenerConexion()
            {
                return new SqlConnection(_cadena);
        }
    }

}
