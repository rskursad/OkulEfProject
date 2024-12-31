namespace OkulEFAppProject
{
    public partial class Form2 : Form
    {
        Ogrenci ogrenci;
        public Form2(Ogrenci ogr)
        {
            InitializeComponent();
            this.ogrenci = ogr;
            lblAd.Text = ogr.Ad;
            lblSoyad.Text = ogr.Soyad;
            lblNo.Text = ogr.Numara; 
            using (var con=new OgrenciModel())
            {
                table.DataSource = con.tblDersler.ToList(); 
            }
            table.MultiSelect = true;
            table.Columns[0].Visible = false;
            table.Columns[3].Visible = false;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        void dersleriKaydet(object sender,EventArgs e)
        {

            using (var con=new OgrenciModel())
            {
                var dersList = table.SelectedRows;
                foreach (DataGridViewRow row in dersList)
                {
                    if (row != null)
                    {
                        Ders ders = row.DataBoundItem as Ders;
                        if (ders != null)
                        {
                            OgrenciDers dersKayit = new OgrenciDers()
                            {
                                OgrenciId = ogrenci.OgrenciId,
                                DersId = ders.DersId
                            };
                            con.tblOgrenciDers.Add(dersKayit);
                        }
                    }
                }
                con.SaveChanges();
                var denemeList = con.tblOgrenciDers.ToList();
            }
        }
    }
}
