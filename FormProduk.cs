using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManajemenProdukToko
{
    public partial class FormProduk : Form
    {
        SqlConnection conn = Koneksi.ConnectToDatabase();

        public FormProduk()
        {
            InitializeComponent();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void LoadDataProduk()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produk", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProduk.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            // Tambah produk (akan dikembangkan lebih lanjut)
            MessageBox.Show("Form tambah produk");
        }

        private void btnEditProduk_Click(object sender, EventArgs e)
        {
            // Edit produk (akan dikembangkan lebih lanjut)
            MessageBox.Show("Form edit produk");
        }

        private void btnHapusProduk_Click(object sender, EventArgs e)
        {
            // Hapus produk (akan dikembangkan lebih lanjut)
            MessageBox.Show("Produk dihapus");
        }
    }
}
