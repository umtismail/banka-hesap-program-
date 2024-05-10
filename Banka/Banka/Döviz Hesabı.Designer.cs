namespace Banka
{
    partial class Döviz_Hesabı
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
            this.euro = new System.Windows.Forms.RadioButton();
            this.dolar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.al = new System.Windows.Forms.Button();
            this.sat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // euro
            // 
            this.euro.AutoSize = true;
            this.euro.Location = new System.Drawing.Point(12, 12);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(47, 17);
            this.euro.TabIndex = 0;
            this.euro.TabStop = true;
            this.euro.Text = "Euro";
            this.euro.UseVisualStyleBackColor = true;
            // 
            // dolar
            // 
            this.dolar.AutoSize = true;
            this.dolar.Location = new System.Drawing.Point(12, 35);
            this.dolar.Name = "dolar";
            this.dolar.Size = new System.Drawing.Size(50, 17);
            this.dolar.TabIndex = 1;
            this.dolar.TabStop = true;
            this.dolar.Text = "Dolar";
            this.dolar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Euro =0€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dolar =0$";
            // 
            // al
            // 
            this.al.Location = new System.Drawing.Point(38, 100);
            this.al.Name = "al";
            this.al.Size = new System.Drawing.Size(75, 23);
            this.al.TabIndex = 4;
            this.al.Text = "al";
            this.al.UseVisualStyleBackColor = true;
            this.al.Click += new System.EventHandler(this.btn_al_Click);
            // 
            // sat
            // 
            this.sat.Location = new System.Drawing.Point(161, 100);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(75, 23);
            this.sat.TabIndex = 5;
            this.sat.Text = "sat";
            this.sat.UseVisualStyleBackColor = true;
            this.sat.Click += new System.EventHandler(this.btn_sat_Click);
            // 
            // Döviz_Hesabı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sat);
            this.Controls.Add(this.al);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dolar);
            this.Controls.Add(this.euro);
            this.Name = "Döviz_Hesabı";
            this.Text = "Döviz_Hesabı";
            this.Load += new System.EventHandler(this.Döviz_Hesabı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton euro;
        private System.Windows.Forms.RadioButton dolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button al;
        private System.Windows.Forms.Button sat;
    }
}