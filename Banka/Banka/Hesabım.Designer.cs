namespace Banka
{
    partial class Hesabım
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.döviz = new System.Windows.Forms.CheckBox();
            this.altın = new System.Windows.Forms.CheckBox();
            this.vadesiz = new System.Windows.Forms.CheckBox();
            this.vadeli = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kontrol = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hesap No =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // döviz
            // 
            this.döviz.AutoSize = true;
            this.döviz.Location = new System.Drawing.Point(52, 88);
            this.döviz.Name = "döviz";
            this.döviz.Size = new System.Drawing.Size(53, 17);
            this.döviz.TabIndex = 20;
            this.döviz.Text = "Döviz";
            this.döviz.UseVisualStyleBackColor = true;
            this.döviz.CheckedChanged += new System.EventHandler(this.cb_döviz_CheckedChanged);
            // 
            // altın
            // 
            this.altın.AutoSize = true;
            this.altın.Location = new System.Drawing.Point(52, 65);
            this.altın.Name = "altın";
            this.altın.Size = new System.Drawing.Size(46, 17);
            this.altın.TabIndex = 19;
            this.altın.Text = "Altın";
            this.altın.UseVisualStyleBackColor = true;
            this.altın.CheckedChanged += new System.EventHandler(this.cb_altın_CheckedChanged);
            // 
            // vadesiz
            // 
            this.vadesiz.AutoSize = true;
            this.vadesiz.Location = new System.Drawing.Point(52, 42);
            this.vadesiz.Name = "vadesiz";
            this.vadesiz.Size = new System.Drawing.Size(63, 17);
            this.vadesiz.TabIndex = 18;
            this.vadesiz.Text = "Vadesiz";
            this.vadesiz.UseVisualStyleBackColor = true;
            this.vadesiz.CheckedChanged += new System.EventHandler(this.cb_vadesiz_CheckedChanged);
            // 
            // vadeli
            // 
            this.vadeli.AutoSize = true;
            this.vadeli.Location = new System.Drawing.Point(52, 19);
            this.vadeli.Name = "vadeli";
            this.vadeli.Size = new System.Drawing.Size(55, 17);
            this.vadeli.TabIndex = 17;
            this.vadeli.Text = "Vadeli";
            this.vadeli.UseVisualStyleBackColor = true;
            this.vadeli.CheckedChanged += new System.EventHandler(this.cb_vadeli_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vadeli);
            this.groupBox1.Controls.Add(this.döviz);
            this.groupBox1.Controls.Add(this.vadesiz);
            this.groupBox1.Controls.Add(this.altın);
            this.groupBox1.Location = new System.Drawing.Point(215, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 111);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Türleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Bakiyeniz =";
            // 
            // Kontrol
            // 
            this.Kontrol.Interval = 1000;
            this.Kontrol.Tick += new System.EventHandler(this.Kontrol_Tick);
            // 
            // Hesabım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hesabım";
            this.Text = "Hesabım";
            this.Load += new System.EventHandler(this.Hesabım_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox döviz;
        public System.Windows.Forms.CheckBox altın;
        public System.Windows.Forms.CheckBox vadesiz;
        public System.Windows.Forms.CheckBox vadeli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Kontrol;
    }
}