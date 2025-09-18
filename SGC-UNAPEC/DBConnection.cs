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
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SGC_UNAPEC;TrustServerCertificate=True");
        }
    }
}
