namespace OOPFinal
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oOPFinalDataSet = new OOPFinal.OOPFinalDataSet();
            this.birimBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.ekle = new System.Windows.Forms.Button();
            this.personelİslemleri = new System.Windows.Forms.Button();
            this.birimTableAdapter = new OOPFinal.OOPFinalDataSetTableAdapters.birimTableAdapter();
            this.personelTableAdapter = new OOPFinal.OOPFinalDataSetTableAdapters.personelTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.birimIslemleri = new System.Windows.Forms.Button();
            this.txtcalisOrt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtperSayi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(752, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1715, 680);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.ekle);
            this.groupBox1.Location = new System.Drawing.Point(53, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 763);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ekle";
            // 
            // cbBirim
            // 
            this.cbBirim.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personelBindingSource, "birimID", true));
            this.cbBirim.DataSource = this.birimBindingSource;
            this.cbBirim.DisplayMember = "birimAdi";
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Location = new System.Drawing.Point(308, 529);
            this.cbBirim.Margin = new System.Windows.Forms.Padding(4);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(280, 39);
            this.cbBirim.TabIndex = 5;
            this.cbBirim.ValueMember = "birimID";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.oOPFinalDataSet;
            // 
            // oOPFinalDataSet
            // 
            this.oOPFinalDataSet.DataSetName = "OOPFinalDataSet";
            this.oOPFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birimBindingSource
            // 
            this.birimBindingSource.DataMember = "birim";
            this.birimBindingSource.DataSource = this.oOPFinalDataSet;
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
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(333, 650);
            this.ekle.Margin = new System.Windows.Forms.Padding(4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(191, 73);
            this.ekle.TabIndex = 0;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.personel_ekle_Click);
            // 
            // personelİslemleri
            // 
            this.personelİslemleri.Location = new System.Drawing.Point(2506, 167);
            this.personelİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.personelİslemleri.Name = "personelİslemleri";
            this.personelİslemleri.Size = new System.Drawing.Size(229, 73);
            this.personelİslemleri.TabIndex = 2;
            this.personelİslemleri.Text = "Personel İşlem";
            this.personelİslemleri.UseVisualStyleBackColor = true;
            this.personelİslemleri.Click += new System.EventHandler(this.personelİslemleri_Click);
            // 
            // birimTableAdapter
            // 
            this.birimTableAdapter.ClearBeforeFill = true;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1658, 765);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(809, 344);
            this.dataGridView2.TabIndex = 4;
            // 
            // birimIslemleri
            // 
            this.birimIslemleri.Location = new System.Drawing.Point(2506, 277);
            this.birimIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.birimIslemleri.Name = "birimIslemleri";
            this.birimIslemleri.Size = new System.Drawing.Size(229, 73);
            this.birimIslemleri.TabIndex = 2;
            this.birimIslemleri.Text = "Birim İşlem";
            this.birimIslemleri.UseVisualStyleBackColor = true;
            this.birimIslemleri.Click += new System.EventHandler(this.birimIslemleri_Click);
            // 
            // txtcalisOrt
            // 
            this.txtcalisOrt.AutoSize = true;
            this.txtcalisOrt.Location = new System.Drawing.Point(420, 930);
            this.txtcalisOrt.Name = "txtcalisOrt";
            this.txtcalisOrt.Size = new System.Drawing.Size(133, 31);
            this.txtcalisOrt.TabIndex = 5;
            this.txtcalisOrt.Text = "                 ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2506, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtperSayi
            // 
            this.txtperSayi.AutoSize = true;
            this.txtperSayi.Location = new System.Drawing.Point(122, 930);
            this.txtperSayi.Name = "txtperSayi";
            this.txtperSayi.Size = new System.Drawing.Size(147, 31);
            this.txtperSayi.TabIndex = 7;
            this.txtperSayi.Text = "                   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 871);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personel Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 871);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ortalama Çalışma Süresi";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2757, 1167);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtperSayi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcalisOrt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.birimIslemleri);
            this.Controls.Add(this.personelİslemleri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button personelİslemleri;
        private System.Windows.Forms.ComboBox cbBirim;
        private OOPFinalDataSet oOPFinalDataSet;
        private System.Windows.Forms.BindingSource birimBindingSource;
        private OOPFinalDataSetTableAdapters.birimTableAdapter birimTableAdapter;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private OOPFinalDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button birimIslemleri;
        private System.Windows.Forms.Label txtcalisOrt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtperSayi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

