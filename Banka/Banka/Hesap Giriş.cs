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
    public partial class Hesap_Giriş  :Form
    {
        public Hesap_Giriş()
        {
            InitializeComponent();
        }
        Yeni_Kayıt y = new Yeni_Kayıt();
        private void btn_giriş_Click(object sender, EventArgs e)
        {
            
            
             if (Banka_Hesap.hesap_no == hesap.Text && Banka_Hesap.şifre == şifre.Text)
           {
               Hesabım hesap = new Hesabım();
               hesap.Show();
               this.Hide();
           }
           else
               MessageBox.Show("Hesap numarısı veya şifre yanlış"); 

            
        }

        private void Hesap_Giriş_Load(object sender, EventArgs e)
        {
        }

        private void Hesap_Giriş_Load_1(object sender, EventArgs e)
        {

        }
    }
}
