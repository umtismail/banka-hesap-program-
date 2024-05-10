namespace Banka
{
    partial class vade
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hesapbakiyeLBL = new System.Windows.Forms.Label();
            this.AltındurumuLBL = new System.Windows.Forms.Label();
            this.mvctbakiyeLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Bir Ay İlerle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Yatır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Vadeyi Boz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Vade Sonu Miktarı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Aylık Faiz : ";
            // 
            // hesapbakiyeLBL
            // 
            this.hesapbakiyeLBL.AutoSize = true;
            this.hesapbakiyeLBL.Location = new System.Drawing.Point(12, 31);
            this.hesapbakiyeLBL.Name = "hesapbakiyeLBL";
            this.hesapbakiyeLBL.Size = new System.Drawing.Size(121, 13);
            this.hesapbakiyeLBL.TabIndex = 30;
            this.hesapbakiyeLBL.Text = "Vade Beklenen Bakiye :";
            // 
            // AltındurumuLBL
            // 
            this.AltındurumuLBL.AutoSize = true;
            this.AltındurumuLBL.Location = new System.Drawing.Point(12, 53);
            this.AltındurumuLBL.Name = "AltındurumuLBL";
            this.AltındurumuLBL.Size = new System.Drawing.Size(71, 13);
            this.AltındurumuLBL.TabIndex = 29;
            this.AltındurumuLBL.Text = "Kalan Vade : ";
            // 
            // mvctbakiyeLBL
            // 
            this.mvctbakiyeLBL.AutoSize = true;
            this.mvctbakiyeLBL.Location = new System.Drawing.Point(12, 9);
            this.mvctbakiyeLBL.Name = "mvctbakiyeLBL";
            this.mvctbakiyeLBL.Size = new System.Drawing.Size(100, 13);
            this.mvctbakiyeLBL.TabIndex = 28;
            this.mvctbakiyeLBL.Text = "Mevcut Bakiyeniz : ";
            // 
            // vade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 158);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesapbakiyeLBL);
            this.Controls.Add(this.AltındurumuLBL);
            this.Controls.Add(this.mvctbakiyeLBL);
            this.Name = "vade";
            this.Text = "vade";
            this.Load += new System.EventHandler(this.vade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hesapbakiyeLBL;
        private System.Windows.Forms.Label AltındurumuLBL;
        private System.Windows.Forms.Label mvctbakiyeLBL;
    }
}