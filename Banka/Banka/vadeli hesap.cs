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
    public partial class vadeli_hesap : Form
    {
        public vadeli_hesap()
        {
            InitializeComponent();
        }
        public static double aylikfaiz;
        public static int para;
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Banka_Hesap.bakiye = Banka_Hesap.bakiye - Convert.ToInt32(textBox1.Text);
            Banka_Hesap.vadebakiye = Convert.ToInt32(textBox1.Text);
            label4.Text = (Banka_Hesap.bakiye).ToString();
            vade vadedongeri = new vade();
            vadedongeri.Show();
            this.Close();
        }

        private void vadeli_hesap_Load(object sender, EventArgs e)
        {
            label4.Text = (Banka_Hesap.bakiye).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            vadeli vadeci = new vadeli();
            para = Convert.ToInt32(textBox1.Text);
            int vade = Convert.ToInt32(comboBox1.Text);
            double faiz;
            vadeli.vade = vade;
            faiz = vadeci.faizal(para);
            label5.Text = (faiz / 100 * para).ToString();
            aylikfaiz = (faiz / 100 * para);
            label7.Text = (aylikfaiz * vade).ToString();
        }


    }
}
