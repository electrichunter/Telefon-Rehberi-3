namespace Telefon_Rehberi_3;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

public partial class Form1 : Form

{
    public Form1()
    {
        InitializeComponent();
    }
    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deneme1.accdb");
    private void buttonKiþiyiKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            baglanti.Open();
            string sorgu = "INSERT INTO deneme1 (Ad,Soyad,Numara1,Numara2,Mail,EvAdres,ÝþAdres,Facebook,Twitter,Instagram,WebSitesi,DoðumGünü) VALUES (@Ad,@Soyad,@Numara1,@Numara2,@Mail,@EvAdres,@ÝþAdres,@Facebook,@Twitter,@Instagram,@WebSitesi,@DoðumGünü)";
            using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
            {
                
                komut.Parameters.AddWithValue("@Ad", textBoxAd.Text);
                komut.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
                komut.Parameters.AddWithValue("@Numara1", textBoxNumara1.Text);
                komut.Parameters.AddWithValue("@Numara2", textBoxNumara2.Text);
                komut.Parameters.AddWithValue("@Mail", textBoxMail.Text);
                komut.Parameters.AddWithValue("@EvAdres", textBoxEvAdres.Text);
                komut.Parameters.AddWithValue("@ÝþAdres", textBoxÝþAdres.Text);
                komut.Parameters.AddWithValue("@Facebook", textBoxFacebook.Text);
                komut.Parameters.AddWithValue("@Twitter", textBoxTwitter.Text);
                komut.Parameters.AddWithValue("@Instagram", textBoxÝnstagram.Text);
                komut.Parameters.AddWithValue("@WebSitesi", textBoxWebSitesi.Text);
                komut.Parameters.AddWithValue("@DoðumGünü", textBoxDoðumGünü.Text);
                komut.ExecuteNonQuery();
            }
            MessageBox.Show("Kiþi baþarýyla kaydedildi.");
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


    private void buttonFotoðrafEkle_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
        {
            byte[] imgBytes;
            ImageConverter converter = new ImageConverter();
            imgBytes = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=deneme1.accdb;Persist Security Info=False;");
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [deneme1] ([Resim]) VALUES (@img)", con);
            cmd.Parameters.AddWithValue("@img", imgBytes);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Resim baþarýyla yüklendi.");
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

    private byte[] GetImageBytes(Image image)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
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

    private void buttonKiþiBul_Click(object sender, EventArgs e)
    {
        Form2 frm2 = new Form2();
        frm2.Show();
        DataTable tablo = new DataTable();
        frm2.panel1.Visible = true;
    }
}
