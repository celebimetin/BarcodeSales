using System;
using System.Linq;
using System.Windows.Forms;

namespace BarcodeSales
{
    public partial class fNakitKart : Form
    {
        public fNakitKart()
        {
            InitializeComponent();
        }

        private void fNakitKart_Load(object sender, System.EventArgs e)
        {

        }

        private void txtNakitKartOdeme_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNakitKartOdeme.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    NakitKartHesapla();
                }
            }
        }

        private void btnNumarator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == ",")
            {
                int virgul = txtNakitKartOdeme.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    txtNakitKartOdeme.Text += btn.Text;
                }
            }
            else if (btn.Text == "Sil")
            {
                if (txtNakitKartOdeme.Text.Length > 0)
                {
                    txtNakitKartOdeme.Text = txtNakitKartOdeme.Text.Substring(0, txtNakitKartOdeme.Text.Length - 1);
                }
            }
            else
            {
                txtNakitKartOdeme.Text += btn.Text;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtNakitKartOdeme.Text != "")
            {
                NakitKartHesapla();
            }
        }

        private void NakitKartHesapla()
        {
            fSatis fSatis = (fSatis)Application.OpenForms["fSatis"];
            double nakit = Islemler.DoubleYap(txtNakitKartOdeme.Text);
            double genelToplam = Islemler.DoubleYap(fSatis.txtGenelToplam.Text);
            double kart = genelToplam - nakit;
            fSatis.lblNakit.Text = nakit.ToString("C2");
            fSatis.lblKart.Text = kart.ToString("C2");
            fSatis.SatisYap("Nakit Kart");
            this.Hide();
        }

        private void txtNakitKartOdeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }
    }
}