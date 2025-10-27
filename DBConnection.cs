using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace SGC_UNAPEC
{
    internal class DBConnection
    {
        public static SqlConnection con;

        static DBConnection()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SGC_UNAPEC;TrustServerCertificate=True;");
        }

        public int ExecuteScalarQuery(string query)
        {
            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SGC_UNAPEC;TrustServerCertificate=True;"))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }
        public static SqlConnection GetOpen()
        {
            var c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SGC_UNAPEC;TrustServerCertificate=True;");
            c.Open();
            return c;
        }
    }
}
