﻿using System;
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

        private void fSatis_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
            txtMiktar.Text = 1.ToString();
            btn5TL.Text = 5.ToString("C2");
            btn10TL.Text = 10.ToString("C2");
            btn20TL.Text = 20.ToString("C2");
            btn50TL.Text = 50.ToString("C2");
            btn100TL.Text = 100.ToString("C2");
            btn200TL.Text = 200.ToString("C2");
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
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvUrunAdi"].Value = urun.UrunAdi;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvMiktar"].Value = miktar;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvFiyat"].Value = urun.SatisFiyat;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvToplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvKdvTutari"].Value = urun.SatisFiyat * urun.KdvOrani / 100;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvBirim"].Value = urun.Birim;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvUrunGrup"].Value = urun.UrunGrup;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvAlisFiyati"].Value = urun.AlisFiyat;
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
            txtMiktar.Text = "1";
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

        private void HizliButonDoldur()
        {
            var hizliUrun = db.HizliUruns.ToList();
            foreach (var item in hizliUrun)
            {
                Button btnHizli = this.Controls.Find("btnHizli" + item.HizliUrunId, true).FirstOrDefault() as Button;
                if (btnHizli != null)
                {
                    double fiyat = Islemler.DoubleYap(item.Fiyat.ToString());
                    btnHizli.Text = item.UrunAdi + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void HizliButonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int btnId = Convert.ToInt32(btn.Name.ToString().Substring(8, btn.Name.Length - 8));
            if (btn.Text.ToString().StartsWith("-"))
            {
                fHizliButonUrunEkle form = new fHizliButonUrunEkle();
                form.lblButonId.Text = btnId.ToString();
                form.ShowDialog();
            }
            else
            {
                var urunBarkod = db.HizliUruns.Where(x => x.HizliUrunId == btnId).Select(x => x.Barkod).FirstOrDefault();
                var urun = db.Uruns.Where(x => x.Barkod == urunBarkod).FirstOrDefault();
                ListeyeUrunGetir(urun, urunBarkod, Convert.ToDouble(txtMiktar.Text));
                GenelToplam();
            }
        }

        private void bh_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = (Button)sender;
                if (!btn.Text.StartsWith("-"))
                {
                    int btnId = Convert.ToInt32(btn.Name.ToString().Substring(8, btn.Name.Length - 8));
                    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                    toolStripMenuItem.Text = "Temizle - Buton No:" + btnId.ToString();
                    toolStripMenuItem.Click += ToolStripMenuItem_Click;
                    contextMenuStrip.Items.Add(toolStripMenuItem);
                    this.ContextMenuStrip = contextMenuStrip;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int btnId = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUruns.Find(btnId);
            guncelle.Barkod = "-";
            guncelle.UrunAdi = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();

            double fiyat = 0;
            Button btn = this.Controls.Find("btnHizli" + btnId, true).FirstOrDefault() as Button;
            btn.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void btnNumarator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == ",")
            {
                int virgul = txtTusTakimiNumarator.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    txtTusTakimiNumarator.Text += btn.Text;
                }
            }
            else if (btn.Text == "Sil")
            {
                if (txtTusTakimiNumarator.Text.Length > 0)
                {
                    txtTusTakimiNumarator.Text = txtTusTakimiNumarator.Text.Substring(0, txtTusTakimiNumarator.Text.Length - 1);
                }
            }
            else
            {
                txtTusTakimiNumarator.Text += btn.Text;
            }
        }

        private void btnAdet_Click(object sender, EventArgs e)
        {
            if (txtTusTakimiNumarator.Text != "")
            {
                txtMiktar.Text = txtTusTakimiNumarator.Text;
                txtTusTakimiNumarator.Clear();
                txtBarkod.Clear();
                txtBarkod.Focus();
            }
        }

        private void btnOdenen_Click(object sender, EventArgs e)
        {
            if (txtTusTakimiNumarator.Text != "")
            {
                double paraUstuSonuc = Islemler.DoubleYap(txtGenelToplam.Text) - Islemler.DoubleYap(txtTusTakimiNumarator.Text);
                txtParaUstu.Text = paraUstuSonuc.ToString("C2");
                double odenenSonuc = Convert.ToDouble(txtTusTakimiNumarator.Text);
                txtOdenen.Text = odenenSonuc.ToString("C2");
                txtTusTakimiNumarator.Clear();
                txtBarkod.Focus();
            }
        }

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            if (txtTusTakimiNumarator.Text != "")
            {
                if (db.Uruns.Any(x => x.Barkod == txtTusTakimiNumarator.Text))
                {
                    var urun = db.Uruns.Where(x => x.Barkod == txtTusTakimiNumarator.Text).FirstOrDefault();
                    ListeyeUrunGetir(urun, txtTusTakimiNumarator.Text, Convert.ToDouble(txtMiktar.Text));
                    txtTusTakimiNumarator.Clear();
                    txtBarkod.Focus();
                }
                else
                {

                }
            }
        }

        private void ParaUstuHesapla_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double paraUstuSonuc = Islemler.DoubleYap(txtGenelToplam.Text) - Islemler.DoubleYap(btn.Text);
            txtParaUstu.Text = paraUstuSonuc.ToString("C2");
            double odenenSonuc = Islemler.DoubleYap(btn.Text);
            txtOdenen.Text = odenenSonuc.ToString("C2");
        }

        private void btnDigerUrun_Click(object sender, EventArgs e)
        {
            if (txtTusTakimiNumarator.Text != "")
            {
                int satirSayisi = dataGridViewSatisListesi.Rows.Count;
                dataGridViewSatisListesi.Rows.Add();
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvBarkod"].Value = "1111111111116";
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvUrunAdi"].Value = "Barkodsuz Ürün";
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvUrunGrup"].Value = "Barkodsuz Ürün";
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvBirim"].Value = "Adet";
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvMiktar"].Value = 1;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvKdvTutari"].Value = 0;
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvFiyat"].Value = Convert.ToDouble(txtTusTakimiNumarator.Text);
                dataGridViewSatisListesi.Rows[satirSayisi].Cells["gvToplam"].Value = Convert.ToDouble(txtTusTakimiNumarator.Text);

                GenelToplam();
                txtTusTakimiNumarator.Text = "";
                txtBarkod.Focus();
            }
        }

        private void btnIadeIslemi_Click(object sender, EventArgs e)
        {
            if (chSatisIadeIslemi.Checked)
            {
                chSatisIadeIslemi.Checked = false;
                chSatisIadeIslemi.Text = "Satış Yapılıyor";
            }
            else
            {
                chSatisIadeIslemi.Checked = true;
                chSatisIadeIslemi.Text = "İade işlemi";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtMiktar.Text = "1";
            txtBarkod.Clear();
            txtParaUstu.Clear();
            txtOdenen.Clear();
            txtGenelToplam.Clear();
            txtTusTakimiNumarator.Clear();
            dataGridViewSatisListesi.Rows.Clear();
            txtBarkod.Clear();
            txtBarkod.Focus();
            chSatisIadeIslemi.Checked = false;
        }

        private void btnFisYazdir_Click(object sender, EventArgs e)
        {

        }

        private void SatisYap(string odemeSekli)
        {

        }
    }
}