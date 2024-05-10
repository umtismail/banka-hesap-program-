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
    public partial class Vadesiz_hesap : Form
    {
        public Vadesiz_hesap()
        {
            InitializeComponent();
        }
        int q;
        Vadesiz vades = new Vadesiz();
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "Para Yatır";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "Para Çek";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q = Convert.ToInt32(textBox1.Text);
            if (button1.Text == "Para Yatır")
            {
                vades.para_yatır(q);
            }
            else if (button1.Text == "Para Çek")
            {
                vades.para_çek(q);
            }
            
        }

        private void Vadesiz_hesap_Load(object sender, EventArgs e)
        {

        }
    }
}
