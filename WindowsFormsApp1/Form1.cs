using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DB_ODEV; user Id=postgres; password=09Az6262");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonlistele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kategori";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void buttonekle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kategori (kategori_no, kategori_ad) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textkategorino.Text));
            komut1.Parameters.AddWithValue("@p2", textkategoriadı.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kategori başarılı şekilde eklendi");



        }

        private void textkategoriadı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
