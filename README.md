# 🛒 Aplikasi Manajemen Produk Toko

Aplikasi desktop sederhana berbasis WinForms yang digunakan untuk mengelola data produk di toko.  
Aplikasi ini mendukung fitur CRUD (Create, Read, Update, Delete) terhadap data produk seperti nama, kategori, harga, dan stok.

## 🧩 Fitur Aplikasi

- Tambah produk baru
- Lihat daftar produk
- Edit data produk
- Hapus produk
- Dashboard ringkasan (opsional)

## 🎨 Desain Mockup

Mockup awal aplikasi dirancang menggunakan AI tools untuk menggambarkan tampilan aplikasi desktop.

📎 Lihat mockup di sini:  
👉 [Mockup Aplikasi Manajemen Produk Toko](https://chat.openai.com/share/8d7aaf24-2cc8-4659-87ee-3dd06598cc5b)

## 💾 Koneksi Database

Aplikasi ini terhubung dengan database SQL Server (atau bisa disesuaikan dengan database lain seperti MySQL).

Contoh connection string:
```csharp
string connectionString = "Data Source=localhost;Initial Catalog=TokoDB;Integrated Security=True;";
