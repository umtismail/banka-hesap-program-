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
    public partial class Hesabım : Form
    {
        public Hesabım()
        {
            InitializeComponent();
        }
        
        private void Hesabım_Load_1(object sender, EventArgs e)
        {
            label1.Text = Müşteri.ad;
            label2.Text = Müşteri.soyad;
            label3.Text = "Hesap No = " + Banka_Hesap.hesap_no;
            label4.Text = "Bakiyeniz = " + Banka_Hesap.bakiye.ToString() + "₺";
            Kontrol.Start();
        }

        private void Kontrol_Tick(object sender, EventArgs e)
        {
            label4.Text = "Bakiyeniz = " + Banka_Hesap.bakiye.ToString() + "₺";
        }

        private void cb_vadesiz_CheckedChanged(object sender, EventArgs e)
        {
            Vadesiz_hesap vades = new Vadesiz_hesap();
            vades.Show();
        }

        private void cb_vadeli_CheckedChanged(object sender, EventArgs e)
        {
            vadeli_hesap vadeli = new vadeli_hesap();
            vadeli.Show();
        }

        private void cb_altın_CheckedChanged(object sender, EventArgs e)
        {
            Altın_hesap altın = new Altın_hesap();
            altın.Show();
        }

        private void cb_döviz_CheckedChanged(object sender, EventArgs e)
        {
            Döviz_Hesabı döviz = new Döviz_Hesabı();
            döviz.Show();

        }



    }
}
