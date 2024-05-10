using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class vade : Form
    {
        public vade()
        {
            InitializeComponent();
        }
                public double q;
             
        private void button3_Click(object sender, EventArgs e)
        {
            vadeli_hesap vadeyatir = new vadeli_hesap();
            vadeyatir.Show();
            this.Close();
        }

        private void vade_Load(object sender, EventArgs e)
        {
            AltındurumuLBL.Text = ("Kalan Vade : " + vadeli.vade).ToString();
            label1.Text = ("Aylık Faiz : " + vadeli_hesap.aylikfaiz);
            q = (vadeli_hesap.aylikfaiz) * vadeli.vade;
            q = q + vadeli_hesap.para;
            label2.Text = ("Vade Sonu Miktar : " + q.ToString());
            mvctbakiyeLBL.Text = ("Mevcut Bakiye : " + Banka_Hesap.bakiye);
            hesapbakiyeLBL.Text = ("Vade Bekleyen Bakiye : " + Banka_Hesap.vadebakiye);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vadeli.vade >= 1)
            {
                vadeli.vade = 0;
                Banka_Hesap.bakiye = Banka_Hesap.bakiye + (Banka_Hesap.vadebakiye - vadeli_hesap.aylikfaiz);
                AltındurumuLBL.Text = ("Kalan Vade : ");
                label1.Text = ("Aylık Faiz : ");
                label2.Text = ("Vade Sonu Miktar : ");
                hesapbakiyeLBL.Text = ("Vade Bekleyen Bakiye : " + Banka_Hesap.vadebakiye);
                mvctbakiyeLBL.Text = ("Mevcut Bakiye : " + Banka_Hesap.bakiye);
                Banka_Hesap.vadebakiye = 0;
            }
            else MessageBox.Show("Vadeli Hesabınızda Para Yok");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (vadeli.vade > 0)
            {
                Banka_Hesap.vadebakiye = Banka_Hesap.vadebakiye + vadeli_hesap.aylikfaiz;
                vadeli.vade--;
            }
            else
            {
                Banka_Hesap.bakiye = Banka_Hesap.bakiye + Banka_Hesap.vadebakiye;
                Banka_Hesap.vadebakiye = 0;
            }
            mvctbakiyeLBL.Text = ("Mevcut Bakiye : " + Banka_Hesap.bakiye);
            AltındurumuLBL.Text = ("Kalan Vade : " + vadeli.vade).ToString();
            hesapbakiyeLBL.Text = ("Vade Bekleyen Bakiye : " + Banka_Hesap.vadebakiye);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
