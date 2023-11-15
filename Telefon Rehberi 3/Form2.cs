using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonKişiAra_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deneme1.accdb");
            try
            {
                string aramaKelimesi = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(aramaKelimesi))
                {
                    MessageBox.Show("Lütfen arama kelimesi girin.");
                    return;
                }
                baglanti.Open();
                string sorgu = "SELECT * FROM deneme1 WHERE Ad LIKE @AramaKelimesi OR Soyad LIKE @AramaKelimesi OR Numara1 LIKE @AramaKelimesi OR Numara2 LIKE @AramaKelimesi OR Mail LIKE @AramaKelimesi";
                using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@AramaKelimesi", "%" + aramaKelimesi + "%");
                    OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Arama sonucunda hiçbir kayıt bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonDüzenle_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();

            int index = dataGridView1.CurrentRow.Index;
            string Ad = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string Soyad = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string Numara1 = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string Numara2 = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string Mail = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string Evadres = dataGridView1.Rows[index].Cells[7].Value.ToString();
            string İşadres = dataGridView1.Rows[index].Cells[8].Value.ToString();
            string Twitter = dataGridView1.Rows[index].Cells[9].Value.ToString();
            string Facebook = dataGridView1.Rows[index].Cells[10].Value.ToString();
            string Instagram = dataGridView1.Rows[index].Cells[11].Value.ToString();
            string Websitesi = dataGridView1.Rows[index].Cells[12].Value.ToString();
            string Doğumgünü = dataGridView1.Rows[index].Cells[13].Value.ToString();
            string Resim = dataGridView1.Rows[index].Cells[1].Value.ToString();
            frm3.id= int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            frm3.textBoxAd.Text = Ad;
            frm3.textBoxSoyad.Text = Soyad;
            frm3.textBoxNumara1.Text = Numara1;
            frm3.textBoxNumara2.Text = Numara2;
            frm3.textBoxMail.Text = Mail;
            frm3.textBoxEvAdres.Text = Evadres;
            frm3.textBoxİşAdres.Text = İşadres;
            frm3.textBoxTwitter.Text = Twitter;
            frm3.textBoxFacebook.Text = Facebook;
            frm3.textBoxİnstagram.Text = Instagram;
            frm3.textBoxWebSitesi.Text = Websitesi;
            frm3.textBoxDoğumGünü.Text = Doğumgünü;
            frm3.pictureBox1.Text = Resim;

            byte[] imgBytes = (byte[])dataGridView1.CurrentRow.Cells["Resim"].Value;
            MemoryStream ms = new MemoryStream(imgBytes);
            frm3.pictureBox1.Image = Image.FromStream(ms);
        }

        private void buttonKişiyiSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
