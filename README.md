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
👉 [Mockup Aplikasi Manajemen Produk Toko](https://sdmntprsouthcentralus.oaiusercontent.com/files/00000000-dfd8-61f7-9abe-b43a26028050/raw?se=2025-04-14T15%3A08%3A43Z&sp=r&sv=2024-08-04&sr=b&scid=1736507c-5727-53c3-8044-4516755ae1ac&skoid=ae70be19-8043-4428-a990-27c58b478304&sktid=a48cca56-e6da-484e-a814-9c849652bcb3&skt=2025-04-14T01%3A23%3A26Z&ske=2025-04-15T01%3A23%3A26Z&sks=b&skv=2024-08-04&sig=FJSXZ4uvUNmkW61Sl72vZDF0tDGfZtzKqVoi/ORoWFM%3D)

## 💾 Koneksi Database

Aplikasi ini terhubung dengan database SQL Server (atau bisa disesuaikan dengan database lain seperti MySQL).

Contoh connection string:
```csharp
string connectionString = "Data Source=localhost;Initial Catalog=TokoDB;Integrated Security=True;";
