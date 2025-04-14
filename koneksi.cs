using System;
using System.Data.SqlClient;

namespace ManajemenProdukToko
{
    public static class Koneksi
    {
        public static SqlConnection ConnectToDatabase()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=TokoDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
