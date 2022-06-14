using System;
using System.Diagnostics;
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
                TeraziOnEkDoldur();
                SabitlerDoldur();
            }
        }

        private void SabitlerDoldur()
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                var sabitler = db.Sabits.FirstOrDefault();
                txtKartKomisyon.Text = sabitler.KartKomisyon.ToString();
                checkBoxYazmaDurumu.Checked = (bool)sabitler.Yazici;

                txtIsyeriAdiSoyadi.Text = sabitler.AdSoyad;
                txtUnvan.Text = sabitler.Unvan;
                txtAdres.Text = sabitler.Adres;
            }
        }

        private void TeraziOnEkDoldur()
        {
            using (var db = new BarcodeSalesDbEntities())
            {
                var teraziOnEk = db.Terazis.ToList();
                comboBoxTeraziOnEk.DisplayMember = "TeraziOnEk";
                comboBoxTeraziOnEk.ValueMember = "TeraziId";
                comboBoxTeraziOnEk.DataSource = teraziOnEk;
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
            Cursor.Current = Cursors.WaitCursor;
            Doldur();
            Cursor.Current = Cursors.Default;
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

        private void btnKartKomisyonKaydet_Click(object sender, EventArgs e)
        {
            if (txtKartKomisyon.Text != "")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var sabit = db.Sabits.FirstOrDefault();
                    sabit.KartKomisyon = Convert.ToInt32(txtKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart komisyon tanımlandı.");

                    txtKartKomisyon.Clear();
                }
            }
            else
            {
                MessageBox.Show("Kart komisyon giriniz.");
            }
        }

        private void btnTeraziOnEkKaydet_Click(object sender, EventArgs e)
        {
            if (txtTeraziOnEk.Text != "")
            {
                int teraziOnEk = Convert.ToInt16(txtTeraziOnEk.Text);

                using (var db = new BarcodeSalesDbEntities())
                {
                    if (db.Terazis.Any(x => x.TeraziOnEk == teraziOnEk))
                    {
                        MessageBox.Show(teraziOnEk.ToString() + "Ön eki kayıtlı.");
                    }
                    else
                    {
                        Terazi terazi = new Terazi();
                        terazi.TeraziOnEk = teraziOnEk;
                        db.Terazis.Add(terazi);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler kayıt edilmiştir");

                        TeraziOnEkDoldur();

                        txtTeraziOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi ön ek giriniz.");
            }
        }

        private void btnTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            if (comboBoxTeraziOnEk.Text != "")
            {
                int onEkId = Convert.ToInt16(comboBoxTeraziOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(comboBoxTeraziOnEk.Text + "Ön eki silmek istiyormusunuz?", "Terazi Ön Ek Silme İşlemi", MessageBoxButtons.YesNo);

                if (onay == DialogResult.Yes)
                {
                    using (var db = new BarcodeSalesDbEntities())
                    {
                        var onEkTerazi = db.Terazis.Find(onEkId);
                        db.Terazis.Remove(onEkTerazi);
                        db.SaveChanges();

                        TeraziOnEkDoldur();
                        MessageBox.Show("Terazi ön ek silinmiştir");
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi ön ek seçiniz.");
            }
        }

        private void btnIsyeriBilgileriKaydet_Click(object sender, EventArgs e)
        {
            if (txtIsyeriAdiSoyadi.Text != "" && txtUnvan.Text != "" && txtAdres.Text != "")
            {
                using (var db = new BarcodeSalesDbEntities())
                {
                    var isyeriBilgileri = db.Sabits.FirstOrDefault();
                    isyeriBilgileri.AdSoyad = txtIsyeriAdiSoyadi.Text;
                    isyeriBilgileri.Unvan = txtUnvan.Text;
                    isyeriBilgileri.Adres = txtAdres.Text;

                    db.SaveChanges();
                    MessageBox.Show("İşyeri bilgileri güncellenmiştir.");

                    SabitlerDoldur();
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanları giriniz." + "\nAdı Soyadı \nUnvan \nAdres");
            }
        }

        private void btnYedektenYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\ProgramRestore.exe");
            Application.Exit();
        }
    }
}