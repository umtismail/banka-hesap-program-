namespace Banka
{
    partial class Hesap_Giriş
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
            this.btn_giriş = new System.Windows.Forms.Button();
            this.hesap = new System.Windows.Forms.TextBox();
            this.şifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giriş
            // 
            this.btn_giriş.Location = new System.Drawing.Point(126, 161);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(75, 23);
            this.btn_giriş.TabIndex = 0;
            this.btn_giriş.Text = "Giriş";
            this.btn_giriş.UseVisualStyleBackColor = true;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click);
            // 
            // hesap
            // 
            this.hesap.Location = new System.Drawing.Point(29, 45);
            this.hesap.Name = "hesap";
            this.hesap.Size = new System.Drawing.Size(100, 20);
            this.hesap.TabIndex = 1;
            // 
            // şifre
            // 
            this.şifre.Location = new System.Drawing.Point(196, 45);
            this.şifre.Name = "şifre";
            this.şifre.PasswordChar = '*';
            this.şifre.Size = new System.Drawing.Size(100, 20);
            this.şifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hesap_No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // Hesap_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.hesap);
            this.Controls.Add(this.btn_giriş);
            this.Name = "Hesap_Giriş";
            this.Text = "Hesap_Giriş";
            this.Load += new System.EventHandler(this.Hesap_Giriş_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.TextBox hesap;
        private System.Windows.Forms.TextBox şifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}