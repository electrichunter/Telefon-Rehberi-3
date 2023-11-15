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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deneme1.accdb");
        public int id;
        private void button1_Click(object sender, EventArgs e)
        {

            {
                Form2 frm2 = new Form2();
               
                {
                    using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deneme1.accdb"))
                    {

                        string queryString = "UPDATE deneme1 SET Ad = @Ad, Soyad = @Soyad, Numara1 = @Numara1, Numara2 = @Numara2, Mail = @Mail, Evadres = @EvAdres,İşAdres=@İşAdres,Twitter=@Twitter,Facebook=@Facebook,Instagram=@Instagram,WebSitesi=@WebSitesi,DoğumGünü=@DoğumGünü WHERE ID = @ID";
                        OleDbCommand command = new OleDbCommand(queryString, connection);
                        command.Parameters.AddWithValue("@Resim", pictureBox1);
                        command.Parameters.AddWithValue("@Ad", textBoxAd.Text);
                        command.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
                        command.Parameters.AddWithValue("@Numara1", textBoxNumara1.Text);
                        command.Parameters.AddWithValue("@Numara2", textBoxNumara2.Text);
                        command.Parameters.AddWithValue("@Mail", textBoxMail.Text);
                        command.Parameters.AddWithValue("@EvAdres", textBoxEvAdres.Text);
                        command.Parameters.AddWithValue("@İşAdres", textBoxİşAdres.Text);
                        command.Parameters.AddWithValue("@Twitter", textBoxTwitter.Text);
                        command.Parameters.AddWithValue("@Facebook", textBoxFacebook.Text);
                        command.Parameters.AddWithValue("@Instagram", textBoxİnstagram.Text);
                        command.Parameters.AddWithValue("@WebSitesi", textBoxWebSitesi.Text);
                        command.Parameters.AddWithValue("@DoğumGünü", textBoxDoğumGünü.Text);
                        command.Parameters.AddWithValue("@ID", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    MessageBox.Show("Satır güncellendi.");
                }
            }
        }

        private void buttonRehber_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            string baglantiDizisi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deneme1.accdb";
            OleDbConnection baglanti = new OleDbConnection(baglantiDizisi);
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string sorgu = "SELECT * FROM deneme1";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                DataTable tablo = new DataTable();
                tablo.Load(okuyucu);
                frm2.dataGridView1.DataSource = tablo;
            }
        }

        private void buttonFotoğrafEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            {
                Form2 frm2 = new Form2();
                byte[] imgBytes;
                ImageConverter converter = new ImageConverter();
                byte[] imgBytes = (byte[])frm2.dataGridView1.CurrentRow.Cells["Resim"].Value;
                imgBytes = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deneme1.accdb;Persist Security Info=False;");
                OleDbCommand cmd = new OleDbCommand("INSERT INTO [deneme1] ([Resim]) VALUES (@img)", con);
                cmd.Parameters.AddWithValue("@img", imgBytes);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resim başarıyla yüklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
