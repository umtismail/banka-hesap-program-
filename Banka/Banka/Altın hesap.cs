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
    public partial class Altın_hesap : Form
    {
        public Altın_hesap()
        {
            InitializeComponent();
        }
        Altın altın = new Altın();
        int a , b ,c ,d ,f;

        private void btn_sat_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                if (a >= 0)
                {
                    altın.gram_sat(a);
                    label2.Text = "Gram altın miktarı =" + a;
                    a--;
                }
                else
                    MessageBox.Show("Miktarınız 0 ");
            }
            else if (radioButton2.Checked == true)
            {
                if (b >= 0)
                {
                    
                    altın.çeyrek_sat(b);
                    label3.Text = "Çeyrek altın miktarı =" + b;
                    b--;
                }
                else
                    MessageBox.Show("Miktarınız 0 ");
                
            }
            else if (radioButton3.Checked == true)
            {
                if (c >= 0)
                {
                   
                    altın.yarım_sat(c);
                    label4.Text = "Yarım altın miktarı =" + c;
                    c--;
                }
                else
                    MessageBox.Show("Miktarınız 0 ");
                
            }
            else if (radioButton4.Checked == true)
            {
                if (d >= 0)
                {
                    
                    altın.tam_sat(d);
                    label5.Text = "Tam altın miktarı =" + d;
                    d--;
                }
                else
                    MessageBox.Show("Miktarınız 0 ");
               
            }
            else if (radioButton5.Checked == true)
            {
                if (f >= 0)
                {
                    
                    altın.cumhuriyet_sat(f);
                    label6.Text = "Cumhuriyet altın miktarı =" + f;
                    f--;
                }
                else
                    MessageBox.Show("Miktarınız 0 ");
                
            }
        }
       
        private void btn_al_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                altın.gram_al(a);
                a++;
                label2.Text = "Gram altın miktarı =" + a; 
            }
            else if (radioButton2.Checked == true)
            {
                altın.çeyrek_al(b);
                b++;
                label3.Text = "Çeyrek altın miktarı =" + b; 
            }
            else if (radioButton3.Checked == true)
            {
                altın.yarım_al(c);
                c++;
                label4.Text = "Yarım altın miktarı =" + c; 
            }
            else if (radioButton4.Checked == true)
            {
                altın.tam_al(d);
                d++;
                label5.Text = "Tam altın miktarı =" + d; 
            }
            else if (radioButton5.Checked == true)
            {
                altın.cumhuriyet_al(f);
                f++;
                label6.Text = "Cumhuriyet altın miktarı =" + f; 
            }
        }

        private void Altın_hesap_Load(object sender, EventArgs e)
        {

        }


    }
}
