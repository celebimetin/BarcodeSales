using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                try
                {
                    using (var db = new BarcodeSalesDbEntities())
                    {
                        if (db.Kullanicis.Any())
                        {
                            var kullaniciBak = db.Kullanicis.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
                            if (kullaniciBak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                fBaslangic baslangic = new fBaslangic();
                                baslangic.btnSatisIslemi.Enabled = (bool)kullaniciBak.SatisIslemi;
                                baslangic.btnRaporlar.Enabled = (bool)kullaniciBak.Rapor;
                                baslangic.btnStok.Enabled = (bool)kullaniciBak.Stok;
                                baslangic.btnUrunGiris.Enabled = (bool)kullaniciBak.UrunGiris;
                                baslangic.btnFiyatGuncelle.Enabled = (bool)kullaniciBak.FiyatGuncelleme;
                                baslangic.btnAyarlar.Enabled = (bool)kullaniciBak.Ayarlar;
                                baslangic.btnBackup.Enabled = (bool)kullaniciBak.Yedekleme;

                                var isyeri = db.Sabits.FirstOrDefault();
                                baslangic.lblFirmaBilgisi.Text = isyeri.Unvan;

                                baslangic.lblKullanici.Text = kullaniciBak.AdiSoyadi;
                                baslangic.Show();
                                this.Hide();

                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı giriş Kullanıcı adı şifre kontrol ediniz.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
    }
}