namespace Telefon_Rehberi_3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            buttonKişiAra = new Button();
            buttonKişiyiSil = new Button();
            buttonDüzenle = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(860, 563);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1035, 546);
            label1.Name = "label1";
            label1.Size = new Size(153, 24);
            label1.TabIndex = 23;
            label1.Text = "Toplam Kayıt";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(buttonKişiAra);
            panel1.Location = new Point(463, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 79);
            panel1.TabIndex = 22;
            panel1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 27);
            textBox1.TabIndex = 0;
            // 
            // buttonKişiAra
            // 
            buttonKişiAra.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKişiAra.Location = new Point(118, 33);
            buttonKişiAra.Name = "buttonKişiAra";
            buttonKişiAra.Size = new Size(133, 29);
            buttonKişiAra.TabIndex = 2;
            buttonKişiAra.Text = "Kişi Ara";
            buttonKişiAra.UseVisualStyleBackColor = true;
            buttonKişiAra.Click += buttonKişiAra_Click;
            // 
            // buttonKişiyiSil
            // 
            buttonKişiyiSil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonKişiyiSil.Location = new Point(879, 546);
            buttonKişiyiSil.Name = "buttonKişiyiSil";
            buttonKişiyiSil.Size = new Size(133, 29);
            buttonKişiyiSil.TabIndex = 20;
            buttonKişiyiSil.Text = "Kişiyi Sil";
            buttonKişiyiSil.UseVisualStyleBackColor = true;
            buttonKişiyiSil.Click += buttonKişiyiSil_Click;
            // 
            // buttonDüzenle
            // 
            buttonDüzenle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDüzenle.Location = new Point(717, 546);
            buttonDüzenle.Name = "buttonDüzenle";
            buttonDüzenle.Size = new Size(133, 29);
            buttonDüzenle.TabIndex = 19;
            buttonDüzenle.Text = "Düzenle";
            buttonDüzenle.UseVisualStyleBackColor = true;
            buttonDüzenle.Click += buttonDüzenle_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1126, 41);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 25;
            button1.Text = "Kişi Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(33, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1226, 402);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 587);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(buttonKişiyiSil);
            Controls.Add(buttonDüzenle);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        public Panel panel1;
        public TextBox textBox1;
        public Button buttonKişiAra;
        public Button buttonKişiyiSil;
        public Button buttonDüzenle;
        public Button button1;
        public DataGridView dataGridView1;
    }
}