using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {
            lblBarkod.Text = "";
            lblUrunAdi.Text = "";
            lblMevcutFiyat.Text = "";
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    if (db.Uruns.Any(x => x.Barkod == txtBarkod.Text))
                    {
                        var urunGetir = db.Uruns.Where(x => x.Barkod == txtBarkod.Text).SingleOrDefault();
                        lblBarkod.Text = urunGetir.Barkod;
                        lblUrunAdi.Text = urunGetir.UrunAdi;
                        double mevcutFiyat = Convert.ToDouble(urunGetir.SatisFiyat.ToString());
                        lblMevcutFiyat.Text = mevcutFiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Bulunamadı.!");
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeniFiyat.Text != "" && lblBarkod.Text != "")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var guncellenecekUrun = db.Uruns.Where(x => x.Barkod == lblBarkod.Text).SingleOrDefault();
                    guncellenecekUrun.SatisFiyat = Islemler.DoubleYap(txtYeniFiyat.Text);
                    int kdvOrani = Convert.ToInt32(guncellenecekUrun.KdvOrani);
                    Math.Round(Islemler.DoubleYap(txtYeniFiyat.Text) * kdvOrani / 100, 2);
                    db.SaveChanges();

                    MessageBox.Show("Fiyat Güncellenmiştir.");

                    lblBarkod.Text = "";
                    lblUrunAdi.Text = "";
                    lblMevcutFiyat.Text = "";
                    txtBarkod.Clear();
                    txtYeniFiyat.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ürün Okutunuz.!");
            }
        }
    }
}