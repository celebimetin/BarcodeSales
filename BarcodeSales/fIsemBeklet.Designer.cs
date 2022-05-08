
namespace BarcodeSales
{
    partial class fIsemBeklet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewIslemBeklet = new System.Windows.Forms.DataGridView();
            this.gvBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvKdvTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvUrunGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSil = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemBeklet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIslemBeklet
            // 
            this.dataGridViewIslemBeklet.AllowUserToAddRows = false;
            this.dataGridViewIslemBeklet.AllowUserToDeleteRows = false;
            this.dataGridViewIslemBeklet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIslemBeklet.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewIslemBeklet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewIslemBeklet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIslemBeklet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIslemBeklet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIslemBeklet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvBarkod,
            this.gvUrunAdi,
            this.gvMiktar,
            this.gvFiyat,
            this.gvToplam,
            this.gvKdvTutari,
            this.gvBirim,
            this.gvUrunGrup,
            this.gvAlisFiyati,
            this.gvSil});
            this.dataGridViewIslemBeklet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIslemBeklet.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIslemBeklet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewIslemBeklet.Name = "dataGridViewIslemBeklet";
            this.dataGridViewIslemBeklet.ReadOnly = true;
            this.dataGridViewIslemBeklet.RowHeadersVisible = false;
            this.dataGridViewIslemBeklet.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewIslemBeklet.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewIslemBeklet.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewIslemBeklet.RowTemplate.Height = 30;
            this.dataGridViewIslemBeklet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIslemBeklet.Size = new System.Drawing.Size(824, 298);
            this.dataGridViewIslemBeklet.TabIndex = 2;
            // 
            // gvBarkod
            // 
            this.gvBarkod.HeaderText = "Barkod";
            this.gvBarkod.MinimumWidth = 6;
            this.gvBarkod.Name = "gvBarkod";
            this.gvBarkod.ReadOnly = true;
            // 
            // gvUrunAdi
            // 
            this.gvUrunAdi.HeaderText = "Ürün Adı";
            this.gvUrunAdi.MinimumWidth = 6;
            this.gvUrunAdi.Name = "gvUrunAdi";
            this.gvUrunAdi.ReadOnly = true;
            // 
            // gvMiktar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvMiktar.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMiktar.HeaderText = "Miktar";
            this.gvMiktar.MinimumWidth = 6;
            this.gvMiktar.Name = "gvMiktar";
            this.gvMiktar.ReadOnly = true;
            // 
            // gvFiyat
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.gvFiyat.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvFiyat.HeaderText = "Fiyat";
            this.gvFiyat.MinimumWidth = 6;
            this.gvFiyat.Name = "gvFiyat";
            this.gvFiyat.ReadOnly = true;
            // 
            // gvToplam
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.gvToplam.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvToplam.HeaderText = "Toplam";
            this.gvToplam.MinimumWidth = 6;
            this.gvToplam.Name = "gvToplam";
            this.gvToplam.ReadOnly = true;
            // 
            // gvKdvTutari
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.gvKdvTutari.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvKdvTutari.HeaderText = "Kdv Tutarı";
            this.gvKdvTutari.MinimumWidth = 6;
            this.gvKdvTutari.Name = "gvKdvTutari";
            this.gvKdvTutari.ReadOnly = true;
            this.gvKdvTutari.Visible = false;
            // 
            // gvBirim
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvBirim.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvBirim.HeaderText = "Birim";
            this.gvBirim.MinimumWidth = 6;
            this.gvBirim.Name = "gvBirim";
            this.gvBirim.ReadOnly = true;
            // 
            // gvUrunGrup
            // 
            this.gvUrunGrup.HeaderText = "Ürün Grup";
            this.gvUrunGrup.MinimumWidth = 6;
            this.gvUrunGrup.Name = "gvUrunGrup";
            this.gvUrunGrup.ReadOnly = true;
            this.gvUrunGrup.Visible = false;
            // 
            // gvAlisFiyati
            // 
            this.gvAlisFiyati.HeaderText = "Alış Fiyatı";
            this.gvAlisFiyati.MinimumWidth = 6;
            this.gvAlisFiyati.Name = "gvAlisFiyati";
            this.gvAlisFiyati.ReadOnly = true;
            this.gvAlisFiyati.Visible = false;
            // 
            // gvSil
            // 
            this.gvSil.HeaderText = "Sil";
            this.gvSil.Image = global::BarcodeSales.Properties.Resources.remove;
            this.gvSil.MinimumWidth = 6;
            this.gvSil.Name = "gvSil";
            this.gvSil.ReadOnly = true;
            this.gvSil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sil";
            this.dataGridViewImageColumn1.Image = global::BarcodeSales.Properties.Resources.remove;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 118;
            // 
            // fIsemBeklet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 298);
            this.Controls.Add(this.dataGridViewIslemBeklet);
            this.Name = "fIsemBeklet";
            this.Text = "İSLEM BEKLET";
            this.Load += new System.EventHandler(this.fIsemBeklet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemBeklet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvToplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvKdvTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvUrunGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAlisFiyati;
        private System.Windows.Forms.DataGridViewImageColumn gvSil;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridView dataGridViewIslemBeklet;
    }
}