using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fUrunGrubu : Form
    {
        private readonly BarcodeSalesDbEntities db = new BarcodeSalesDbEntities();

        public fUrunGrubu()
        {
            InitializeComponent();
        }

        private void fUrunGrubu_Load(object sender, EventArgs e)
        {
            UrunGrupDolur();
        }

        private void btnUrunGrubuKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunGrubuAdi.Text != "")
            {
                UrunGrup urunGrup = new UrunGrup();
                urunGrup.UrunGrupAdi = txtUrunGrubuAdi.Text;

                db.UrunGrups.Add(urunGrup);
                db.SaveChanges();
                UrunGrupDolur();
                txtUrunGrubuAdi.Clear();

                fUrunGiris fUrunGiris = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (fUrunGiris != null)
                    fUrunGiris.UrunGrupDolur();
            }
            else
            {
                MessageBox.Show("Ürün Grup Adı boş olamaz.");
            }

        }

        private void btnUrunGrubuSil_Click(object sender, EventArgs e)
        {
            int grupId = Convert.ToInt32(listBoxUrunGrubu.SelectedValue);
            string grupAdi = listBoxUrunGrubu.Text;
            DialogResult deleteOnay = MessageBox.Show(grupAdi + " Grubunu silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (deleteOnay == DialogResult.Yes)
            {
                var removeUrunGrup = db.UrunGrups.FirstOrDefault(x => x.UrunGrupId == grupId);
                db.UrunGrups.Remove(removeUrunGrup);
                db.SaveChanges();
                UrunGrupDolur();
                txtUrunGrubuAdi.Focus();

                fUrunGiris fUrunGiris = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (fUrunGiris != null)
                    fUrunGiris.UrunGrupDolur();
            }
        }

        private void UrunGrupDolur()
        {
            listBoxUrunGrubu.DisplayMember = "UrunGrupAdi";
            listBoxUrunGrubu.ValueMember = "UrunGrupId";
            listBoxUrunGrubu.DataSource = db.UrunGrups.OrderBy(x => x.UrunGrupAdi).ToList();
        }
    }
}