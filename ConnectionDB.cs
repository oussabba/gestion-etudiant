using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjetDotNet
{
    public static class ConnectionDB
    {
        private static string connectionString = @"Data Source=DESKTOP-E1A412J\SQLEXPRESS;Initial Catalog= Gest_Notes;Trusted_Connection=True;";
        private static SqlConnection cnx=null;

        public static SqlConnection Cnx()
        {
            cnx = new SqlConnection(connectionString);
            return cnx;
        }
    }
}
