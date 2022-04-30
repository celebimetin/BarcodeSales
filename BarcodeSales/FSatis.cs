using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fSatis : Form
    {
        BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();

        public fSatis()
        {
            InitializeComponent();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    txtMiktar.Text = barkod;
                    txtBarkod.Clear();
                    txtBarkod.Focus();
                }
                else
                {
                    if (db.Uruns.Any(u => u.Barkod == barkod))
                    {
                        var urun = db.Uruns.Where(x => x.Barkod == barkod).FirstOrDefault();
                        double miktar = Convert.ToDouble(txtMiktar.Text);
                        ListeyeUrunGetir(urun, barkod, miktar);
                    }
                    else
                    {
                        int teraziOnEk = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazis.Any(x => x.TeraziOnEk == teraziOnEk))
                        {
                            string teraziUrunNo = barkod.Substring(2, 5);
                            if (db.Uruns.Any(x => x.Barkod == teraziUrunNo))
                            {
                                var urunTerazi = db.Uruns.Where(x => x.Barkod == teraziUrunNo).FirstOrDefault();
                                double miktarKg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                ListeyeUrunGetir(urunTerazi, teraziUrunNo, miktarKg);
                            }
                            else
                            {
                                MessageBox.Show("Kg ürün yok ekleme sayfası yapılacak");
                            }
                        }
                        else
                        {
                            MessageBox.Show("normal ürün yok ekleme sayfası yapılacak");
                        }
                    }
                }
                dataGridViewSatisListesi.ClearSelection();
                GenelToplam();
            }
        }

        private void ListeyeUrunGetir(Urun urun, string barkod, double miktar)
        {
            int satirSayisi = dataGridViewSatisListesi.Rows.Count;
            bool eklenmismi = false;
            if (satirSayisi > 0)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (dataGridViewSatisListesi.Rows[i].Cells["gvBarkod"].Value.ToString() == barkod)
                    {
                        dataGridViewSatisListesi.Rows[i].Cells["gvMiktar"].Value = miktar + Convert.ToDouble(dataGridViewSatisListesi.Rows[i].Cells["gvMiktar"].Value);

                        dataGridViewSatisListesi.Rows[i].Cells["gvToplam"].Value = Math.Round(Convert.ToDouble(dataGridViewSatisListesi.Rows[i].Cells["gvMiktar"].Value) * Convert.ToDouble(dataGridViewSatisListesi.Rows[i].Cells["gvFiyat"].Value), 2);

                        eklenmismi = true;
                    }
                }
            }
            if (!eklenmismi)
            {
                dataGridViewSatisListesi.Rows.Add();
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvBarkod"].Value = barkod;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvUrunAdi"].Value = urun.UrunAdı;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvMiktar"].Value = miktar;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvFiyat"].Value = urun.SatisFiyat;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvToplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvKdvTutar"].Value = urun.SatisFiyat * urun.KdvOrani / 100;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvBirim"].Value = urun.Birim;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvUrunGrup"].Value = urun.UrunGrup;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvAlisFiyat"].Value = urun.AlisFiyat;
            }
        }

        private void GenelToplam()
        {
            double genelToplam = 0;
            for (int i = 0; i < dataGridViewSatisListesi.Rows.Count; i++)
            {
                genelToplam += Convert.ToDouble(dataGridViewSatisListesi.Rows[i].Cells["gvToplam"].Value);

            }
            txtGenelToplam.Text = genelToplam.ToString("C2");
            txtBarkod.Clear();
            txtBarkod.Focus();
        }

        private void dataGridViewSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                dataGridViewSatisListesi.Rows.Remove(dataGridViewSatisListesi.CurrentRow);
                dataGridViewSatisListesi.ClearSelection();
                GenelToplam();
                txtBarkod.Focus();
            }
        }
    }
}