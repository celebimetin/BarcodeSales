
namespace BarcodeSales
{
    partial class fGelirGider
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
            this.lblGelirGider = new BarcodeSales.lblStandart();
            this.lblStandart2 = new BarcodeSales.lblStandart();
            this.comboBoxOdemeTuru = new System.Windows.Forms.ComboBox();
            this.txtNakit = new BarcodeSales.txtNumeric();
            this.txtKart = new BarcodeSales.txtNumeric();
            this.lblStandart3 = new BarcodeSales.lblStandart();
            this.lblStandart4 = new BarcodeSales.lblStandart();
            this.lblStandart5 = new BarcodeSales.lblStandart();
            this.txtAciklama = new BarcodeSales.txtStandart();
            this.lblStandart6 = new BarcodeSales.lblStandart();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new BarcodeSales.btnStandart();
            this.SuspendLayout();
            // 
            // lblGelirGider
            // 
            this.lblGelirGider.AutoSize = true;
            this.lblGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGelirGider.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGelirGider.Location = new System.Drawing.Point(13, 13);
            this.lblGelirGider.Name = "lblGelirGider";
            this.lblGelirGider.Size = new System.Drawing.Size(104, 25);
            this.lblGelirGider.TabIndex = 0;
            this.lblGelirGider.Text = "Gelir Gider";
            // 
            // lblStandart2
            // 
            this.lblStandart2.AutoSize = true;
            this.lblStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart2.Location = new System.Drawing.Point(12, 61);
            this.lblStandart2.Name = "lblStandart2";
            this.lblStandart2.Size = new System.Drawing.Size(123, 25);
            this.lblStandart2.TabIndex = 1;
            this.lblStandart2.Text = "Ödeme Türü";
            // 
            // comboBoxOdemeTuru
            // 
            this.comboBoxOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOdemeTuru.FormattingEnabled = true;
            this.comboBoxOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Nakit-Kart"});
            this.comboBoxOdemeTuru.Location = new System.Drawing.Point(12, 89);
            this.comboBoxOdemeTuru.Name = "comboBoxOdemeTuru";
            this.comboBoxOdemeTuru.Size = new System.Drawing.Size(250, 28);
            this.comboBoxOdemeTuru.TabIndex = 5;
            this.comboBoxOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxOdemeTuru_SelectedIndexChanged);
            // 
            // txtNakit
            // 
            this.txtNakit.BackColor = System.Drawing.Color.White;
            this.txtNakit.Enabled = false;
            this.txtNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNakit.Location = new System.Drawing.Point(13, 166);
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(117, 30);
            this.txtNakit.TabIndex = 6;
            this.txtNakit.Text = "0";
            this.txtNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKart
            // 
            this.txtKart.BackColor = System.Drawing.Color.White;
            this.txtKart.Enabled = false;
            this.txtKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKart.Location = new System.Drawing.Point(136, 166);
            this.txtKart.Name = "txtKart";
            this.txtKart.Size = new System.Drawing.Size(127, 30);
            this.txtKart.TabIndex = 7;
            this.txtKart.Text = "0";
            this.txtKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStandart3
            // 
            this.lblStandart3.AutoSize = true;
            this.lblStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart3.Location = new System.Drawing.Point(13, 138);
            this.lblStandart3.Name = "lblStandart3";
            this.lblStandart3.Size = new System.Drawing.Size(56, 25);
            this.lblStandart3.TabIndex = 8;
            this.lblStandart3.Text = "Nakit";
            // 
            // lblStandart4
            // 
            this.lblStandart4.AutoSize = true;
            this.lblStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart4.Location = new System.Drawing.Point(131, 138);
            this.lblStandart4.Name = "lblStandart4";
            this.lblStandart4.Size = new System.Drawing.Size(48, 25);
            this.lblStandart4.TabIndex = 9;
            this.lblStandart4.Text = "Kart";
            // 
            // lblStandart5
            // 
            this.lblStandart5.AutoSize = true;
            this.lblStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart5.Location = new System.Drawing.Point(13, 219);
            this.lblStandart5.Name = "lblStandart5";
            this.lblStandart5.Size = new System.Drawing.Size(92, 25);
            this.lblStandart5.TabIndex = 10;
            this.lblStandart5.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAciklama.Location = new System.Drawing.Point(12, 248);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(251, 118);
            this.txtAciklama.TabIndex = 11;
            // 
            // lblStandart6
            // 
            this.lblStandart6.AutoSize = true;
            this.lblStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart6.Location = new System.Drawing.Point(18, 390);
            this.lblStandart6.Name = "lblStandart6";
            this.lblStandart6.Size = new System.Drawing.Size(57, 25);
            this.lblStandart6.TabIndex = 12;
            this.lblStandart6.Text = "Tarih";
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTarih.Location = new System.Drawing.Point(12, 418);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerTarih.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Image = global::BarcodeSales.Properties.Resources.new_document;
            this.btnEkle.Location = new System.Drawing.Point(12, 476);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(250, 62);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "     Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // fGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(282, 553);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.lblStandart6);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblStandart5);
            this.Controls.Add(this.lblStandart4);
            this.Controls.Add(this.lblStandart3);
            this.Controls.Add(this.txtKart);
            this.Controls.Add(this.txtNakit);
            this.Controls.Add(this.comboBoxOdemeTuru);
            this.Controls.Add(this.lblStandart2);
            this.Controls.Add(this.lblGelirGider);
            this.MaximumSize = new System.Drawing.Size(300, 600);
            this.MinimumSize = new System.Drawing.Size(300, 600);
            this.Name = "fGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GELİR GİDER İŞLEMLERİ";
            this.Load += new System.EventHandler(this.fGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lblStandart lblGelirGider;
        private lblStandart lblStandart2;
        private System.Windows.Forms.ComboBox comboBoxOdemeTuru;
        private txtNumeric txtNakit;
        private txtNumeric txtKart;
        private lblStandart lblStandart3;
        private lblStandart lblStandart4;
        private lblStandart lblStandart5;
        private txtStandart txtAciklama;
        private lblStandart lblStandart6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private btnStandart btnEkle;
    }
}