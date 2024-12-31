using System.Drawing;
using System.Windows.Forms;

namespace OkulEFAppProject
{
    public partial class Form1 : Form
    {
        List<Sinif> sinifList;
        Ogrenci ogrenci;
        Sinif sinif;
        Ders ders;
        string varsayilanYazi = "(EKLE veya BUL i�lemi yap�n�z!)";
        public Form1()
        {
            InitializeComponent();
            tabControl.SelectedIndex = 0;
            using (var con = new OgrenciModel())
            {
                sinifList = con.tblSiniflar.ToList();
                sinifList.Capacity = sinifList.Count;
                
                //sinifList.Capacity= sinifList.Count;
                //cmbSinif.DataSource= sinifList;
            }
            cmbSinif.DataSource = sinifList;
            cmbSinif.DisplayMember = "SinifAd";
            cmbSinif.ValueMember = "SinifId";
            cmbSinif.SelectedIndex = -1;
            AktifPasifIslem(grpOgrenci, 1, 2);
            AktifPasifIslem(grpSinif, 3, 4);
            AktifPasifIslem(grpDers, 5, 6); 
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OgrenciModel())
                {
                    switch (tabControl.SelectedIndex)
                    {
                        case 0:
                            if (textboxBoslukKontrol(grpOgrenci))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            string num = txtNum.Text.Trim(), ad = txtAd.Text.Trim(), soyad = txtSoyad.Text.Trim();
                            Sinif sinif = null;
                            if (cmbSinif.SelectedItem != null) sinif = cmbSinif.SelectedItem as Sinif; 
                            if (sinif!=null)
                            {
                                int kontenjan = sinif.Kontenjan;
                                if (con.tblOgrenciler.Where(o=>o.SinifId==sinif.SinifId).Count()<kontenjan)
                                {
                                    var ogr = new Ogrenci() { Numara = num, Ad = ad, Soyad = soyad, SinifId = sinif.SinifId };
                                    con.tblOgrenciler.Add(ogr);
                                    this.ogrenci = ogr;
                                    AktifPasifIslem(grpOgrenci, 2, 1);
                                    con.SaveChanges();
                                    MessageBox.Show("Ba�ar�l�");
                                }
                                else MessageBox.Show("Bu s�n�f�n kontenjan� dolu!!!");
                            } 
                            break;
                        case 1:
                            if (textboxBoslukKontrol(grpSinif))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            string sinifAd = txtSinifAd.Text.Trim(); int sinifKontenjan = int.Parse(txtSinifKontenjan.Text.Trim());
                            var snf = new Sinif() { SinifAd = sinifAd, Kontenjan = sinifKontenjan };

                            con.tblSiniflar.Add(snf);
                            con.SaveChanges();
                            MessageBox.Show("Ba�ar�l�");
                            this.sinif = snf;
                            AktifPasifIslem(grpSinif, 4, 3);

                            break;
                        case 2:
                            if (textboxBoslukKontrol(grpDers))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            string dersKod = txtDersKod.Text.Trim(), dersAd = txtDersAd.Text.Trim();
                            var ders = new Ders() { DersKod = dersKod, DersAd = dersAd };
                            con.tblDersler.Add(ders);
                            con.SaveChanges();
                            MessageBox.Show("Ba�ar�l�");
                            this.ders = ders;
                            AktifPasifIslem(grpDers, 6, 5);
                            break;
                    }
                    
                    comboBoxGuncelle(con);
                    etiketAktiflikleriGuncelle();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "HATA", MessageBoxButtons.OK);

            }
            finally
            {
                temizle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//G�NCELLEME 
            try
            {
                using (var con = new OgrenciModel())
                {
                    string num = "", ad = "", soyad = "", sinifAd = "", dersKod = "", dersAd = "";
                    int sinifKontenjan = 0;
                    switch (tabControl.SelectedIndex)
                    {
                        case 0:
                            if (textboxBoslukKontrol(grpOgrenci))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            num = txtNum.Text.Trim(); ad = txtAd.Text.Trim(); soyad = txtSoyad.Text.Trim();
                            Sinif tempSinif = cmbSinif.SelectedItem != null ? cmbSinif.SelectedItem as Sinif : null;
                            
                            if (tempSinif!=null)
                            {
                                int kontenjan = tempSinif.Kontenjan;
                                if (con.tblOgrenciler.Where(o=>o.SinifId==tempSinif.SinifId).Count()<kontenjan)
                                {
                                    var ogr = ogrenci;
                                    ogr.Ad = ad;
                                    ogr.Soyad = soyad;
                                    ogr.Numara = num;

                                    ogr.SinifId = tempSinif.SinifId;
                                    var islem = MessageBox.Show("��renci Bilgilerini G�ncellemek istedi�inizden emin misiniz?", "Uyar�", MessageBoxButtons.YesNo);
                                    if (islem == DialogResult.Yes)
                                    {
                                        con.tblOgrenciler.Update(ogr);
                                        ogrenci = ogr;
                                        con.SaveChanges();
                                        MessageBox.Show("Ba�ar�l�");
                                    }
                                }
                                else MessageBox.Show("Se�ilen s�n�f�n kontenjan doludur.");
                            }
                            break;
                        case 1:
                            if (textboxBoslukKontrol(grpSinif))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            sinifAd = txtSinifAd.Text.Trim(); sinifKontenjan = int.Parse(txtSinifKontenjan.Text.Trim());
                            var snf = sinif;
                            snf.SinifAd = sinifAd; 
                            snf.Kontenjan = sinifKontenjan;
                            var islem1 = MessageBox.Show("S�n�f Kontenjan�n� G�ncellemek �stedi�inizden Emin misiniz?", "Uyar�", MessageBoxButtons.YesNo);
                            if (islem1 == DialogResult.Yes)
                            {
                                con.tblSiniflar.Update(snf);
                                this.sinif = snf;
                                con.SaveChanges();
                                MessageBox.Show("Ba�ar�l�");
                                comboBoxGuncelle(con);
                            }
                            break;
                        case 2:
                            if (textboxBoslukKontrol(grpDers))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            dersKod = txtDersKod.Text.Trim(); dersAd = txtDersAd.Text.Trim();
                            var ders = this.ders;
                            ders.DersKod = dersKod;
                            ders.DersAd = dersAd;
                            var islem2 = MessageBox.Show("Dersi G�ncellemek �stedi�inize Emin Misiniz?");
                            if (islem2 == DialogResult.Yes)
                            {
                                con.tblDersler.Update(ders);
                                this.ders = ders;
                                con.SaveChanges();
                                MessageBox.Show("Ba�ar�l�");
                            }

                            break;
                    }
                    
                   
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
            finally
            {
                temizle();
            }

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OgrenciModel())
                {
                    switch (tabControl.SelectedIndex)
                    {
                        case 0:
                            if (!string.IsNullOrEmpty(txtNum.Text))
                            {
                                var ogr = con.tblOgrenciler.FirstOrDefault(o => o.Numara == txtNum.Text.Trim());
                                if (ogr != null)
                                {
                                    MessageBox.Show("BULUNDU");
                                    ogrenci = ogr;
                                    txtAd.Text = ogr.Ad;
                                    txtSoyad.Text = ogr.Soyad;
                                    var ogrSinif = sinifList.FirstOrDefault(s => s.SinifId == ogr.SinifId);
                                    cmbSinif.SelectedItem = ogrSinif;
                                    bulunduMu(true);
                                }
                                else
                                {
                                    ogrenci = null;
                                    MessageBox.Show("BULUNAMADI!");
                                    bulunduMu(false);
                                }
                            }
                            else MessageBox.Show("Ge�erli bir numara girin!");

                            break;
                        case 1:
                            if (!string.IsNullOrEmpty(txtSinifAd.Text))
                            {
                                var snf = con.tblSiniflar.FirstOrDefault(s => s.SinifAd == txtSinifAd.Text.Trim());
                                if (snf != null)
                                {
                                    sinif= snf;
                                    MessageBox.Show("BULUNDU");
                                    txtSinifAd.Text = snf.SinifAd;
                                    txtSinifKontenjan.Text = "" + snf.Kontenjan;
                                    bulunduMu(true);
                                }
                                else
                                {
                                    sinif = null;
                                    MessageBox.Show("BULUNAMADI!");
                                    bulunduMu(false);
                                }
                            }
                            else MessageBox.Show("Ge�erli bir <S�n�f Ad�> girin!");
                            break;
                        case 2:
                            if (!string.IsNullOrEmpty(txtDersKod.Text))
                            {
                                var ders = con.tblDersler.FirstOrDefault(d => d.DersKod == txtDersKod.Text.Trim());
                                if (ders != null)
                                {
                                    this.ders = ders;
                                    MessageBox.Show("BULUNDU");
                                    txtDersKod.Text = ders.DersKod;
                                    txtDersAd.Text = "" + ders.DersAd;
                                    bulunduMu(true);
                                }
                                else
                                {
                                    this.ders = null;
                                    MessageBox.Show("BULUNAMADI!");
                                    bulunduMu(false);
                                }
                            }
                            else MessageBox.Show("Ge�erli bir <Ders Kodu> girin!");
                            break;
                    }
                    etiketAktiflikleriGuncelle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + ex.StackTrace); ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OgrenciModel())
                {
                    switch (tabControl.SelectedIndex)
                    {
                        case 0:
                            if (textboxBoslukKontrol(grpOgrenci))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            var ogr = ogrenci;
                            if (ogr != null)
                            {
                                var result = MessageBox.Show($"{ogr.Ad} {ogr.Soyad} isimli �ah�s silinecek. Onayl�yor musunuz?", "ONAY?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    con.tblOgrenciler.Remove(ogr);
                                }
                            }
                            else MessageBox.Show("Silme i�lemi i�in aktif ��renci yok!");
                            break;
                        case 1:
                            if (textboxBoslukKontrol(grpSinif))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            var sinif = this.sinif;
                            if (sinif != null)
                            {
                                var result = MessageBox.Show($"�sim: {sinif.SinifAd}\nKontenjan: {sinif.Kontenjan}\nBu s�n�f silinecek. Onayl�yor musunuz?", "ONAY?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    con.tblSiniflar.Remove(sinif);
                                }
                            }
                            else MessageBox.Show("Silme i�lemi i�in aktif s�n�f yok!");
                            break;
                        case 2:
                            if (textboxBoslukKontrol(grpDers))
                            {
                                MessageBox.Show("KUTUCUKLARI doldur!");
                                return;
                            }
                            var ders = this.ders;
                            if (ders != null)
                            {
                                var result = MessageBox.Show($"Kod: {ders.DersKod}\nAd: {ders.DersAd}\nBu ders silinecek. Onayl�yor musunuz?", "ONAY?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    con.tblDersler.Remove(ders);

                                }
                            }
                            else MessageBox.Show("Silme i�lemi i�in aktif ders yok!");
                            break;
                    }
                    con.SaveChanges();
                    MessageBox.Show("S�LME ��LEM� BA�ARILI");
                    comboBoxGuncelle(con);
                    bulunduMu(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n" + ex.StackTrace); ;
            }
            finally
            {
                temizle();
            }
        }


        void btnSifirla_Clicked(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: ogrenci = null; 
                    break;
                case 1: sinif = null;
                    break;
                case 2: ders = null;
                    break;
            }
            bulunduMu(false);
            temizle();
        }


        void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtNum.Text = "";
            txtDersAd.Text = "";
            txtDersKod.Text = "";
            txtSinifAd.Text = "";
            txtSinifKontenjan.Text = "";
            cmbSinif.SelectedIndex = -1;
        }

        void comboBoxGuncelle(OgrenciModel con)
        {
            sinifList = con.tblSiniflar.ToList();
            cmbSinif.DataSource = sinifList;
        }
        void etiketAktiflikleriGuncelle()
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (ogrenci != null) lblOEtiket.Text = $"{ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Numara}";
                    else lblOEtiket.Text = varsayilanYazi;
                    break;
                case 1:
                    if (sinif != null) lblSEtiket.Text = $"{sinif.SinifAd}-{sinif.Kontenjan}";
                    else lblSEtiket.Text = varsayilanYazi;
                    break;
                case 2:
                    if (ders != null) lblDEtiket.Text = $"{ders.DersKod} - {ders.DersAd}";
                    else lblDEtiket.Text = varsayilanYazi;
                    break;
            }
        }

        bool textboxBoslukKontrol(GroupBox grpBox)
        {
            bool kontrol = false;
            foreach (Control item in grpBox.Controls)
            {
                if (item is TextBox txt && txt.Text == String.Empty)
                {
                    kontrol = true;
                }
            }
            return kontrol;
        }

        void bulunduMu(bool bulundu)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (bulundu) AktifPasifIslem(grpOgrenci,2, 1);
                    else AktifPasifIslem(grpOgrenci, 1, 2);
                    break;
                case 1:
                    if (bulundu) AktifPasifIslem(grpSinif, 4, 3);
                    else AktifPasifIslem(grpSinif, 3, 4);
                    break;
                case 2:
                    if (bulundu) AktifPasifIslem(grpDers, 6, 5);
                    else AktifPasifIslem(grpDers, 5, 6);
                    break;

            }
            etiketAktiflikleriGuncelle();
        }

        void AktifPasifIslem(GroupBox grpbox, int etkinlestirilecekDugmeEtiketi, int etkisizlestirilecekDugmeEtiketi)
        {
            foreach (Control item in grpbox.Controls)
            {
                if (item is Button btn && btn.Tag != null && int.Parse(btn.Tag.ToString()) == etkinlestirilecekDugmeEtiketi)
                {
                    Button button = btn;
                    button.Enabled = true;
                }
                if (item is Button btn1 && btn1.Tag != null && int.Parse(btn1.Tag.ToString()) == etkisizlestirilecekDugmeEtiketi)
                {
                    Button button = btn1;
                    button.Enabled = false;
                }
            }
        }



        private void btnDersSecimi_Click(object sender, EventArgs e)
        {
            Form2 frm2=new Form2(ogrenci);
            frm2.Show();
        }
    }
}
