using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjetDotNet
{
    class ConnectionDB
    {
        private string connectionString = @"Server=DESKTOP-E1A412J\SQLEXPRESS;Database=Gest_Notes;Trusted_Connection=True;";
        private SqlConnection cnx=null;

        public SqlConnection Cnx()
        {
            cnx = new SqlConnection(connectionString);
            return cnx;
        }
    }
}
