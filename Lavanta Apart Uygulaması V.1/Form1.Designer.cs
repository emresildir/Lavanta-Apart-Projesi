
namespace Lavanta_Apart_Uygulaması_V._1
{
    partial class frmadmingiris
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
            this.KullaniciAdi = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.txtboxkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtboxsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.lblbaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.AutoSize = true;
            this.KullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdi.Location = new System.Drawing.Point(67, 89);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(88, 17);
            this.KullaniciAdi.TabIndex = 0;
            this.KullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre.Location = new System.Drawing.Point(86, 128);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(41, 17);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Şifre :";
            // 
            // txtboxkullaniciadi
            // 
            this.txtboxkullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtboxkullaniciadi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxkullaniciadi.Location = new System.Drawing.Point(183, 86);
            this.txtboxkullaniciadi.Name = "txtboxkullaniciadi";
            this.txtboxkullaniciadi.Size = new System.Drawing.Size(189, 25);
            this.txtboxkullaniciadi.TabIndex = 2;
            // 
            // txtboxsifre
            // 
            this.txtboxsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtboxsifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxsifre.Location = new System.Drawing.Point(183, 125);
            this.txtboxsifre.Name = "txtboxsifre";
            this.txtboxsifre.Size = new System.Drawing.Size(189, 25);
            this.txtboxsifre.TabIndex = 3;
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(149, 171);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(105, 36);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.Location = new System.Drawing.Point(44, 21);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(343, 34);
            this.lblbaslik.TabIndex = 5;
            this.lblbaslik.Text = "Lavanta Aparta Hoş Geldiniz";
            // 
            // frmadmingiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(126)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(439, 243);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtboxsifre);
            this.Controls.Add(this.txtboxkullaniciadi);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullaniciAdi);
            this.Name = "frmadmingiris";
            this.Text = "Admin Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciAdi;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox txtboxkullaniciadi;
        private System.Windows.Forms.TextBox txtboxsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label lblbaslik;
    }
}

