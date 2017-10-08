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
        String db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Arief\Documents\testing.mdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String Query = "";
            Query = "INSERT INTO bio(Nama,NIS,Jenis_Kelamin,Tempat_Lahir,Tanggal_Lahir,Agama,No_Telp,Alamat,Nama_Ayah,Pekerjaan_Ayah,Nama_Ibu,Pekerjaan_Ibu,Anak_Ke) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')";
            OleDbCommand data = new OleDbCommand();
            data.CommandText = Query;
            data.Connection = koneksi;
            data.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Sudah input");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String Query = "";
            Query = "INSERT INTO jurusan(NIS,Kd_Jurusan,Nama_Jurusan) VALUES('" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "')";
            OleDbCommand data = new OleDbCommand();
            data.CommandText = Query;
            data.Connection = koneksi;
            data.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Sudah input");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String Query = "";
            Query = "INSERT INTO ajar(NIS,Tahun_Ajar) VALUES('" + textBox17.Text + "','" + textBox18.Text + "')";
            OleDbCommand data = new OleDbCommand();
            data.CommandText = Query;
            data.Connection = koneksi;
            data.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Sudah input");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox17.Clear();
            textBox18.Clear();

        }
    }
}
