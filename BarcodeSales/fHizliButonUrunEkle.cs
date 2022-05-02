using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fHizliButonUrunEkle : Form
    {
        BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();

        public fHizliButonUrunEkle()
        {
            InitializeComponent();
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAra.Text != "")
            {
                var urunAdi = txtUrunAra.Text;
                var urunler = db.Uruns.Where(x => x.UrunAdi.Contains(urunAdi)).ToList();
                dataGridViewUrunEkleListesi.DataSource = urunler;
            }
        }

        private void dataGridViewUrunEkleListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUrunEkleListesi.Rows.Count > 0)
            {
                string barkod = dataGridViewUrunEkleListesi.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunAdi = dataGridViewUrunEkleListesi.CurrentRow.Cells["UrunAdı"].Value.ToString();
                double fiyat = Convert.ToDouble(dataGridViewUrunEkleListesi.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(lblButonId.Text);

                var guncellenekSatır = db.HizliUruns.Find(id);
                guncellenekSatır.Barkod = barkod;
                guncellenekSatır.UrunAdi = urunAdi;
                guncellenekSatır.Fiyat = fiyat;
                db.SaveChanges();

                MessageBox.Show("Buton tanımlaması yapıldı");

                fSatis form = (fSatis)Application.OpenForms["fSatis"];
                if (form != null)
                {
                    Button btn = form.Controls.Find("btnHizli" + id, true).FirstOrDefault() as Button;
                    btn.Text = urunAdi + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void checkBoxTumunuGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTumunuGoster.Checked)
            {
                dataGridViewUrunEkleListesi.DataSource = db.Uruns.ToList();
            }
            else
            {
                dataGridViewUrunEkleListesi.DataSource = null;
            }
        }
    }
}