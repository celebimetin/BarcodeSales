
namespace BarcodeSales
{
    partial class fHizliButonUrunEkle
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
            this.lblButonId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTumunuGoster = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.dataGridViewUrunEkleListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunEkleListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.lblButonId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxTumunuGoster);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewUrunEkleListesi);
            this.splitContainer1.Size = new System.Drawing.Size(1482, 753);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblButonId
            // 
            this.lblButonId.AutoSize = true;
            this.lblButonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButonId.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblButonId.Location = new System.Drawing.Point(180, 71);
            this.lblButonId.Name = "lblButonId";
            this.lblButonId.Size = new System.Drawing.Size(93, 25);
            this.lblButonId.TabIndex = 8;
            this.lblButonId.Text = "Buton No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buton Numarası :";
            // 
            // checkBoxTumunuGoster
            // 
            this.checkBoxTumunuGoster.AutoSize = true;
            this.checkBoxTumunuGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTumunuGoster.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBoxTumunuGoster.Location = new System.Drawing.Point(419, 37);
            this.checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            this.checkBoxTumunuGoster.Size = new System.Drawing.Size(209, 29);
            this.checkBoxTumunuGoster.TabIndex = 6;
            this.checkBoxTumunuGoster.Text = "Tüm Ürünleri Göster";
            this.checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            this.checkBoxTumunuGoster.CheckedChanged += new System.EventHandler(this.checkBoxTumunuGoster_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(163, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Ara";
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunAra.Location = new System.Drawing.Point(12, 35);
            this.txtUrunAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(388, 30);
            this.txtUrunAra.TabIndex = 4;
            this.txtUrunAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // dataGridViewUrunEkleListesi
            // 
            this.dataGridViewUrunEkleListesi.AllowUserToAddRows = false;
            this.dataGridViewUrunEkleListesi.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewUrunEkleListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUrunEkleListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUrunEkleListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUrunEkleListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunEkleListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUrunEkleListesi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUrunEkleListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUrunEkleListesi.Name = "dataGridViewUrunEkleListesi";
            this.dataGridViewUrunEkleListesi.RowHeadersVisible = false;
            this.dataGridViewUrunEkleListesi.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewUrunEkleListesi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUrunEkleListesi.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewUrunEkleListesi.RowTemplate.Height = 30;
            this.dataGridViewUrunEkleListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrunEkleListesi.Size = new System.Drawing.Size(1482, 644);
            this.dataGridViewUrunEkleListesi.TabIndex = 2;
            this.dataGridViewUrunEkleListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunEkleListesi_CellDoubleClick);
            // 
            // fHizliButonUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "fHizliButonUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ HIZLI ÜRÜN EKLE";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunEkleListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewUrunEkleListesi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.CheckBox checkBoxTumunuGoster;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblButonId;
    }
}