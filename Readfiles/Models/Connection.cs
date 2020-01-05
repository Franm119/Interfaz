using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Readfiles.Models
{
    class Connection
    {
        /// <summary>
        /// Conexión con base de datos SQL Server. 
        ///<return>
        /// Devuelve conexión.
        ///</return>
        /// </summary>
        public string Connect()
        {
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder
            {
                ["Data Source"] = "FRANCISCO-PC", // Nombre del servidor 
                ["Initial Catalog"] = "Interfaz_AX_DOM", // Nombre de la base de datos
                ["User ID"] = "laboratorio", // Usuario de autenticación de SQL Server.
                ["Password"] = "ccs_joincic60" // Contraseña de autenticación de SQL Server.
            };
            return con.ConnectionString;
        }
    }
}
