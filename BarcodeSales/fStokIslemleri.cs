using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fStokIslemleri : Form
    {
        private readonly BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();

        public fStokIslemleri()
        {
            InitializeComponent();
        }

        private void fStokIslemleri_Load(object sender, EventArgs e)
        {
            UrunGrupDolur();
        }

        public void UrunGrupDolur()
        {
            comboBoxUrunGrubu.DisplayMember = "UrunGrupAdi";
            comboBoxUrunGrubu.ValueMember = "UrunGrupId";
            comboBoxUrunGrubu.DataSource = db.UrunGrups.OrderBy(x => x.UrunGrupAdi).ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridViewStok.DataSource = null;

            using (var db = new BarcodeSalesDbEntities())
            {
                if (comboBoxIslemTuru.Text != "")
                {
                    string urunGrup = comboBoxUrunGrubu.Text;

                    if (comboBoxIslemTuru.SelectedIndex == 0)
                    {
                        if (rdBtnTumu.Checked)
                        {
                            db.Uruns.OrderBy(x => x.Miktar).Load();
                            dataGridViewStok.DataSource = db.Uruns.Local.ToBindingList();
                        }
                        else if (rdBtnUrunGrubunaGore.Checked)
                        {
                            db.Uruns.Where(x => x.UrunGrup == urunGrup).OrderBy(x => x.Miktar).Load();
                            dataGridViewStok.DataSource = db.Uruns.Local.ToBindingList();
                        }
                    }
                    else if (comboBoxIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dateTimePickerBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateTimePickerBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);

                        if (rdBtnTumu.Checked)
                        {
                            db.StokHarakets.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            dataGridViewStok.DataSource = db.StokHarakets.Local.ToBindingList();
                        }
                        else if (rdBtnUrunGrubunaGore.Checked)
                        {
                            db.StokHarakets.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urunGrup)).Load();
                            dataGridViewStok.DataSource = db.StokHarakets.Local.ToBindingList();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Herhangi bir İşlem Türü seçili değil");
                }
            }
            Islemler.DataGridViewDüzenle(dataGridViewStok);
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAra.Text.Length >= 2)
            {
                string urunAdi = txtUrunAra.Text;

                using (var db = new BarcodeSalesDbEntities())
                {
                    if (comboBoxIslemTuru.SelectedIndex == 0)
                    {
                        db.Uruns.Where(x => x.UrunAdi.Contains(urunAdi)).Load();
                        dataGridViewStok.DataSource = db.Uruns.Local.ToBindingList();
                    }
                    else if (comboBoxUrunGrubu.SelectedIndex == 1)
                    {
                        db.StokHarakets.Where(x => x.UrunAdi.Contains(urunAdi)).Load();
                        dataGridViewStok.DataSource = db.StokHarakets.Local.ToBindingList();
                    }
                }
                Islemler.DataGridViewDüzenle(dataGridViewStok);
            }
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = comboBoxIslemTuru.Text + " Raporu";
            Raporlar.TarihBaslangic = dateTimePickerBaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = dateTimePickerBitis.Value.ToShortDateString();

            Raporlar.StokRaporu(dataGridViewStok);
        }
    }
}