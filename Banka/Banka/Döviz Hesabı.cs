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
    public partial class Döviz_Hesabı : Form
    {
        public Döviz_Hesabı()
        {
            InitializeComponent();
        }
        int a, b;
        Döviz döviz = new Döviz();
        private void btn_al_Click(object sender, EventArgs e)
        {
            if (euro.Checked == true)
            {
                
                döviz.euro_al(a);
                label1.Text =  "Euro =" + a + "€";
                a += 1;
            }
            else if (dolar.Checked == true)
            {

                döviz.dolar_al(b);
                label2.Text = "Dolar ="+ b + "$";
                b += 1;
            }
        }

        private void btn_sat_Click(object sender, EventArgs e)
        {
            if (euro.Checked == true)
            {
                if (a >= 0)
                {
                    döviz.euro_yatır(a);
                    label1.Text =  "Euro =" + a + "€";
                    a -= 1;
                }
            }
           else if (dolar.Checked == true)
            {
                if (b >= 0)
                {
                    döviz.dolar_yatır(b);
                    label2.Text =  "Dolar ="+b + "$";
                    b -= 1;
                }
            }
        }

        private void Döviz_Hesabı_Load(object sender, EventArgs e)
        {

        }
    }
}
