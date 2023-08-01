namespace OOPFinal
{
    partial class personelIslem
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
            this.giris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sil = new System.Windows.Forms.Button();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.cbIcerdeMi = new System.Windows.Forms.CheckBox();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Personel = new System.Windows.Forms.Label();
            this.duzenle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.birimIslemleri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(2503, 78);
            this.giris.Margin = new System.Windows.Forms.Padding(4);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(229, 73);
            this.giris.TabIndex = 6;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.cbBirim);
            this.groupBox1.Controls.Add(this.cbIcerdeMi);
            this.groupBox1.Controls.Add(this.dtCikisTarihi);
            this.groupBox1.Controls.Add(this.dtGirisTarihi);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Personel);
            this.groupBox1.Controls.Add(this.duzenle);
            this.groupBox1.Location = new System.Drawing.Point(44, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 802);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel İşlemleri";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(21, 650);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(203, 73);
            this.sil.TabIndex = 7;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.personelSil_Click);
            // 
            // cbBirim
            // 
            this.cbBirim.DisplayMember = "birimAdi";
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Location = new System.Drawing.Point(308, 529);
            this.cbBirim.Margin = new System.Windows.Forms.Padding(4);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(280, 39);
            this.cbBirim.TabIndex = 5;
            this.cbBirim.ValueMember = "birimID";
            // 
            // cbIcerdeMi
            // 
            this.cbIcerdeMi.AutoSize = true;
            this.cbIcerdeMi.Location = new System.Drawing.Point(308, 446);
            this.cbIcerdeMi.Margin = new System.Windows.Forms.Padding(4);
            this.cbIcerdeMi.Name = "cbIcerdeMi";
            this.cbIcerdeMi.Size = new System.Drawing.Size(28, 27);
            this.cbIcerdeMi.TabIndex = 4;
            this.cbIcerdeMi.UseVisualStyleBackColor = true;
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(308, 363);
            this.dtCikisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(280, 38);
            this.dtCikisTarihi.TabIndex = 3;
            // 
            // dtGirisTarihi
            // 
            this.dtGirisTarihi.Location = new System.Drawing.Point(308, 280);
            this.dtGirisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtGirisTarihi.Name = "dtGirisTarihi";
            this.dtGirisTarihi.Size = new System.Drawing.Size(280, 38);
            this.dtGirisTarihi.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(308, 205);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(280, 38);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(308, 120);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(280, 38);
            this.txtid.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 533);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Birim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 453);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "İçerde mi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // Personel
            // 
            this.Personel.AutoSize = true;
            this.Personel.Location = new System.Drawing.Point(29, 128);
            this.Personel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Personel.Name = "Personel";
            this.Personel.Size = new System.Drawing.Size(171, 31);
            this.Personel.TabIndex = 1;
            this.Personel.Text = "Personel No:";
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(333, 650);
            this.duzenle.Margin = new System.Windows.Forms.Padding(4);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(191, 73);
            this.duzenle.TabIndex = 0;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.personelDuzenle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(743, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1715, 802);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // birimIslemleri
            // 
            this.birimIslemleri.Location = new System.Drawing.Point(2503, 296);
            this.birimIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.birimIslemleri.Name = "birimIslemleri";
            this.birimIslemleri.Size = new System.Drawing.Size(229, 73);
            this.birimIslemleri.TabIndex = 7;
            this.birimIslemleri.Text = "Birim İşlem";
            this.birimIslemleri.UseVisualStyleBackColor = true;
            this.birimIslemleri.Click += new System.EventHandler(this.birimIslemleri_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2503, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Personel İşlem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // personelIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2772, 1132);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birimIslemleri);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "personelIslem";
            this.Text = "Personel İşlem";
            this.Load += new System.EventHandler(this.personelIslem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.CheckBox cbIcerdeMi;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtGirisTarihi;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Personel;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button birimIslemleri;
        private System.Windows.Forms.Button button1;
    }
}