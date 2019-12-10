using System;
using System.Data;
using System.Data.SqlClient;

namespace Readfiles.Config
{
    class Databases
    {
        public string Conexion()
        {
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder
            {
                ["Data Source"] = "FRANCISCO-PC",
                ["Initial Catalog"] = "Interfaz_AX_DOM",
                ["User ID"] = "laboratorio",
                ["Password"] = "ccs_joincic60"
            };
            //Console.WriteLine(con.ConnectionString);
            return con.ConnectionString;
        }
    }
}
