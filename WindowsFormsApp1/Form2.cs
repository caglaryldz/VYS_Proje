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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DB_ODEV; user Id=postgres; password=09Az6262");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da= new NpgsqlDataAdapter("select*from kategori",baglanti);
            DataTable dt =new DataTable();
            da.Fill(dt);
            comboBoxkategori.ValueMember = "kategori_no";
            comboBoxkategori.DisplayMember = "kategori_ad";
            comboBoxkategori.DataSource = dt;
            baglanti.Close();
        }

        private void buttonlistele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from urun";
            NpgsqlDataAdapter da=new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0]; 

        }

        private void buttonekle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into urun (urun_no,urun_adi,urun_adeti,urun_fiyati,kategori) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(texturunno.Text));
            komut.Parameters.AddWithValue("@p2", texturunadi.Text);
            komut.Parameters.AddWithValue("@p3", numericUpDown1.Value); 
            komut.Parameters.AddWithValue("@p4", int.Parse(texturunfiyati.Text));
            komut.Parameters.AddWithValue("@p5", comboBoxkategori.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ürün kaydı başarılı");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonsil1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2=new NpgsqlCommand("DELETE From urun where urun_no=@p1",baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(texturunno.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ürün silindi");
        }

        private void buttongüncelle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update urun set urun_adi=@p1,urun_adeti=@p2,urun_fiyati=@p3 where urun_no=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p1", texturunadi.Text);
            komut3.Parameters.AddWithValue("@p2", numericUpDown1.Value);
            komut3.Parameters.AddWithValue("@p3", int.Parse(texturunfiyati.Text)); 
            komut3.Parameters.AddWithValue("@p4", int.Parse(texturunno.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("ürün güncellendi");
            baglanti.Close();
        }
    }
}
