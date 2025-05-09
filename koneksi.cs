using MySql.Data.MySqlClient;

namespace crudaplikasi
{
    public static class Koneksi
    {
        private static string connectionString = "server=localhost;user=root;password=;database=manageproduk;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
