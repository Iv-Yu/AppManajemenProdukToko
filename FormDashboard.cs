using System;
using System.Windows.Forms;

namespace ManajemenProdukToko
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnKelolaProduk_Click(object sender, EventArgs e)
        {
            FormProduk formProduk = new FormProduk();
            formProduk.Show();
        }
    }
}
