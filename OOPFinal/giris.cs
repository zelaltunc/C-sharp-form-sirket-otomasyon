using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinal
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=OOPFinal;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;

        public void personelListele()
        {
            var personeller = "select p.personelID as 'Personel No',p.adSoyad as 'Ad Soyad',p.girisTarihi as 'Giriş Tarihi',p.cikisTarihi as 'Çıkış Tarihi',p.icerdeMi as 'İçerde mi',b.birimAdi as 'Birim Adı' from personel p left join birim b on b.birimID = p.birimID";

            var dataAdapter = new SqlDataAdapter(personeller, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void personel_ekle_Click(object sender, EventArgs e)
        {
            string query = "Insert into personel (birimID ,adSoyad ,girisTarihi ,cikisTarihi ,icerdeMi ) values (@birimID,@adSoyad,@girisTarihi,@cikisTarihi,@icerdeMi)";
            com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            com.Parameters.AddWithValue("@girisTarihi", dtGirisTarihi.Value);
            com.Parameters.AddWithValue("@cikisTarihi", dtCikisTarihi.Value);
            com.Parameters.AddWithValue("@icerdeMi", cbIcerdeMi.Checked);
            com.Parameters.AddWithValue("@birimID", cbBirim.SelectedValue);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel eklendi.");
            personelListele();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            personelListele();

            var birimler = "select * from birim";
            SqlDataAdapter sda = new SqlDataAdapter(birimler, con);
            var ds2 = new DataSet();
            sda.Fill(ds2);
            cbBirim.SelectedText = "birimAdi";
            cbBirim.SelectedValue = "birimID";
            cbBirim.DataSource = ds2.Tables[0];



            con.Open();
            string birimPersonel = "select b.birimAdi as 'Birim Adı', 'Personel Sayısı'= count(*) from personel p left join birim b on b.birimID = p.birimID group by birimAdi";
            com = new SqlCommand(birimPersonel, con);
            da = new SqlDataAdapter(com);
            DataTable sda2 = new DataTable();
            da.Fill(sda2);
            dataGridView2.DataSource = sda2;
            con.Close();



            con.Open();
             com.CommandText = "select calisma=(AVG(DATEDIFF(HOUR,girisTarihi,cikisTarihi))) from personel";
            com.ExecuteNonQuery();
            SqlDataReader read = com.ExecuteReader();
            if (read.Read()) {
                txtcalisOrt.Text = read["calisma"].ToString();
            }
            read.Close();

            con.Close();



            con.Open();
            com.CommandText = "select sayi=(count(*)) from personel";
            com.ExecuteNonQuery();
            SqlDataReader read2 = com.ExecuteReader();
            if (read2.Read())
            {
                txtperSayi.Text = read2["sayi"].ToString();
            }
            read2.Close();

            con.Close();
        }

   


     

        private void personelİslemleri_Click(object sender, EventArgs e)
        {
            personelIslem frm = new personelIslem();
            frm.Show();
            this.Hide();

        }

        private void birimIslemleri_Click(object sender, EventArgs e)
        {
            birimIslem frm = new birimIslem();
            frm.Show();
            this.Hide();
        }

    }
}
