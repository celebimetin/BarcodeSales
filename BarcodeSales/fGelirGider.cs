using System;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }

        public string GelirGider { get; set; }
        public string Kullanici { get; set; }

        private void fGelirGider_Load(object sender, EventArgs e)
        {
            lblGelirGider.Text = GelirGider + "İşlemi Yapılıyor";
        }

        private void comboBoxOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOdemeTuru.SelectedIndex == 0)
            {
                txtNakit.Enabled = true;
                txtKart.Enabled = false;
            }
            else if(comboBoxOdemeTuru.SelectedIndex == 1)
            {
                txtNakit.Enabled = false;
                txtKart.Enabled = true;
            }
            else if (comboBoxOdemeTuru.SelectedIndex == 2)
            {
                txtNakit.Enabled = true;
                txtKart.Enabled = true;
            }
            txtNakit.Text = "0";
            txtKart.Text = "0";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxOdemeTuru.Text != "")
            {
                if (txtNakit.Text != "" & txtKart.Text != "")
                {
                    using (var db = new BarcodeSalesDbEntities())
                    {
                        IslemOzet islemOzet = new IslemOzet();
                        islemOzet.IslemNoId = 0;
                        islemOzet.Iade = false;
                        islemOzet.OdemeSekli = comboBoxOdemeTuru.Text;
                        islemOzet.Nakit = Islemler.DoubleYap(txtNakit.Text);
                        islemOzet.KrediKarti = Islemler.DoubleYap(txtKart.Text);
                        if (GelirGider == "Gelir")
                        {
                            islemOzet.Gelir = true;
                            islemOzet.Gider = false;
                        }
                        else
                        {
                            islemOzet.Gelir = false;
                            islemOzet.Gider = true;
                        }
                        islemOzet.AlisFiyatToplam = 0;
                        islemOzet.Aciklama = GelirGider + " - İşlemi " + txtAciklama.Text;
                        islemOzet.Tarih = dateTimePickerTarih.Value;
                        islemOzet.Kullanici = Kullanici;

                        db.IslemOzets.Add(islemOzet);
                        db.SaveChanges();

                        txtNakit.Text = "0";
                        txtKart.Text = "0";
                        txtAciklama.Clear();
                        comboBoxOdemeTuru.Text = "";

                        fRapor fRapor = (fRapor)Application.OpenForms["fRapor"];
                        if (fRapor != null)
                        {
                            fRapor.btnGoster_Click(null, null);
                        }
                        this.Hide();
                    }
                }              
            }
            else
            {
                MessageBox.Show("Ödeme türü seçiniz.");
            }
        }
    }
}