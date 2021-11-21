using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_databas_app
{
    public class SQL
    {





        private static DataTable GetDataTable(string sql, string paramName, string paramValue)
        {
            string connString = "server=(localdb)\\mssqllocaldb;intergrated_security=true; database=MOCK_DATA";
            var dt = new DataTable(); //Skapar ny datatable
            using (var cnn = new SqlConnection(connString))
            {
                cnn.Open(); // Öppnar koppling till databas.
                using (var command = new SqlCommand(sql, connection))
                {

                }
            }

                return dt; //returnerar datatable.
        }
    }
}
