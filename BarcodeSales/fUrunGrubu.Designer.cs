
namespace BarcodeSales
{
    partial class fUrunGrubu
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
            this.lblStandart1 = new BarcodeSales.lblStandart();
            this.txtUrunGrubuAdi = new BarcodeSales.txtStandart();
            this.listBoxUrunGrubu = new System.Windows.Forms.ListBox();
            this.btnUrunGrubuKaydet = new BarcodeSales.btnStandart();
            this.btnUrunGrubuSil = new BarcodeSales.btnStandart();
            this.SuspendLayout();
            // 
            // lblStandart1
            // 
            this.lblStandart1.AutoSize = true;
            this.lblStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart1.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStandart1.Location = new System.Drawing.Point(13, 13);
            this.lblStandart1.Name = "lblStandart1";
            this.lblStandart1.Size = new System.Drawing.Size(147, 25);
            this.lblStandart1.TabIndex = 0;
            this.lblStandart1.Text = "Ürün Grubu Adı";
            // 
            // txtUrunGrubuAdi
            // 
            this.txtUrunGrubuAdi.BackColor = System.Drawing.Color.White;
            this.txtUrunGrubuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrunGrubuAdi.Location = new System.Drawing.Point(18, 42);
            this.txtUrunGrubuAdi.Name = "txtUrunGrubuAdi";
            this.txtUrunGrubuAdi.Size = new System.Drawing.Size(250, 30);
            this.txtUrunGrubuAdi.TabIndex = 1;
            // 
            // listBoxUrunGrubu
            // 
            this.listBoxUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUrunGrubu.FormattingEnabled = true;
            this.listBoxUrunGrubu.ItemHeight = 25;
            this.listBoxUrunGrubu.Location = new System.Drawing.Point(18, 79);
            this.listBoxUrunGrubu.Name = "listBoxUrunGrubu";
            this.listBoxUrunGrubu.Size = new System.Drawing.Size(250, 279);
            this.listBoxUrunGrubu.TabIndex = 2;
            // 
            // btnUrunGrubuKaydet
            // 
            this.btnUrunGrubuKaydet.BackColor = System.Drawing.Color.Blue;
            this.btnUrunGrubuKaydet.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnUrunGrubuKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGrubuKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunGrubuKaydet.ForeColor = System.Drawing.Color.White;
            this.btnUrunGrubuKaydet.Image = global::BarcodeSales.Properties.Resources.save;
            this.btnUrunGrubuKaydet.Location = new System.Drawing.Point(145, 368);
            this.btnUrunGrubuKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.btnUrunGrubuKaydet.Name = "btnUrunGrubuKaydet";
            this.btnUrunGrubuKaydet.Size = new System.Drawing.Size(123, 75);
            this.btnUrunGrubuKaydet.TabIndex = 0;
            this.btnUrunGrubuKaydet.Text = "Kaydet";
            this.btnUrunGrubuKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUrunGrubuKaydet.UseVisualStyleBackColor = false;
            this.btnUrunGrubuKaydet.Click += new System.EventHandler(this.btnUrunGrubuKaydet_Click);
            // 
            // btnUrunGrubuSil
            // 
            this.btnUrunGrubuSil.BackColor = System.Drawing.Color.Red;
            this.btnUrunGrubuSil.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnUrunGrubuSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGrubuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunGrubuSil.ForeColor = System.Drawing.Color.White;
            this.btnUrunGrubuSil.Image = global::BarcodeSales.Properties.Resources.remove;
            this.btnUrunGrubuSil.Location = new System.Drawing.Point(18, 368);
            this.btnUrunGrubuSil.Margin = new System.Windows.Forms.Padding(1);
            this.btnUrunGrubuSil.Name = "btnUrunGrubuSil";
            this.btnUrunGrubuSil.Size = new System.Drawing.Size(125, 75);
            this.btnUrunGrubuSil.TabIndex = 0;
            this.btnUrunGrubuSil.Text = "Sil";
            this.btnUrunGrubuSil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUrunGrubuSil.UseVisualStyleBackColor = false;
            this.btnUrunGrubuSil.Click += new System.EventHandler(this.btnUrunGrubuSil_Click);
            // 
            // fUrunGrubu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(282, 453);
            this.Controls.Add(this.btnUrunGrubuSil);
            this.Controls.Add(this.btnUrunGrubuKaydet);
            this.Controls.Add(this.listBoxUrunGrubu);
            this.Controls.Add(this.txtUrunGrubuAdi);
            this.Controls.Add(this.lblStandart1);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "fUrunGrubu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN GRUBU İŞLEMLERİ";
            this.Load += new System.EventHandler(this.fUrunGrubu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lblStandart lblStandart1;
        private txtStandart txtUrunGrubuAdi;
        private System.Windows.Forms.ListBox listBoxUrunGrubu;
        private btnStandart btnUrunGrubuKaydet;
        private btnStandart btnUrunGrubuSil;
    }
}