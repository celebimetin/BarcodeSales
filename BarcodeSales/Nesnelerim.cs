using System.Drawing;
using System.Windows.Forms;

namespace BarcodeSales
{
    class Nesnelerim
    {
    }

    class lblStandart : Label
    {
        public lblStandart()
        {
            this.ForeColor = Color.DarkSlateGray;
            this.Text = "lblStandart";
            this.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.Name = "lblStandart";
        }
    }

    class btnStandart : Button
    {
        public btnStandart()
        {
            this.BackColor = Color.LimeGreen;
            this.FlatAppearance.BorderColor = Color.LimeGreen;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ForeColor = Color.Black;
            this.Image = global::BarcodeSales.Properties.Resources.cash;
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "btnNakit";
            this.Size = new System.Drawing.Size(101, 155);
            this.TabIndex = 0;
            this.Text = "NAKİT\r\n(F1)";
            this.TextImageRelation = TextImageRelation.TextAboveImage;
            this.UseVisualStyleBackColor = false;
        }
    }

    class txtStandart : TextBox
    {
        public txtStandart()
        {
            this.Size = new Size(250, 26);
            this.BackColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 12F);
        }
    }

    class txtNumeric : TextBox
    {
        public txtNumeric()
        {
            this.Size = new Size(250, 26);
            this.BackColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 12F);
            this.Name = "txtNumaric";
            this.TextAlign = HorizontalAlignment.Right;
            this.Click += TxtNumeric_Click;
            this.KeyPress += TxtNumeric_KeyPress;
        }

        private void TxtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void TxtNumeric_Click(object sender, System.EventArgs e)
        {
            this.SelectAll();
        }
    }

    class ozelDataGridView : DataGridView
    {
        public ozelDataGridView()
        {
            this.AllowUserToAddRows = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = Color.LightBlue;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.DefaultCellStyle.BackColor = Color.LightBlue;
            this.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DefaultCellStyle.ForeColor = Color.White;
            this.DefaultCellStyle.Padding = new Padding(3);
            this.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            this.Dock = DockStyle.Fill;
            this.Location = new Point(3, 102);
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = "dataGridViewStandart";
            this.RowHeadersVisible = false;
            this.RowHeadersWidth = 51;
            this.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Padding = new Padding(3);
            this.RowsDefaultCellStyle = this.DefaultCellStyle;
            this.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
            this.RowTemplate.Height = 30;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Size = new Size(560, 466);
        }
    }
}