
namespace BarcodeSales
{
    partial class fStokIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblKullanici = new BarcodeSales.lblStandart();
            this.btnAra = new System.Windows.Forms.Button();
            this.panelIslemTuru = new System.Windows.Forms.Panel();
            this.comboBoxIslemTuru = new System.Windows.Forms.ComboBox();
            this.lblStandart2 = new BarcodeSales.lblStandart();
            this.panelTarih = new System.Windows.Forms.Panel();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblStandart5 = new BarcodeSales.lblStandart();
            this.lblStandart4 = new BarcodeSales.lblStandart();
            this.panelUrunGrubu = new System.Windows.Forms.Panel();
            this.comboBoxUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lblStandart3 = new BarcodeSales.lblStandart();
            this.panelFiltrelemeGrubu = new System.Windows.Forms.Panel();
            this.rdBtnUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.rdBtnTumu = new System.Windows.Forms.RadioButton();
            this.lblStandart1 = new BarcodeSales.lblStandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnRaporAl = new BarcodeSales.btnStandart();
            this.txtUrunAra = new BarcodeSales.txtStandart();
            this.lblStandart6 = new BarcodeSales.lblStandart();
            this.dataGridViewStok = new BarcodeSales.ozelDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelIslemTuru.SuspendLayout();
            this.panelTarih.SuspendLayout();
            this.panelUrunGrubu.SuspendLayout();
            this.panelFiltrelemeGrubu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.lblKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.btnAra);
            this.splitContainer1.Panel1.Controls.Add(this.panelIslemTuru);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarih);
            this.splitContainer1.Panel1.Controls.Add(this.panelUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.panelFiltrelemeGrubu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1102, 733);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKullanici.ForeColor = System.Drawing.Color.Black;
            this.lblKullanici.Location = new System.Drawing.Point(12, 704);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(89, 20);
            this.lblKullanici.TabIndex = 28;
            this.lblKullanici.Text = "lblKullanici";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Image = global::BarcodeSales.Properties.Resources.search;
            this.btnAra.Location = new System.Drawing.Point(10, 408);
            this.btnAra.Margin = new System.Windows.Forms.Padding(1);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(104, 70);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panelIslemTuru
            // 
            this.panelIslemTuru.Controls.Add(this.comboBoxIslemTuru);
            this.panelIslemTuru.Controls.Add(this.lblStandart2);
            this.panelIslemTuru.Location = new System.Drawing.Point(3, 3);
            this.panelIslemTuru.Name = "panelIslemTuru";
            this.panelIslemTuru.Size = new System.Drawing.Size(343, 67);
            this.panelIslemTuru.TabIndex = 6;
            // 
            // comboBoxIslemTuru
            // 
            this.comboBoxIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIslemTuru.FormattingEnabled = true;
            this.comboBoxIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.comboBoxIslemTuru.Location = new System.Drawing.Point(7, 34);
            this.comboBoxIslemTuru.Name = "comboBoxIslemTuru";
            this.comboBoxIslemTuru.Size = new System.Drawing.Size(329, 28);
            this.comboBoxIslemTuru.TabIndex = 4;
            // 
            // lblStandart2
            // 
            this.lblStandart2.AutoSize = true;
            this.lblStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart2.Location = new System.Drawing.Point(13, 5);
            this.lblStandart2.Name = "lblStandart2";
            this.lblStandart2.Size = new System.Drawing.Size(104, 25);
            this.lblStandart2.TabIndex = 3;
            this.lblStandart2.Text = "İşlem Türü";
            // 
            // panelTarih
            // 
            this.panelTarih.Controls.Add(this.dateTimePickerBitis);
            this.panelTarih.Controls.Add(this.dateTimePickerBaslangic);
            this.panelTarih.Controls.Add(this.lblStandart5);
            this.panelTarih.Controls.Add(this.lblStandart4);
            this.panelTarih.Location = new System.Drawing.Point(3, 257);
            this.panelTarih.Name = "panelTarih";
            this.panelTarih.Size = new System.Drawing.Size(343, 144);
            this.panelTarih.TabIndex = 5;
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBitis.Location = new System.Drawing.Point(15, 108);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(318, 26);
            this.dateTimePickerBitis.TabIndex = 3;
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(15, 39);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(318, 26);
            this.dateTimePickerBaslangic.TabIndex = 2;
            // 
            // lblStandart5
            // 
            this.lblStandart5.AutoSize = true;
            this.lblStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart5.Location = new System.Drawing.Point(9, 80);
            this.lblStandart5.Name = "lblStandart5";
            this.lblStandart5.Size = new System.Drawing.Size(102, 25);
            this.lblStandart5.TabIndex = 1;
            this.lblStandart5.Text = "Bitiş Tarihi";
            // 
            // lblStandart4
            // 
            this.lblStandart4.AutoSize = true;
            this.lblStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart4.Location = new System.Drawing.Point(10, 10);
            this.lblStandart4.Name = "lblStandart4";
            this.lblStandart4.Size = new System.Drawing.Size(151, 25);
            this.lblStandart4.TabIndex = 0;
            this.lblStandart4.Text = "Başlangıç Tarihi";
            // 
            // panelUrunGrubu
            // 
            this.panelUrunGrubu.Controls.Add(this.comboBoxUrunGrubu);
            this.panelUrunGrubu.Controls.Add(this.lblStandart3);
            this.panelUrunGrubu.Location = new System.Drawing.Point(3, 179);
            this.panelUrunGrubu.Name = "panelUrunGrubu";
            this.panelUrunGrubu.Size = new System.Drawing.Size(343, 72);
            this.panelUrunGrubu.TabIndex = 4;
            // 
            // comboBoxUrunGrubu
            // 
            this.comboBoxUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUrunGrubu.FormattingEnabled = true;
            this.comboBoxUrunGrubu.Location = new System.Drawing.Point(9, 39);
            this.comboBoxUrunGrubu.Name = "comboBoxUrunGrubu";
            this.comboBoxUrunGrubu.Size = new System.Drawing.Size(324, 28);
            this.comboBoxUrunGrubu.TabIndex = 1;
            // 
            // lblStandart3
            // 
            this.lblStandart3.AutoSize = true;
            this.lblStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart3.Location = new System.Drawing.Point(10, 11);
            this.lblStandart3.Name = "lblStandart3";
            this.lblStandart3.Size = new System.Drawing.Size(113, 25);
            this.lblStandart3.TabIndex = 0;
            this.lblStandart3.Text = "Ürün Grubu";
            // 
            // panelFiltrelemeGrubu
            // 
            this.panelFiltrelemeGrubu.Controls.Add(this.rdBtnUrunGrubunaGore);
            this.panelFiltrelemeGrubu.Controls.Add(this.rdBtnTumu);
            this.panelFiltrelemeGrubu.Controls.Add(this.lblStandart1);
            this.panelFiltrelemeGrubu.Location = new System.Drawing.Point(3, 76);
            this.panelFiltrelemeGrubu.Name = "panelFiltrelemeGrubu";
            this.panelFiltrelemeGrubu.Size = new System.Drawing.Size(343, 97);
            this.panelFiltrelemeGrubu.TabIndex = 3;
            // 
            // rdBtnUrunGrubunaGore
            // 
            this.rdBtnUrunGrubunaGore.AutoSize = true;
            this.rdBtnUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnUrunGrubunaGore.Location = new System.Drawing.Point(14, 68);
            this.rdBtnUrunGrubunaGore.Name = "rdBtnUrunGrubunaGore";
            this.rdBtnUrunGrubunaGore.Size = new System.Drawing.Size(177, 24);
            this.rdBtnUrunGrubunaGore.TabIndex = 3;
            this.rdBtnUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdBtnUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // rdBtnTumu
            // 
            this.rdBtnTumu.AutoSize = true;
            this.rdBtnTumu.Checked = true;
            this.rdBtnTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnTumu.Location = new System.Drawing.Point(15, 41);
            this.rdBtnTumu.Name = "rdBtnTumu";
            this.rdBtnTumu.Size = new System.Drawing.Size(72, 24);
            this.rdBtnTumu.TabIndex = 2;
            this.rdBtnTumu.TabStop = true;
            this.rdBtnTumu.Text = "Tümü";
            this.rdBtnTumu.UseVisualStyleBackColor = true;
            // 
            // lblStandart1
            // 
            this.lblStandart1.AutoSize = true;
            this.lblStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart1.Location = new System.Drawing.Point(9, 12);
            this.lblStandart1.Name = "lblStandart1";
            this.lblStandart1.Size = new System.Drawing.Size(142, 25);
            this.lblStandart1.TabIndex = 1;
            this.lblStandart1.Text = "Filtreleme Türü";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel1.Controls.Add(this.btnRaporAl);
            this.splitContainer2.Panel1.Controls.Add(this.txtUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lblStandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewStok);
            this.splitContainer2.Size = new System.Drawing.Size(808, 733);
            this.splitContainer2.SplitterDistance = 60;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRaporAl.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRaporAl.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporAl.ForeColor = System.Drawing.Color.White;
            this.btnRaporAl.Image = global::BarcodeSales.Properties.Resources.import;
            this.btnRaporAl.Location = new System.Drawing.Point(655, 8);
            this.btnRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(143, 46);
            this.btnRaporAl.TabIndex = 37;
            this.btnRaporAl.Text = "  Rapor Al";
            this.btnRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.BackColor = System.Drawing.Color.White;
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrunAra.Location = new System.Drawing.Point(109, 15);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(250, 30);
            this.txtUrunAra.TabIndex = 1;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // lblStandart6
            // 
            this.lblStandart6.AutoSize = true;
            this.lblStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStandart6.Location = new System.Drawing.Point(13, 18);
            this.lblStandart6.Name = "lblStandart6";
            this.lblStandart6.Size = new System.Drawing.Size(90, 25);
            this.lblStandart6.TabIndex = 0;
            this.lblStandart6.Text = "Ürün Ara";
            // 
            // dataGridViewStok
            // 
            this.dataGridViewStok.AllowUserToAddRows = false;
            this.dataGridViewStok.AllowUserToDeleteRows = false;
            this.dataGridViewStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStok.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStok.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStok.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStok.Name = "dataGridViewStok";
            this.dataGridViewStok.ReadOnly = true;
            this.dataGridViewStok.RowHeadersVisible = false;
            this.dataGridViewStok.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStok.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStok.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewStok.RowTemplate.Height = 30;
            this.dataGridViewStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStok.Size = new System.Drawing.Size(808, 669);
            this.dataGridViewStok.TabIndex = 15;
            // 
            // fStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1102, 733);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStokIslemleri";
            this.Text = "STOK İŞLEMLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fStokIslemleri_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelIslemTuru.ResumeLayout(false);
            this.panelIslemTuru.PerformLayout();
            this.panelTarih.ResumeLayout(false);
            this.panelTarih.PerformLayout();
            this.panelUrunGrubu.ResumeLayout(false);
            this.panelUrunGrubu.PerformLayout();
            this.panelFiltrelemeGrubu.ResumeLayout(false);
            this.panelFiltrelemeGrubu.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private lblStandart lblStandart1;
        private System.Windows.Forms.Panel panelFiltrelemeGrubu;
        private System.Windows.Forms.RadioButton rdBtnUrunGrubunaGore;
        private System.Windows.Forms.RadioButton rdBtnTumu;
        private System.Windows.Forms.Panel panelTarih;
        private System.Windows.Forms.Panel panelUrunGrubu;
        private lblStandart lblStandart3;
        private System.Windows.Forms.ComboBox comboBoxUrunGrubu;
        private lblStandart lblStandart4;
        private lblStandart lblStandart5;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.Panel panelIslemTuru;
        private System.Windows.Forms.ComboBox comboBoxIslemTuru;
        private lblStandart lblStandart2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private txtStandart txtUrunAra;
        private lblStandart lblStandart6;
        private ozelDataGridView dataGridViewStok;
        private System.Windows.Forms.Button btnAra;
        private btnStandart btnRaporAl;
        protected internal lblStandart lblKullanici;
    }
}