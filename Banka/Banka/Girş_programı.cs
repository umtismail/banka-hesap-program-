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
    public partial class Girş_programı : Form
    {
        public Girş_programı()
        {
            InitializeComponent();
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            Yeni_Kayıt yeni = new Yeni_Kayıt();
            yeni.Show();
            this.Hide();
        }

        private void Girş_programı_Load(object sender, EventArgs e)
        {

        }

        private void btn_var_Click(object sender, EventArgs e)
        {
            Hesap_Giriş hesap = new Hesap_Giriş();
            hesap.Show();
            this.Hide();
        }
    }
}
