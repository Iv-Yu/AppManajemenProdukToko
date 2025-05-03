using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace crudaplikasi
{
    public partial class ManajemenProdukToko : Form
    {
        private List<Produk> daftarProduk = new List<Produk>();

        public ManajemenProdukToko()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ManajemenProdukToko_Load(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void TampilkanData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = daftarProduk.Select(p => new
            {
                p.ID,
                p.Nama,
                Harga = p.Harga.ToString("N0") // format ribuan
            }).ToList();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Semua kolom wajib diisi.");
                return;
            }

            if (daftarProduk.Any(p => p.ID == txtID.Text))
            {
                MessageBox.Show("ID sudah digunakan.");
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal harga))
            {
                MessageBox.Show("Harga tidak valid.");
                return;
            }

            Produk produkBaru = new Produk
            {
                ID = txtID.Text,
                Nama = txtNama.Text,
                Harga = harga
            };

            daftarProduk.Add(produkBaru);
            TampilkanData();
            ResetForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string id = txtID.Text;
            var produk = daftarProduk.FirstOrDefault(p => p.ID == id);

            if (produk != null)
            {
                produk.Nama = txtNama.Text;

                if (decimal.TryParse(txtHarga.Text, out decimal hargaBaru))
                    produk.Harga = hargaBaru;
                else
                {
                    MessageBox.Show("Harga tidak valid.");
                    return;
                }

                TampilkanData();
                ResetForm();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string id = txtID.Text;
            var produk = daftarProduk.FirstOrDefault(p => p.ID == id);

            if (produk != null)
            {
                daftarProduk.Remove(produk);
                TampilkanData();
                ResetForm();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtID.Clear();
            txtNama.Clear();
            txtHarga.Clear();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                var row = dataGridView1.CurrentRow;
                txtID.Text = row.Cells[0].Value.ToString();
                txtNama.Text = row.Cells[1].Value.ToString();
                txtHarga.Text = row.Cells[2].Value.ToString().Replace(",", "").Replace(".", "");
            }
        }
    }
}
