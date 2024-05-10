namespace Banka
{
    partial class Yeni_Kayıt
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
            this.Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HesapNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kartNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.şifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(12, 30);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(100, 20);
            this.Ad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(12, 80);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(100, 20);
            this.Soyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // HesapNo
            // 
            this.HesapNo.Location = new System.Drawing.Point(12, 130);
            this.HesapNo.Name = "HesapNo";
            this.HesapNo.Size = new System.Drawing.Size(100, 20);
            this.HesapNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hesap_no";
            // 
            // kartNo
            // 
            this.kartNo.Location = new System.Drawing.Point(13, 182);
            this.kartNo.Name = "kartNo";
            this.kartNo.Size = new System.Drawing.Size(100, 20);
            this.kartNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kart_no";
            // 
            // txt_bakiye
            // 
            this.txt_bakiye.Location = new System.Drawing.Point(13, 229);
            this.txt_bakiye.Name = "txt_bakiye";
            this.txt_bakiye.Size = new System.Drawing.Size(100, 20);
            this.txt_bakiye.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bakiye";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şifre";
            // 
            // şifre
            // 
            this.şifre.Location = new System.Drawing.Point(13, 276);
            this.şifre.Name = "şifre";
            this.şifre.PasswordChar = '*';
            this.şifre.Size = new System.Drawing.Size(100, 20);
            this.şifre.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Kaydol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yeni_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bakiye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kartNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ad);
            this.Name = "Yeni_Kayıt";
            this.Text = "Yeni_Kayıt";
            this.Load += new System.EventHandler(this.Yeni_Kayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HesapNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kartNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox şifre;
        private System.Windows.Forms.Button button1;
    }
}