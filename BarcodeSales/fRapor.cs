using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        private void fRapor_Load(object sender, EventArgs e)
        {
            listBoxFiltrelemeTuru.SelectedIndex = 0;
            txtKartKomisyon.Text = Islemler.KartKomisyon().ToString();
            btnGoster_Click(null, null);
        }

        public void btnGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dateTimePickerBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dateTimePickerBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db = new BarcodeSalesDbEntities())
            {
                if (listBoxFiltrelemeTuru.SelectedIndex == 0) // Tümü Getir
                {
                    db.IslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzets.Local.ToBindingList();
                    dataGridViewRapor.DataSource = islemOzet;

                    txtSatisNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    txtSatisKrediKarti.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.KrediKarti)).ToString("C2");

                    txtIadeNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    txtIadeKrediKarti.Text = Convert.ToDouble(islemOzet.Where(x => x.Iade == true).Sum(x => x.KrediKarti)).ToString("C2");

                    txtGelirNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    txtGelirKrediKarti.Text = Convert.ToDouble(islemOzet.Where(x => x.Gelir == true).Sum(x => x.KrediKarti)).ToString("C2");

                    txtGiderNakit.Text = Convert.ToDouble(islemOzet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    txtGiderKrediKarti.Text = Convert.ToDouble(islemOzet.Where(x => x.Gider == true).Sum(x => x.KrediKarti)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satisTablosu = db.Satis.Local.ToBindingList();
                    double kdvTutarSatisi = Islemler.DoubleYap(satisTablosu.Where(x => x.Iade == false).Sum(x => x.KdvTutar).ToString());
                    double kdvTutariIade = Islemler.DoubleYap(satisTablosu.Where(x => x.Iade == true).Sum(x => x.KdvTutar).ToString());

                    txtKdvToplam.Text = (kdvTutarSatisi - kdvTutariIade).ToString("C2");
                }
                else if (listBoxFiltrelemeTuru.SelectedIndex == 1) // Satışlar Listele
                {
                    db.IslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gelir == false && x.Gider == false).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzets.Local.ToBindingList();
                    dataGridViewRapor.DataSource = islemOzet;
                }
                else if (listBoxFiltrelemeTuru.SelectedIndex == 2) // İade Listele
                {
                    db.IslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzets.Local.ToBindingList();
                    dataGridViewRapor.DataSource = islemOzet;
                }
                else if (listBoxFiltrelemeTuru.SelectedIndex == 3) // Gelir Listele
                {
                    db.IslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzets.Local.ToBindingList();
                    dataGridViewRapor.DataSource = islemOzet;
                }
                else if (listBoxFiltrelemeTuru.SelectedIndex == 4) // Gider Listele
                {
                    db.IslemOzets.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).OrderByDescending(x => x.Tarih).Load();
                    var islemOzet = db.IslemOzets.Local.ToBindingList();
                    dataGridViewRapor.DataSource = islemOzet;
                }
            }
            Islemler.DataGridViewDüzenle(dataGridViewRapor);
            Cursor.Current = Cursors.Default;
        }

        private void dataGridViewRapor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider fGelirGider = new fGelirGider();
            fGelirGider.GelirGider = "Gelir";
            fGelirGider.Kullanici = lblKullanici.Text;
            fGelirGider.ShowDialog();
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider fGelirGider = new fGelirGider();
            fGelirGider.GelirGider = "Gider";
            fGelirGider.Kullanici = lblKullanici.Text;
            fGelirGider.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRapor.Rows.Count > 0)
            {
                int islemNo = Convert.ToInt32(dataGridViewRapor.CurrentRow.Cells["IslemNoId"].Value.ToString());
                if (islemNo != 0)
                {
                    fDetayGoster fDetayGoster = new fDetayGoster();
                    fDetayGoster.IslemNo = islemNo;
                    fDetayGoster.ShowDialog();
                }
            }
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "Genel Rapor";
            Raporlar.SatisNakit = txtSatisNakit.Text;
            Raporlar.SatisKart = txtSatisKrediKarti.Text;
            Raporlar.IadeNakit = txtIadeNakit.Text;
            Raporlar.IadeKart = txtIadeKrediKarti.Text;
            Raporlar.GelirNakit = txtGelirNakit.Text;
            Raporlar.GelirKart = txtGelirKrediKarti.Text;
            Raporlar.GiderKart = txtGiderKrediKarti.Text;
            Raporlar.GiderNakit = txtGiderNakit.Text;
            Raporlar.TarihBaslangic = dateTimePickerBaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = dateTimePickerBitis.Value.ToShortDateString();
            Raporlar.KdvToplam = txtKdvToplam.Text;
            Raporlar.KartKomisyon = txtKartKomisyon.Text;

            Raporlar.RaporSayfasiRaporu(dataGridViewRapor);
        }
    }
}