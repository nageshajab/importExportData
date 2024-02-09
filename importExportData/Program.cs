using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace importExportData
{
    class Program
    {
        static private string source = "server=10.11.11.19;database=FM_Sharp_Practice;user id=itf-application;password=4rfvgy7";

        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select top 1 * from clinician";
                   SqlDataReader reader= cmd.ExecuteReader();
                    DataTable sourcedt = new DataTable();
                    sourcedt.Load(reader);


                }
            }
        }

        static void x()
        {
            
        }
    }
}
