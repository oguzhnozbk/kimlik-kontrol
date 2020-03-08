namespace WindowsFormsApp1
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
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.textBox_dogumYılı = new System.Windows.Forms.TextBox();
            this.btn_Dogrula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(83, 50);
            this.textBox_tc.MaxLength = 11;
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(100, 20);
            this.textBox_tc.TabIndex = 0;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_ad.Location = new System.Drawing.Point(83, 77);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_ad.TabIndex = 1;
            this.textBox_ad.TextChanged += new System.EventHandler(this.textBox_ad_TextChanged);
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(83, 104);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Soyad.TabIndex = 2;
            this.textBox_Soyad.TextChanged += new System.EventHandler(this.textBox_Soyad_TextChanged);
            // 
            // textBox_dogumYılı
            // 
            this.textBox_dogumYılı.Location = new System.Drawing.Point(83, 131);
            this.textBox_dogumYılı.MaxLength = 4;
            this.textBox_dogumYılı.Name = "textBox_dogumYılı";
            this.textBox_dogumYılı.Size = new System.Drawing.Size(100, 20);
            this.textBox_dogumYılı.TabIndex = 3;
            // 
            // btn_Dogrula
            // 
            this.btn_Dogrula.Location = new System.Drawing.Point(83, 167);
            this.btn_Dogrula.Name = "btn_Dogrula";
            this.btn_Dogrula.Size = new System.Drawing.Size(100, 23);
            this.btn_Dogrula.TabIndex = 4;
            this.btn_Dogrula.Text = "Doğrula";
            this.btn_Dogrula.UseVisualStyleBackColor = true;
            this.btn_Dogrula.Click += new System.EventHandler(this.btn_Dogrula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Yılı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Dogrula);
            this.Controls.Add(this.textBox_dogumYılı);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.textBox_tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.TextBox textBox_dogumYılı;
        private System.Windows.Forms.Button btn_Dogrula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

