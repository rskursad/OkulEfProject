namespace OkulEFAppProject
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
            grpOgrenci = new GroupBox();
            button1 = new Button();
            lblOEtiket = new Label();
            label2 = new Label();
            cmbSinif = new ComboBox();
            btnDersSecimi = new Button();
            btnSil = new Button();
            btnBul = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtNum = new TextBox();
            grpSinif = new GroupBox();
            button2 = new Button();
            lblSEtiket = new Label();
            label3 = new Label();
            btnSSil = new Button();
            btnSBul = new Button();
            btnSGuncelle = new Button();
            btnSEkle = new Button();
            txtSinifKontenjan = new TextBox();
            txtSinifAd = new TextBox();
            tabControl = new TabControl();
            tabOgrenciler = new TabPage();
            tabSiniflar = new TabPage();
            tabDersler = new TabPage();
            grpDers = new GroupBox();
            button3 = new Button();
            lblDEtiket = new Label();
            label5 = new Label();
            btnDSil = new Button();
            btnDBul = new Button();
            btnDGuncelle = new Button();
            btnDEkle = new Button();
            txtDersAd = new TextBox();
            txtDersKod = new TextBox();
            grpOgrenci.SuspendLayout();
            grpSinif.SuspendLayout();
            tabControl.SuspendLayout();
            tabOgrenciler.SuspendLayout();
            tabSiniflar.SuspendLayout();
            tabDersler.SuspendLayout();
            grpDers.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenci
            // 
            grpOgrenci.Controls.Add(button1);
            grpOgrenci.Controls.Add(lblOEtiket);
            grpOgrenci.Controls.Add(label2);
            grpOgrenci.Controls.Add(cmbSinif);
            grpOgrenci.Controls.Add(btnDersSecimi);
            grpOgrenci.Controls.Add(btnSil);
            grpOgrenci.Controls.Add(btnBul);
            grpOgrenci.Controls.Add(btnGuncelle);
            grpOgrenci.Controls.Add(btnEkle);
            grpOgrenci.Controls.Add(txtSoyad);
            grpOgrenci.Controls.Add(txtAd);
            grpOgrenci.Controls.Add(txtNum);
            grpOgrenci.Location = new Point(0, 0);
            grpOgrenci.Name = "grpOgrenci";
            grpOgrenci.Size = new Size(350, 310);
            grpOgrenci.TabIndex = 0;
            grpOgrenci.TabStop = false;
            grpOgrenci.Text = "Öğrenciler";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 35);
            button1.Name = "button1";
            button1.Size = new Size(90, 24);
            button1.TabIndex = 12;
            button1.Text = "Sıfırla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSifirla_Clicked;
            // 
            // lblOEtiket
            // 
            lblOEtiket.AutoSize = true;
            lblOEtiket.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblOEtiket.Location = new Point(102, 19);
            lblOEtiket.Name = "lblOEtiket";
            lblOEtiket.Size = new Size(181, 15);
            lblOEtiket.TabIndex = 11;
            lblOEtiket.Tag = "";
            lblOEtiket.Text = "(EKLE veya BUL işlemi yapınız!)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 19);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 10;
            label2.Text = "AKTİF ÖĞRENCİ:";
            // 
            // cmbSinif
            // 
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(48, 165);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(237, 23);
            cmbSinif.TabIndex = 5;
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.BackColor = Color.DarkSlateGray;
            btnDersSecimi.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDersSecimi.ForeColor = Color.White;
            btnDersSecimi.Location = new Point(48, 230);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(237, 54);
            btnDersSecimi.TabIndex = 9;
            btnDersSecimi.Tag = "2";
            btnDersSecimi.Text = "DERS SEÇİMİ";
            btnDersSecimi.UseVisualStyleBackColor = false;
            btnDersSecimi.Click += btnDersSecimi_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkSlateGray;
            btnSil.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(220, 194);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 30);
            btnSil.TabIndex = 8;
            btnSil.Tag = "2";
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.DarkSlateGray;
            btnBul.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnBul.ForeColor = Color.White;
            btnBul.Location = new Point(220, 80);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(75, 23);
            btnBul.TabIndex = 2;
            btnBul.Text = "BUL";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkSlateGray;
            btnGuncelle.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(119, 194);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(95, 30);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Tag = "2";
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += button1_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkSlateGray;
            btnEkle.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(38, 194);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 30);
            btnEkle.TabIndex = 6;
            btnEkle.Tag = "1";
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(114, 138);
            txtSoyad.MaxLength = 20;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.PlaceholderText = "SOYAD";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 4;
            txtSoyad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(114, 109);
            txtAd.MaxLength = 20;
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "AD";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 3;
            txtAd.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(114, 80);
            txtNum.MaxLength = 20;
            txtNum.Name = "txtNum";
            txtNum.PlaceholderText = "NUMARA";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 0;
            txtNum.TextAlign = HorizontalAlignment.Center;
            // 
            // grpSinif
            // 
            grpSinif.Controls.Add(button2);
            grpSinif.Controls.Add(lblSEtiket);
            grpSinif.Controls.Add(label3);
            grpSinif.Controls.Add(btnSSil);
            grpSinif.Controls.Add(btnSBul);
            grpSinif.Controls.Add(btnSGuncelle);
            grpSinif.Controls.Add(btnSEkle);
            grpSinif.Controls.Add(txtSinifKontenjan);
            grpSinif.Controls.Add(txtSinifAd);
            grpSinif.Location = new Point(3, 3);
            grpSinif.Name = "grpSinif";
            grpSinif.Size = new Size(361, 306);
            grpSinif.TabIndex = 7;
            grpSinif.TabStop = false;
            grpSinif.Text = "Sınıflar";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 37);
            button2.Name = "button2";
            button2.Size = new Size(72, 24);
            button2.TabIndex = 14;
            button2.Text = "Sıfırla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSifirla_Clicked;
            // 
            // lblSEtiket
            // 
            lblSEtiket.AutoSize = true;
            lblSEtiket.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblSEtiket.Location = new Point(81, 19);
            lblSEtiket.Name = "lblSEtiket";
            lblSEtiket.Size = new Size(181, 15);
            lblSEtiket.TabIndex = 13;
            lblSEtiket.Tag = "";
            lblSEtiket.Text = "(EKLE veya BUL işlemi yapınız!)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(5, 19);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "AKTİF SINIF:";
            // 
            // btnSSil
            // 
            btnSSil.BackColor = Color.DarkSlateGray;
            btnSSil.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnSSil.ForeColor = Color.White;
            btnSSil.Location = new Point(220, 171);
            btnSSil.Name = "btnSSil";
            btnSSil.Size = new Size(75, 31);
            btnSSil.TabIndex = 6;
            btnSSil.Tag = "4";
            btnSSil.Text = "SİL";
            btnSSil.UseVisualStyleBackColor = false;
            btnSSil.Click += btnSil_Click;
            // 
            // btnSBul
            // 
            btnSBul.BackColor = Color.DarkSlateGray;
            btnSBul.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnSBul.ForeColor = Color.White;
            btnSBul.Location = new Point(220, 112);
            btnSBul.Name = "btnSBul";
            btnSBul.Size = new Size(75, 23);
            btnSBul.TabIndex = 2;
            btnSBul.Text = "BUL";
            btnSBul.UseVisualStyleBackColor = false;
            btnSBul.Click += btnBul_Click;
            // 
            // btnSGuncelle
            // 
            btnSGuncelle.BackColor = Color.DarkSlateGray;
            btnSGuncelle.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnSGuncelle.ForeColor = Color.White;
            btnSGuncelle.Location = new Point(114, 171);
            btnSGuncelle.Name = "btnSGuncelle";
            btnSGuncelle.Size = new Size(100, 31);
            btnSGuncelle.TabIndex = 5;
            btnSGuncelle.Tag = "4";
            btnSGuncelle.Text = "GÜNCELLE";
            btnSGuncelle.UseVisualStyleBackColor = false;
            btnSGuncelle.Click += button1_Click;
            // 
            // btnSEkle
            // 
            btnSEkle.BackColor = Color.DarkSlateGray;
            btnSEkle.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnSEkle.ForeColor = Color.White;
            btnSEkle.Location = new Point(33, 171);
            btnSEkle.Name = "btnSEkle";
            btnSEkle.Size = new Size(75, 31);
            btnSEkle.TabIndex = 4;
            btnSEkle.Tag = "3";
            btnSEkle.Text = "EKLE";
            btnSEkle.UseVisualStyleBackColor = false;
            btnSEkle.Click += btnEkle_Click;
            // 
            // txtSinifKontenjan
            // 
            txtSinifKontenjan.Font = new Font("Arial", 9F);
            txtSinifKontenjan.Location = new Point(114, 142);
            txtSinifKontenjan.Name = "txtSinifKontenjan";
            txtSinifKontenjan.PlaceholderText = "Kontenjan";
            txtSinifKontenjan.Size = new Size(100, 21);
            txtSinifKontenjan.TabIndex = 3;
            txtSinifKontenjan.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSinifAd
            // 
            txtSinifAd.Font = new Font("Arial", 9F);
            txtSinifAd.Location = new Point(114, 113);
            txtSinifAd.MaxLength = 20;
            txtSinifAd.Name = "txtSinifAd";
            txtSinifAd.PlaceholderText = "Sınıf Ad";
            txtSinifAd.Size = new Size(100, 21);
            txtSinifAd.TabIndex = 1;
            txtSinifAd.TextAlign = HorizontalAlignment.Center;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOgrenciler);
            tabControl.Controls.Add(tabSiniflar);
            tabControl.Controls.Add(tabDersler);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(358, 338);
            tabControl.TabIndex = 9;
            tabControl.Tag = "";
            // 
            // tabOgrenciler
            // 
            tabOgrenciler.BackColor = Color.Linen;
            tabOgrenciler.Controls.Add(grpOgrenci);
            tabOgrenciler.Location = new Point(4, 24);
            tabOgrenciler.Name = "tabOgrenciler";
            tabOgrenciler.Padding = new Padding(3);
            tabOgrenciler.Size = new Size(350, 310);
            tabOgrenciler.TabIndex = 0;
            tabOgrenciler.Text = "Öğrenciler";
            // 
            // tabSiniflar
            // 
            tabSiniflar.BackColor = Color.Linen;
            tabSiniflar.Controls.Add(grpSinif);
            tabSiniflar.Location = new Point(4, 24);
            tabSiniflar.Name = "tabSiniflar";
            tabSiniflar.Padding = new Padding(3);
            tabSiniflar.Size = new Size(350, 310);
            tabSiniflar.TabIndex = 1;
            tabSiniflar.Text = "Sınıflar";
            // 
            // tabDersler
            // 
            tabDersler.BackColor = Color.Linen;
            tabDersler.Controls.Add(grpDers);
            tabDersler.ForeColor = SystemColors.ActiveCaptionText;
            tabDersler.Location = new Point(4, 24);
            tabDersler.Name = "tabDersler";
            tabDersler.Padding = new Padding(3);
            tabDersler.Size = new Size(350, 310);
            tabDersler.TabIndex = 2;
            tabDersler.Text = "Dersler";
            // 
            // grpDers
            // 
            grpDers.Controls.Add(button3);
            grpDers.Controls.Add(lblDEtiket);
            grpDers.Controls.Add(label5);
            grpDers.Controls.Add(btnDSil);
            grpDers.Controls.Add(btnDBul);
            grpDers.Controls.Add(btnDGuncelle);
            grpDers.Controls.Add(btnDEkle);
            grpDers.Controls.Add(txtDersAd);
            grpDers.Controls.Add(txtDersKod);
            grpDers.Location = new Point(2, 2);
            grpDers.Name = "grpDers";
            grpDers.Size = new Size(361, 306);
            grpDers.TabIndex = 8;
            grpDers.TabStop = false;
            grpDers.Text = "Sınıflar";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.Font = new Font("Arial", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(6, 37);
            button3.Name = "button3";
            button3.Size = new Size(70, 24);
            button3.TabIndex = 16;
            button3.Text = "Sıfırla";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnSifirla_Clicked;
            // 
            // lblDEtiket
            // 
            lblDEtiket.AutoSize = true;
            lblDEtiket.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblDEtiket.Location = new Point(82, 19);
            lblDEtiket.Name = "lblDEtiket";
            lblDEtiket.Size = new Size(181, 15);
            lblDEtiket.TabIndex = 15;
            lblDEtiket.Tag = "";
            lblDEtiket.Text = "(EKLE veya BUL işlemi yapınız!)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 14;
            label5.Text = "AKTİF DERS:";
            // 
            // btnDSil
            // 
            btnDSil.BackColor = Color.DarkSlateGray;
            btnDSil.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnDSil.ForeColor = Color.White;
            btnDSil.Location = new Point(219, 171);
            btnDSil.Name = "btnDSil";
            btnDSil.Size = new Size(75, 30);
            btnDSil.TabIndex = 6;
            btnDSil.Tag = "6";
            btnDSil.Text = "SİL";
            btnDSil.UseVisualStyleBackColor = false;
            btnDSil.Click += btnSil_Click;
            // 
            // btnDBul
            // 
            btnDBul.BackColor = Color.DarkSlateGray;
            btnDBul.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnDBul.ForeColor = Color.White;
            btnDBul.Location = new Point(219, 112);
            btnDBul.Name = "btnDBul";
            btnDBul.Size = new Size(75, 23);
            btnDBul.TabIndex = 2;
            btnDBul.Text = "BUL";
            btnDBul.UseVisualStyleBackColor = false;
            btnDBul.Click += btnBul_Click;
            // 
            // btnDGuncelle
            // 
            btnDGuncelle.BackColor = Color.DarkSlateGray;
            btnDGuncelle.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnDGuncelle.ForeColor = Color.White;
            btnDGuncelle.Location = new Point(113, 171);
            btnDGuncelle.Name = "btnDGuncelle";
            btnDGuncelle.Size = new Size(100, 30);
            btnDGuncelle.TabIndex = 5;
            btnDGuncelle.Tag = "6";
            btnDGuncelle.Text = "GÜNCELLE";
            btnDGuncelle.UseVisualStyleBackColor = false;
            btnDGuncelle.Click += button1_Click;
            // 
            // btnDEkle
            // 
            btnDEkle.BackColor = Color.DarkSlateGray;
            btnDEkle.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnDEkle.ForeColor = Color.White;
            btnDEkle.Location = new Point(32, 171);
            btnDEkle.Name = "btnDEkle";
            btnDEkle.Size = new Size(75, 30);
            btnDEkle.TabIndex = 4;
            btnDEkle.Tag = "5";
            btnDEkle.Text = "EKLE";
            btnDEkle.UseVisualStyleBackColor = false;
            btnDEkle.Click += btnEkle_Click;
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(113, 142);
            txtDersAd.MaxLength = 20;
            txtDersAd.Name = "txtDersAd";
            txtDersAd.PlaceholderText = "Ders Ad";
            txtDersAd.Size = new Size(100, 23);
            txtDersAd.TabIndex = 3;
            txtDersAd.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDersKod
            // 
            txtDersKod.Location = new Point(113, 113);
            txtDersKod.MaxLength = 10;
            txtDersKod.Name = "txtDersKod";
            txtDersKod.PlaceholderText = "Ders Kod";
            txtDersKod.Size = new Size(100, 23);
            txtDersKod.TabIndex = 1;
            txtDersKod.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(381, 358);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            grpOgrenci.ResumeLayout(false);
            grpOgrenci.PerformLayout();
            grpSinif.ResumeLayout(false);
            grpSinif.PerformLayout();
            tabControl.ResumeLayout(false);
            tabOgrenciler.ResumeLayout(false);
            tabSiniflar.ResumeLayout(false);
            tabDersler.ResumeLayout(false);
            grpDers.ResumeLayout(false);
            grpDers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenci;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtNum;
        private Button btnEkle;
        private GroupBox grpGuncelle;
        private Button btnGuncelle;
        private TextBox txtGSoyad;
        private TextBox txtGAd;
        private TextBox txtGNum;
        private Label lblOEtiket;
        private Button btnSil;
        private Button btnBul;
        private GroupBox grpSinif;
        private Button btnSSil;
        private Button btnSBul;
        private Button btnSGuncelle;
        private Button btnSEkle;
        private TextBox txtSinifKontenjan;
        private TextBox txtSinifAd;
        private Button btnDersSecimi;
        private TabPage tabOgrenciler;
        private TabPage tabSiniflar;
        public TabControl tabControl;
        private TabPage tabDersler;
        private GroupBox grpDers;
        private Button btnDSil;
        private Button btnDBul;
        private Button btnDGuncelle;
        private Button btnDEkle;
        private TextBox txtDersAd;
        private TextBox txtDersKod;
        private ComboBox cmbSinif;
        private Label label2;
        private Label lblSEtiket;
        private Label label3;
        private Label lblDEtiket;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
