using System;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtAdiSoyadi.Clear();
            maskedTextBoxTelefon.Clear();
            txtEPostaAdresi.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
            checkBoxAyarlar.Checked = false;
            checkBoxFiyatGuncelleme.Checked = false;
            checkBoxRapor.Checked = false;
            checkBoxSatis.Checked = false;
            checkBoxStok.Checked = false;
            checkBoxUrunGiris.Checked = false;
        }

        private void Doldur()
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                dataGridViewKullanici.DataSource = db.Kullanicis.Select(x => new { x.Id, x.AdiSoyadi, x.KullaniciAdi, x.Telefon, x.EPosta }).ToList();

                Islemler.SabitVarsayilan();
                var yaziciDurumu = db.Sabits.FirstOrDefault();
                checkBoxYazmaDurumu.Checked = (bool)yaziciDurumu.Yazici;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Kaydet")
            {
                if (txtAdiSoyadi.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "" && maskedTextBoxTelefon.Text != "")
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        using (var db = new BarcodeSalesDbEntities())
                        {
                            if (!db.Kullanicis.Any(x => x.KullaniciAdi == txtKullaniciAdi.Text))
                            {
                                Kullanici kullanici = new Kullanici();
                                kullanici.AdiSoyadi = txtAdiSoyadi.Text;
                                kullanici.Telefon = maskedTextBoxTelefon.Text;
                                kullanici.KullaniciAdi = txtKullaniciAdi.Text;
                                kullanici.Sifre = txtSifre.Text;
                                kullanici.EPosta = txtEPostaAdresi.Text;

                                kullanici.SatisIslemi = checkBoxSatis.Checked;
                                kullanici.Rapor = checkBoxRapor.Checked;
                                kullanici.Stok = checkBoxStok.Checked;
                                kullanici.UrunGiris = checkBoxUrunGiris.Checked;
                                kullanici.Ayarlar = checkBoxAyarlar.Checked;
                                kullanici.FiyatGuncelleme = checkBoxFiyatGuncelleme.Checked;

                                db.Kullanicis.Add(kullanici);
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcı kayıtlı");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen şifrenizi kontrol edin.!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu alanları giriniz." + "\nAdı Soyadı \nTelefon \nKullanıcı Adı \nŞifre \nŞifre Tekrarı");
                }
            }
            else if (btnKaydet.Text == "Güncelle")
            {
                if (txtAdiSoyadi.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "" && maskedTextBoxTelefon.Text != "")
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lblKullaniciId.Text);
                        using (var db = new BarcodeSalesDbEntities())
                        {
                            var guncellenecekKullanici = db.Kullanicis.Where(x => x.Id == id).FirstOrDefault();
                            guncellenecekKullanici.AdiSoyadi = txtAdiSoyadi.Text;
                            guncellenecekKullanici.Telefon = maskedTextBoxTelefon.Text;
                            guncellenecekKullanici.KullaniciAdi = txtKullaniciAdi.Text;
                            guncellenecekKullanici.Sifre = txtSifre.Text;
                            guncellenecekKullanici.EPosta = txtEPostaAdresi.Text;

                            guncellenecekKullanici.SatisIslemi = checkBoxSatis.Checked;
                            guncellenecekKullanici.Rapor = checkBoxRapor.Checked;
                            guncellenecekKullanici.Stok = checkBoxStok.Checked;
                            guncellenecekKullanici.UrunGiris = checkBoxUrunGiris.Checked;
                            guncellenecekKullanici.Ayarlar = checkBoxAyarlar.Checked;
                            guncellenecekKullanici.FiyatGuncelleme = checkBoxFiyatGuncelleme.Checked;

                            db.SaveChanges();
                            MessageBox.Show("Güncelleme yapılmıştır.");
                            btnKaydet.Text = "Kaydet";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen şifrenizi kontrol edin.!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu alanları giriniz." + "\nAdı Soyadı \nTelefon \nKullanıcı Adı \nŞifre \nŞifre Tekrarı");
                }
            }

            Temizle();
            Doldur();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lblKullaniciId.Text = id.ToString();

                using (var db = new BarcodeSalesDbEntities())
                {
                    var kullaniciGetir = db.Kullanicis.Where(x => x.Id == id).FirstOrDefault();

                    txtAdiSoyadi.Text = kullaniciGetir.AdiSoyadi;
                    maskedTextBoxTelefon.Text = kullaniciGetir.Telefon;
                    txtEPostaAdresi.Text = kullaniciGetir.EPosta;
                    txtKullaniciAdi.Text = kullaniciGetir.KullaniciAdi;
                    txtSifre.Text = kullaniciGetir.Sifre;
                    txtSifreTekrar.Text = kullaniciGetir.Sifre;

                    checkBoxAyarlar.Checked = (bool)kullaniciGetir.Ayarlar;
                    checkBoxFiyatGuncelleme.Checked = (bool)kullaniciGetir.FiyatGuncelleme;
                    checkBoxRapor.Checked = (bool)kullaniciGetir.Rapor;
                    checkBoxSatis.Checked = (bool)kullaniciGetir.SatisIslemi;
                    checkBoxStok.Checked = (bool)kullaniciGetir.Stok;
                    checkBoxUrunGiris.Checked = (bool)kullaniciGetir.UrunGiris;

                    btnKaydet.Text = "Güncelle";
                }
            }
            else
            {
                MessageBox.Show("Düzenlenecek kullanıcı seçiniz.");
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void checkBoxYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                if (checkBoxYazmaDurumu.Checked)
                {
                    Islemler.SabitVarsayilan();
                    var ayarlar = db.Sabits.FirstOrDefault();
                    ayarlar.Yazici = true;
                    db.SaveChanges();
                    checkBoxYazmaDurumu.Text = "Yazma Durumu Pasif";

                }
                else
                {
                    Islemler.SabitVarsayilan();
                    var ayarlar = db.Sabits.FirstOrDefault();
                    ayarlar.Yazici = false;
                    db.SaveChanges();
                    checkBoxYazmaDurumu.Text = "Yazma Durumu Aktif";
                }
            }
        }
    }
}