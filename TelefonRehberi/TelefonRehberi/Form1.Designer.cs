namespace TelefonRehberi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kisino = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.telno = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temizle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi Numarası*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası*";
            // 
            // kisino
            // 
            this.kisino.Location = new System.Drawing.Point(221, 25);
            this.kisino.Name = "kisino";
            this.kisino.Size = new System.Drawing.Size(144, 20);
            this.kisino.TabIndex = 4;
            this.kisino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kisino_KeyPress);
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(221, 79);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(144, 20);
            this.adi.TabIndex = 5;
            this.adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adi_KeyPress_1);
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(221, 133);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(144, 20);
            this.soyadi.TabIndex = 6;
            this.soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadi_KeyPress);
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(221, 187);
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(144, 20);
            this.telno.TabIndex = 7;
            this.telno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telno_KeyPress);
            // 
            // ekle
            // 
            this.ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ekle.Location = new System.Drawing.Point(391, 25);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 8;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sil.Location = new System.Drawing.Point(391, 77);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 9;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guncelle.Location = new System.Drawing.Point(391, 130);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(75, 23);
            this.guncelle.TabIndex = 10;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 217);
            this.dataGridView1.TabIndex = 12;
            // 
            // temizle
            // 
            this.temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.temizle.Location = new System.Drawing.Point(391, 184);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(75, 23);
            this.temizle.TabIndex = 13;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(45, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "* işareti doldurulması zorunlu alan anlamına gelmektedir.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(45, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Silmek için Kişi Numarasını girmek yeterlidir.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(34, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Isme Göre Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(488, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.kisino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kisino;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox telno;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}

