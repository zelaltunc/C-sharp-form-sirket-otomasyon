namespace OOPFinal
{
    partial class birimIslem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.txtBirimName = new System.Windows.Forms.TextBox();
            this.txtBirimId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Personel = new System.Windows.Forms.Label();
            this.duzenle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.giris = new System.Windows.Forms.Button();
            this.personelİslemleri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ekle);
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.txtBirimName);
            this.groupBox1.Controls.Add(this.txtBirimId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Personel);
            this.groupBox1.Controls.Add(this.duzenle);
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 436);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birim İşlemleri";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(16, 316);
            this.ekle.Margin = new System.Windows.Forms.Padding(4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(146, 73);
            this.ekle.TabIndex = 11;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.birimEkle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(476, 316);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(136, 73);
            this.sil.TabIndex = 7;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.birimSil_Click);
            // 
            // txtBirimName
            // 
            this.txtBirimName.Location = new System.Drawing.Point(308, 205);
            this.txtBirimName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirimName.Name = "txtBirimName";
            this.txtBirimName.Size = new System.Drawing.Size(280, 38);
            this.txtBirimName.TabIndex = 2;
            // 
            // txtBirimId
            // 
            this.txtBirimId.Enabled = false;
            this.txtBirimId.Location = new System.Drawing.Point(308, 120);
            this.txtBirimId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirimId.Name = "txtBirimId";
            this.txtBirimId.Size = new System.Drawing.Size(280, 38);
            this.txtBirimId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birim Adı:";
            // 
            // Personel
            // 
            this.Personel.AutoSize = true;
            this.Personel.Location = new System.Drawing.Point(29, 128);
            this.Personel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Personel.Name = "Personel";
            this.Personel.Size = new System.Drawing.Size(125, 31);
            this.Personel.TabIndex = 1;
            this.Personel.Text = "Birim No:";
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(244, 316);
            this.duzenle.Margin = new System.Windows.Forms.Padding(4);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(168, 73);
            this.duzenle.TabIndex = 0;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.birimDuzenle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(709, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 556);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(2481, 85);
            this.giris.Margin = new System.Windows.Forms.Padding(4);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(229, 73);
            this.giris.TabIndex = 9;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // personelİslemleri
            // 
            this.personelİslemleri.Location = new System.Drawing.Point(2481, 214);
            this.personelİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.personelİslemleri.Name = "personelİslemleri";
            this.personelİslemleri.Size = new System.Drawing.Size(229, 73);
            this.personelİslemleri.TabIndex = 10;
            this.personelİslemleri.Text = "Personel İşlem";
            this.personelİslemleri.UseVisualStyleBackColor = true;
            this.personelİslemleri.Click += new System.EventHandler(this.personelİslemleri_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2481, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "Birim İşlem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // birimIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2742, 1013);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personelİslemleri);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "birimIslem";
            this.Text = "Birim İslem";
            this.Load += new System.EventHandler(this.birimIslem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox txtBirimName;
        private System.Windows.Forms.TextBox txtBirimId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Personel;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button personelİslemleri;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button button1;
    }
}