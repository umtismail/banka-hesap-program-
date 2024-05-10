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
    public partial class Yeni_Kayıt : Form
    {
        public Yeni_Kayıt()
        {
            InitializeComponent();
        } 
        
        private void Yeni_Kayıt_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rasgele = rnd.Next(100000000, 999999999);
            int rasgelee = rnd.Next(100000000, 999999999);
            kartNo.Text = rasgele.ToString();
            HesapNo.Text = rasgelee.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Müşteri.ad = Ad.Text;
            Müşteri.soyad = Soyad.Text;
            Banka_Hesap.kart_no = kartNo.Text;
            Banka_Hesap.hesap_no = HesapNo.Text;
            Banka_Hesap.şifre = şifre.Text;
            Banka_Hesap.bakiye = Convert.ToInt32(txt_bakiye.Text);
            Hesap_Giriş hesap = new Hesap_Giriş();
            hesap.Show();
            this.Hide();
        }
    }
}
