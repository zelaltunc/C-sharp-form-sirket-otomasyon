using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinal
{
    public partial class birimIslem : Form
    {
        public birimIslem()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=OOPFinal;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;


  
        private void birimEkle_Click(object sender, EventArgs e)
        {
            string query = "Insert into birim (birimAdi) values (@birimAdi)";
            com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@birimAdi", txtBirimName.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Birim eklendi.");
            birimListele();

        }
        private void birimDuzenle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE birim SET birimAdi=@birimAdi  where birimID=@birimID";
            com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@birimID", Convert.ToInt32(txtBirimId.Text));
            com.Parameters.AddWithValue("@birimAdi", txtBirimName.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Birim Güncellendi.");
            birimListele();

        }

        private void birimSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM birim WHERE birimID=@birimID";
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@birimID", txtBirimId.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Birim Silindi.");
            birimListele();

        }

        private void birimIslem_Load(object sender, EventArgs e)
        {
            birimListele();

        }
        public void birimListele()
        {
            con.Open();
            string birimPersonel = "select  birimID as 'Birim No',birimAdi as 'Birim Adı' from birim";
            com = new SqlCommand(birimPersonel, con);
            da = new SqlDataAdapter(com);
            DataTable sda2 = new DataTable();
            da.Fill(sda2);
            dataGridView1.DataSource = sda2;
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtBirimId.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtBirimName.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
        }


        private void giris_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }

        private void personelİslemleri_Click(object sender, EventArgs e)
        {
            personelIslem frm = new personelIslem();
            frm.Show();
            this.Hide();
        }


    }
}
