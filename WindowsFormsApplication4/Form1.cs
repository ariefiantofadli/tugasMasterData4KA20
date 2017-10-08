using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        // String db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Arief\Documents\testing.mdb";
        String db = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Documents\Visual Studio 2017\Projects\testing.mdb";
        public Form1()
        {
            InitializeComponent();
        }

        // Fungsi button Save pada tab 1
        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String Query = "";
            Query = "INSERT INTO bio(Nama,NIS,Jenis_Kelamin,Tempat_Lahir,Tanggal_Lahir,Agama,No_Telp,Alamat,Nama_Ayah,Pekerjaan_Ayah,Nama_Ibu,Pekerjaan_Ibu,Anak_Ke) VALUES('" + txtNama.Text + "','" + txtNis.Text + "','" + txtJK.Text + "','" + txtTempatLahir.Text + "','" + txtTglLahir.Text + "','" + txtAgama.Text + "','" + txtNoTelp.Text + "','" + txtAlamat.Text + "','" + txtNamaAyah.Text + "','" + txtKrjAyah.Text + "','" + txtNamaIbu.Text + "','" + txtKrjIbu.Text + "','" + txtAnakKe.Text + "')";
            OleDbCommand data = new OleDbCommand();
            data.CommandText = Query;
            data.Connection = koneksi;
            data.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Sudah input");
        }

        // Fungsi button Clear pada tab 1
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtJK.Clear();
            txtTempatLahir.Clear();
            txtTglLahir.Clear();
            txtAgama.Clear();
            txtNoTelp.Clear();
            txtAlamat.Clear();
            txtNamaAyah.Clear();
            txtKrjAyah.Clear();
            txtNamaIbu.Clear();
            txtKrjIbu.Clear();
            txtAnakKe.Clear();
        }

        // Fungsi button Save pada tab 2
        private void btnSave2_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String Query = "";
            Query = "INSERT INTO jurusan(NIS,Kd_Jurusan,Nama_Jurusan) VALUES('" + txtNis2.Text + "','" + txtKodeJurusan.Text + "','" + txtJurusan.Text + "')";
            OleDbCommand data = new OleDbCommand();
            data.CommandText = Query;
            data.Connection = koneksi;
            data.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Sudah input");
        }


        // Fungsi button Clear pada tab 2
        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtNis2.Clear();
            txtKodeJurusan.Clear();
            txtJurusan.Clear();
        }

        // Fungsi button Save pada tab 3
        private void btnSave3_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String Query = "";
            Query = "INSERT INTO ajar(NIS,Tahun_Ajar) VALUES('" + txtNis3.Text + "','" + txtTahunAjar.Text + "')";
            OleDbCommand data = new OleDbCommand();
            data.CommandText = Query;
            data.Connection = koneksi;
            data.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Sudah input");
        }

        // Fungsi button Clear pada tab 3
        private void btnClear3_Click(object sender, EventArgs e)
        {
            txtNis3.Clear();
            txtTahunAjar.Clear();
        }

        // Fungsi untuk button Close.
        private void btnExit_Click(object sender, EventArgs e) => Close();
        private void btnExit2_Click(object sender, EventArgs e) => Close();
        private void btnExit3_Click(object sender, EventArgs e) => Close();

    }
}
