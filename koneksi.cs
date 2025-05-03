using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class Koneksi
{
    public MySqlConnection GetConn()
    {
        string connStr = "server=localhost;user id=root;password=;database=manageproduk;";
        return new MySqlConnection(connStr);
    }
}
