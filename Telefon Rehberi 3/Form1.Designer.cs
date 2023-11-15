namespace Telefon_Rehberi_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxNumara1 = new TextBox();
            buttonKişiyiKaydet = new Button();
            label12 = new Label();
            ımageList1 = new ImageList(components);
            textBoxDoğumGünü = new TextBox();
            groupBox1 = new GroupBox();
            label11 = new Label();
            textBoxWebSitesi = new TextBox();
            textBoxİnstagram = new TextBox();
            textBoxTwitter = new TextBox();
            textBoxFacebook = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxİşAdres = new TextBox();
            textBoxEvAdres = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxMail = new TextBox();
            textBoxNumara2 = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxAd = new TextBox();
            label1 = new Label();
            buttonFotoğrafEkle = new Button();
            pictureBox1 = new PictureBox();
            buttonKişiBul = new Button();
            buttonRehber = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNumara1
            // 
            textBoxNumara1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumara1.Location = new Point(163, 318);
            textBoxNumara1.MaxLength = 11;
            textBoxNumara1.Name = "textBoxNumara1";
            textBoxNumara1.PlaceholderText = "### ### ## ##";
            textBoxNumara1.Size = new Size(226, 32);
            textBoxNumara1.TabIndex = 76;
            // 
            // buttonKişiyiKaydet
            // 
            buttonKişiyiKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKişiyiKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKişiyiKaydet.ImageIndex = 5;
            buttonKişiyiKaydet.Location = new Point(608, 398);
            buttonKişiyiKaydet.Name = "buttonKişiyiKaydet";
            buttonKişiyiKaydet.Size = new Size(161, 45);
            buttonKişiyiKaydet.TabIndex = 75;
            buttonKişiyiKaydet.Text = "   Kişiyi Kaydet";
            buttonKişiyiKaydet.UseVisualStyleBackColor = true;
            buttonKişiyiKaydet.Click += buttonKişiyiKaydet_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ImageAlign = ContentAlignment.TopLeft;
            label12.ImageKey = "icons8-cake-48.ico";
            label12.ImageList = ımageList1;
            label12.Location = new Point(42, 138);
            label12.Name = "label12";
            label12.Size = new Size(123, 56);
            label12.TabIndex = 74;
            label12.Text = "      Doğum \r\n       Günü";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-cake-48.ico");
            ımageList1.Images.SetKeyName(1, "icons8-twitter-50.ico");
            ımageList1.Images.SetKeyName(2, "icons8-google-48.ico");
            ımageList1.Images.SetKeyName(3, "icons8-facebook-48.ico");
            ımageList1.Images.SetKeyName(4, "icons8-instagram-48.ico");
            // 
            // textBoxDoğumGünü
            // 
            textBoxDoğumGünü.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDoğumGünü.Location = new Point(32, 197);
            textBoxDoğumGünü.MaxLength = 10;
            textBoxDoğumGünü.Name = "textBoxDoğumGünü";
            textBoxDoğumGünü.PlaceholderText = "       00.00.0000";
            textBoxDoğumGünü.Size = new Size(163, 32);
            textBoxDoğumGünü.TabIndex = 73;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxWebSitesi);
            groupBox1.Controls.Add(textBoxİnstagram);
            groupBox1.Controls.Add(textBoxTwitter);
            groupBox1.Controls.Add(textBoxFacebook);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(413, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 191);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sosyal Medya";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.ImageKey = "icons8-google-48.ico";
            label11.ImageList = ımageList1;
            label11.Location = new Point(6, 157);
            label11.Name = "label11";
            label11.Size = new Size(130, 25);
            label11.TabIndex = 12;
            label11.Text = "      Web Sitesi";
            // 
            // textBoxWebSitesi
            // 
            textBoxWebSitesi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWebSitesi.Location = new Point(149, 150);
            textBoxWebSitesi.Name = "textBoxWebSitesi";
            textBoxWebSitesi.PlaceholderText = "www.#####.com";
            textBoxWebSitesi.Size = new Size(187, 30);
            textBoxWebSitesi.TabIndex = 11;
            // 
            // textBoxİnstagram
            // 
            textBoxİnstagram.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxİnstagram.Location = new Point(149, 112);
            textBoxİnstagram.Name = "textBoxİnstagram";
            textBoxİnstagram.PlaceholderText = "www.instagram.com";
            textBoxİnstagram.Size = new Size(187, 30);
            textBoxİnstagram.TabIndex = 10;
            // 
            // textBoxTwitter
            // 
            textBoxTwitter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTwitter.Location = new Point(149, 74);
            textBoxTwitter.Name = "textBoxTwitter";
            textBoxTwitter.PlaceholderText = "www.twitter.com";
            textBoxTwitter.Size = new Size(187, 30);
            textBoxTwitter.TabIndex = 9;
            // 
            // textBoxFacebook
            // 
            textBoxFacebook.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFacebook.Location = new Point(149, 36);
            textBoxFacebook.Name = "textBoxFacebook";
            textBoxFacebook.PlaceholderText = "www.facebook.com";
            textBoxFacebook.Size = new Size(187, 30);
            textBoxFacebook.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.ImageKey = "icons8-instagram-48.ico";
            label10.ImageList = ımageList1;
            label10.Location = new Point(6, 119);
            label10.Name = "label10";
            label10.Size = new Size(125, 25);
            label10.TabIndex = 7;
            label10.Text = "      İnstagram";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.ImageKey = "icons8-twitter-50.ico";
            label9.ImageList = ımageList1;
            label9.Location = new Point(6, 81);
            label9.Name = "label9";
            label9.Size = new Size(101, 25);
            label9.TabIndex = 6;
            label9.Text = "      Twitter";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.ImageKey = "icons8-facebook-48.ico";
            label8.ImageList = ımageList1;
            label8.Location = new Point(6, 43);
            label8.Name = "label8";
            label8.Size = new Size(119, 25);
            label8.TabIndex = 5;
            label8.Text = "      Facebook";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(439, 109);
            label7.Name = "label7";
            label7.Size = new Size(85, 28);
            label7.TabIndex = 71;
            label7.Text = "İş Adres";
            // 
            // textBoxİşAdres
            // 
            textBoxİşAdres.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxİşAdres.Location = new Point(539, 109);
            textBoxİşAdres.Multiline = true;
            textBoxİşAdres.Name = "textBoxİşAdres";
            textBoxİşAdres.Size = new Size(226, 85);
            textBoxİşAdres.TabIndex = 70;
            // 
            // textBoxEvAdres
            // 
            textBoxEvAdres.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEvAdres.Location = new Point(539, 12);
            textBoxEvAdres.Multiline = true;
            textBoxEvAdres.Name = "textBoxEvAdres";
            textBoxEvAdres.Size = new Size(226, 85);
            textBoxEvAdres.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(439, 11);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 68;
            label6.Text = "Ev Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 398);
            label5.Name = "label5";
            label5.Size = new Size(50, 28);
            label5.TabIndex = 67;
            label5.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 360);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 66;
            label4.Text = "Numara 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 322);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 65;
            label3.Text = "Numara 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 284);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 64;
            label2.Text = "Soyad";
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(163, 394);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "********@gmail.com";
            textBoxMail.Size = new Size(226, 32);
            textBoxMail.TabIndex = 63;
            // 
            // textBoxNumara2
            // 
            textBoxNumara2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumara2.Location = new Point(163, 356);
            textBoxNumara2.MaxLength = 11;
            textBoxNumara2.Name = "textBoxNumara2";
            textBoxNumara2.PlaceholderText = "### ### ## ##";
            textBoxNumara2.Size = new Size(226, 32);
            textBoxNumara2.TabIndex = 62;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSoyad.Location = new Point(163, 280);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(226, 32);
            textBoxSoyad.TabIndex = 61;
            // 
            // textBoxAd
            // 
            textBoxAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAd.Location = new Point(163, 242);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(226, 32);
            textBoxAd.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 249);
            label1.Name = "label1";
            label1.Size = new Size(37, 28);
            label1.TabIndex = 59;
            label1.Text = "Ad";
            // 
            // buttonFotoğrafEkle
            // 
            buttonFotoğrafEkle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFotoğrafEkle.Location = new Point(230, 200);
            buttonFotoğrafEkle.Name = "buttonFotoğrafEkle";
            buttonFotoğrafEkle.Size = new Size(133, 29);
            buttonFotoğrafEkle.TabIndex = 58;
            buttonFotoğrafEkle.Text = "Fotoğraf Ekle";
            buttonFotoğrafEkle.UseVisualStyleBackColor = true;
            buttonFotoğrafEkle.Click += buttonFotoğrafEkle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(213, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // buttonKişiBul
            // 
            buttonKişiBul.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKişiBul.ImageAlign = ContentAlignment.MiddleRight;
            buttonKişiBul.Location = new Point(32, 42);
            buttonKişiBul.Name = "buttonKişiBul";
            buttonKişiBul.Size = new Size(133, 29);
            buttonKişiBul.TabIndex = 56;
            buttonKişiBul.Text = "Kişi Bul";
            buttonKişiBul.UseVisualStyleBackColor = true;
            buttonKişiBul.Click += buttonKişiBul_Click;
            // 
            // buttonRehber
            // 
            buttonRehber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRehber.Location = new Point(32, 7);
            buttonRehber.Name = "buttonRehber";
            buttonRehber.Size = new Size(133, 29);
            buttonRehber.TabIndex = 55;
            buttonRehber.Text = "Rehber";
            buttonRehber.UseVisualStyleBackColor = true;
            buttonRehber.Click += buttonRehber_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxNumara1);
            Controls.Add(buttonKişiyiKaydet);
            Controls.Add(label12);
            Controls.Add(textBoxDoğumGünü);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(textBoxİşAdres);
            Controls.Add(textBoxEvAdres);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxNumara2);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(label1);
            Controls.Add(buttonFotoğrafEkle);
            Controls.Add(pictureBox1);
            Controls.Add(buttonKişiBul);
            Controls.Add(buttonRehber);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxNumara1;
        public Button buttonKişiyiKaydet;
        private Label label12;
        private ImageList ımageList1;
        public TextBox textBoxDoğumGünü;
        public GroupBox groupBox1;
        private Label label11;
        public TextBox textBoxWebSitesi;
        public TextBox textBoxİnstagram;
        public TextBox textBoxTwitter;
        public TextBox textBoxFacebook;
        private Label label10;
        private Label label9;
        private Label label8;
        public Label label7;
        public TextBox textBoxİşAdres;
        public TextBox textBoxEvAdres;
        public Label label6;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public TextBox textBoxMail;
        public TextBox textBoxNumara2;
        public TextBox textBoxSoyad;
        public TextBox textBoxAd;
        public Label label1;
        public Button buttonFotoğrafEkle;
        public PictureBox pictureBox1;
        public Button buttonKişiBul;
        public Button buttonRehber;
    }
}