using System;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fDetayGoster : Form
    {
        public fDetayGoster()
        {
            InitializeComponent();
        }
        public int IslemNo { get; set; }

        private void fDetayGoster_Load(object sender, EventArgs e)
        {
            lblIslemNo.Text = "İşlem No : " + IslemNo.ToString();
            using (var db = new BarcodeSalesDbEntities())
            {
                dataGridViewDeyatGoster.DataSource = db.Satis.Select(x => new { x.IslemNoId, x.UrunAdi, x.UrunGrup, x.Miktar, x.Toplam }).Where(x => x.IslemNoId == IslemNo).ToList();
            }
            Islemler.DataGridViewDüzenle(dataGridViewDeyatGoster);
        }
    }
}