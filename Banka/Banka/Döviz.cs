using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Döviz:Banka_Hesap
    {
        Banka_Hesap yeni = new Banka_Hesap();
        public double dolar = 3.76   ,euro = 4.53 ;
        public double dolar_yatır(  double miktar )
        {
            if (miktar >= 0)
            {
                bakiye += dolar;
                miktar--;
            }
            return (bakiye);
        }
        public double dolar_al( double miktar)
        {
            bakiye -= dolar ;
            miktar++;
            return bakiye;
        }

        public double euro_yatır( double miktar)
        {
            if (miktar >= 0)
            {
                bakiye += euro;
                miktar--;
            }
            return (bakiye);
        }
        public double euro_al( double miktar)
        {
            bakiye -= euro ;
            miktar++;
            return bakiye;
        }
        
    }
}
