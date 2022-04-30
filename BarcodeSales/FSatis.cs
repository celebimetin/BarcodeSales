using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //MessageBox.Show(textBarkod.Text);
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
                        //MessageBox.Show(urun.UrunAdı);
                        int satirSayisi = dataGridViewSatisListesi.Rows.Count;
                        double miktar = Convert.ToDouble(txtMiktar.Text);
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
                }
                dataGridViewSatisListesi.ClearSelection();
                GenelToplam();
                
            }
        }

        private void GenelToplam()
        {
            if (dataGridViewSatisListesi.Rows.Count > 0)
            {
                double toplam = 0;
                for (int i = 0; i < dataGridViewSatisListesi.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(dataGridViewSatisListesi.Rows[i].Cells["gvToplam"].Value);

                }
                txtGenelToplam.Text = toplam.ToString("C2");
                txtBarkod.Clear();
                txtBarkod.Focus();
            }
        }
    }
}