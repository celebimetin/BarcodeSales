using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fUrunGiris : Form
    {
        private readonly BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();

        public fUrunGiris()
        {
            InitializeComponent();
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            txtUrunSayisi.Text = db.Uruns.Count().ToString();
            dataGridViewUrunGiris.DataSource = db.Uruns.OrderByDescending(x => x.UrunId).Take(12).ToList();
            Islemler.DataGridViewDüzenle(dataGridViewUrunGiris);
            UrunGrupDolur();
        }

        public void UrunGrupDolur()
        {
            comboBoxUrunGrubu.DisplayMember = "UrunGrupAdi";
            comboBoxUrunGrubu.ValueMember = "UrunGrupId";
            comboBoxUrunGrubu.DataSource = db.UrunGrups.OrderBy(x => x.UrunGrupAdi).ToList();
        }

        private void Temizle()
        {
            txtBarkod.Clear();
            txtUrunAdi.Clear();
            comboBoxUrunGrubu.Text = "";
            txtAlisFiyati.Text = 0.ToString();
            txtSatisFiyati.Text = 0.ToString();
            txtMiktar.Text = 0.ToString();
            txtKdvOrani.Text = 8.ToString();
            txtBarkod.Focus();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" &&
                txtUrunAdi.Text != "" &&
                comboBoxUrunGrubu.Text != "" &&
                txtAlisFiyati.Text != "" &&
                txtSatisFiyati.Text != "" &&
                txtMiktar.Text != "" &&
                txtKdvOrani.Text != "")
            {
                if (db.Uruns.Any(x => x.Barkod == txtBarkod.Text))
                {
                    var urunGüncelle = db.Uruns.Where(x => x.Barkod == txtBarkod.Text).SingleOrDefault();
                    urunGüncelle.Barkod = txtBarkod.Text;
                    urunGüncelle.UrunAdi = txtUrunAdi.Text;
                    urunGüncelle.UrunGrup = comboBoxUrunGrubu.Text;
                    urunGüncelle.AlisFiyat = Convert.ToDouble(txtAlisFiyati.Text);
                    urunGüncelle.SatisFiyat = Convert.ToDouble(txtSatisFiyati.Text);
                    urunGüncelle.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
                    urunGüncelle.KdvTutari = Islemler.DoubleYap(txtSatisFiyati.Text) * Convert.ToInt32(txtKdvOrani.Text) / 100;
                    urunGüncelle.Miktar += Convert.ToDouble(txtMiktar.Text);
                    urunGüncelle.Birim = Convert.ToString(BirimTipi.Adet);
                    urunGüncelle.Tarih = DateTime.Now;
                    urunGüncelle.Kullanici = lblKullanici.Text;

                    db.SaveChanges();
                }
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = txtBarkod.Text;
                    urun.UrunAdi = txtUrunAdi.Text;
                    urun.UrunGrup = comboBoxUrunGrubu.Text;
                    urun.AlisFiyat = Convert.ToDouble(txtAlisFiyati.Text);
                    urun.SatisFiyat = Convert.ToDouble(txtSatisFiyati.Text);
                    urun.KdvOrani = Convert.ToInt32(txtKdvOrani.Text);
                    urun.KdvTutari = Islemler.DoubleYap(txtSatisFiyati.Text) * Convert.ToInt32(txtKdvOrani.Text) / 100;
                    urun.Miktar = Convert.ToDouble(txtMiktar.Text);
                    urun.Birim = Convert.ToString(BirimTipi.Adet);
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = lblKullanici.Text;

                    db.Uruns.Add(urun);
                    db.SaveChanges();

                    if (txtBarkod.Text.Length == 8)
                    {
                        var ozelBarkod = db.Barkods.First();
                        ozelBarkod.BarkodNo += 1;
                        db.SaveChanges();
                    }
                }
                Islemler.StokHaraketGiris(txtBarkod.Text, txtUrunAdi.Text, Convert.ToString(BirimTipi.Adet), Convert.ToDouble(txtMiktar.Text), comboBoxUrunGrubu.Text, lblKullanici.Text);
            }
            else
            {
                MessageBox.Show("Eksik alanları doldurunuz.");
                txtBarkod.Focus();
            }
            dataGridViewUrunGiris.DataSource = db.Uruns.OrderByDescending(x => x.UrunId).Take(12).ToList();
            Islemler.DataGridViewDüzenle(dataGridViewUrunGiris);
            Temizle();
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            fUrunGrubu fUrunGrubu = new fUrunGrubu();
            fUrunGrubu.ShowDialog();
        }

        private void btnBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodNo = db.Barkods.First();
            int barkodKarakter = barkodNo.BarkodNo.ToString().Length;
            string sifirler = string.Empty;

            for (int i = 0; i < 8 - barkodKarakter; i++)
            {
                sifirler = sifirler + "0";

            }
            string olusanBarkodNo = sifirler + barkodNo.BarkodNo.ToString();
            txtBarkod.Text = olusanBarkodNo;
            txtUrunAdi.Focus();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkod.Text.Trim();
                if (db.Uruns.Any(x => x.Barkod == barkod))
                {
                    var urun = db.Uruns.Where(x => x.Barkod == barkod).SingleOrDefault();
                    txtBarkod.Text = urun.Barkod;
                    txtUrunAdi.Text = urun.UrunAdi;
                    comboBoxUrunGrubu.Text = urun.UrunGrup;
                    txtAlisFiyati.Text = urun.AlisFiyat.ToString();
                    txtSatisFiyati.Text = urun.SatisFiyat.ToString();
                    txtMiktar.Text = urun.Miktar.ToString();
                    txtKdvOrani.Text = urun.KdvOrani.ToString();
                }
                else
                {
                    MessageBox.Show("Ürün kayıtlı değil");
                }
            }
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAra.Text.Length >= 2)
            {
                string urunAdi = txtUrunAra.Text;
                dataGridViewUrunGiris.DataSource = db.Uruns.Where(x => x.UrunAdi.Contains(urunAdi)).ToList();
                Islemler.DataGridViewDüzenle(dataGridViewUrunGiris);
            }
        }

        private void txtAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewUrunGiris.Rows.Count > 0)
            {
                int urunId = Convert.ToInt32(dataGridViewUrunGiris.CurrentRow.Cells["UrunId"].Value.ToString());
                string urunAdi = dataGridViewUrunGiris.CurrentRow.Cells["UrunAdi"].Value.ToString();
                string barkod = dataGridViewUrunGiris.CurrentRow.Cells["Barkod"].Value.ToString();

                DialogResult result = MessageBox.Show(urunAdi + " Ürünü silemek istediğinize emin misiniz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var urun = db.Uruns.Find(urunId);
                    db.Uruns.Remove(urun);
                    db.SaveChanges();

                    var hizliUrun = db.HizliUruns.Where(x => x.Barkod == barkod).SingleOrDefault();
                    hizliUrun.Barkod = "-";
                    hizliUrun.UrunAdi = "-";
                    hizliUrun.Fiyat = 0;
                    db.SaveChanges();

                    dataGridViewUrunGiris.DataSource = db.Uruns.OrderByDescending(x => x.UrunId).Take(12).ToList();
                    Islemler.DataGridViewDüzenle(dataGridViewUrunGiris);
                    txtBarkod.Focus();
                }
            }
        }
    }
}