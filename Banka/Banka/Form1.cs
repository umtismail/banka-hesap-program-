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
    public partial class VadeParaYatir : Form
    {
        public VadeParaYatir()
        {
            InitializeComponent();
        }
        public static double aylikfaiz;
        public static int para;
        private void button2_Click(object sender, EventArgs e)
        {
            Vadeli vad = new Vadeli();
            para = Convert.ToInt32(textBox1.Text);
            int vade = Convert.ToInt32(comboBox1.Text);
            double faiz;
            vadeli.vade=vade;
            faiz = vadeli.faizal;
            label5.Text = (faiz / 100 * para).ToString();
            aylikfaiz = (faiz / 100 * para);
            label7.Text = (aylikfaiz * vade).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = (Banka_Hesap.bakiye).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banka_Hesap.bakiye = Banka_Hesap.bakiye - Convert.ToInt32(textBox1.Text);
            Banka_Hesap.vadebakiye = Convert.ToInt32(textBox1.Text);
            label4.Text = (Banka_Hesap.bakiye).ToString();
            Vadeli vadedongeri = new Vadeli();
            vadedongeri.Show();
            this.Close();
        }
    }
}
