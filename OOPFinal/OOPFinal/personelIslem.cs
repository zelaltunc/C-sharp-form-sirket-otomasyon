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
    public partial class personelIslem : Form
    {
        public personelIslem()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=OOPFinal;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;


        private void personelDuzenle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE personel SET birimID=@birimID,adSoyad=@adSoyad ,girisTarihi=@girisTarihi ,cikisTarihi=@cikisTarihi ,icerdeMi=@icerdeMi where personelID=@personelID";
            com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@personelID", Convert.ToInt32(txtid.Text));
            com.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            com.Parameters.AddWithValue("@girisTarihi", dtGirisTarihi.Value);
            com.Parameters.AddWithValue("@cikisTarihi", dtCikisTarihi.Value);
            com.Parameters.AddWithValue("@icerdeMi", cbIcerdeMi.Checked);
            com.Parameters.AddWithValue("@birimID", cbBirim.SelectedValue);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel Güncellendi.");
            personelListele();

        }

        private void personelSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM personel WHERE personelID=@personelID";
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@personelID", txtid.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel Silindi.");
            personelListele();

        }


        private void personelIslem_Load(object sender, EventArgs e)
        {
            personelListele();

            var birimler = "select * from birim";
            SqlDataAdapter sda = new SqlDataAdapter(birimler, con);
            var ds2 = new DataSet();
            sda.Fill(ds2);
            cbBirim.SelectedText = "birimAdi";
            cbBirim.SelectedValue = "birimID";
            cbBirim.DataSource = ds2.Tables[0];
        }

        public void personelListele()
        {
            var personeller = "select p.personelID as 'Personel No',p.adSoyad as 'Ad Soyad',p.girisTarihi as 'Giriş Tarihi',p.cikisTarihi as 'Çıkış Tarihi',p.icerdeMi as 'İçerde mi',b.birimAdi as 'Birim Adı' ,b.birimID as 'Birim No' from personel p left join birim b on b.birimID = p.birimID";

            var dataAdapter = new SqlDataAdapter(personeller, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            string giris_Tarihi = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            string cikis_Tarihi = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            dtGirisTarihi.Value = DateTime.Parse(giris_Tarihi);
            dtCikisTarihi.Value = DateTime.Parse(cikis_Tarihi);
            string cb_IcerdeMi = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            if (cb_IcerdeMi == "True")
            {
                cbIcerdeMi.Checked = true;
            }
            else
            {
                cbIcerdeMi.Checked = false;
            }

            cbBirim.SelectedText = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            cbBirim.SelectedValue = dataGridView1.Rows[secim].Cells[6].Value.ToString();
        }

 

        private void giris_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
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
