namespace Banka
{
    partial class Girş_programı
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
            this.kayıt = new System.Windows.Forms.Button();
            this.var = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kayıt
            // 
            this.kayıt.Location = new System.Drawing.Point(79, 60);
            this.kayıt.Name = "kayıt";
            this.kayıt.Size = new System.Drawing.Size(109, 39);
            this.kayıt.TabIndex = 0;
            this.kayıt.Text = "Kayıt Ol";
            this.kayıt.UseVisualStyleBackColor = true;
            this.kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // var
            // 
            this.var.Location = new System.Drawing.Point(79, 148);
            this.var.Name = "var";
            this.var.Size = new System.Drawing.Size(109, 35);
            this.var.TabIndex = 1;
            this.var.Text = "Var Olan";
            this.var.UseVisualStyleBackColor = true;
            this.var.Click += new System.EventHandler(this.btn_var_Click);
            // 
            // Girş_programı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.var);
            this.Controls.Add(this.kayıt);
            this.Name = "Girş_programı";
            this.Text = "Girş_programı";
            this.Load += new System.EventHandler(this.Girş_programı_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kayıt;
        private System.Windows.Forms.Button var;
    }
}