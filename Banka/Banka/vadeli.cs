using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class vadeli:Banka_Hesap
    {
        public static double faiz;
        public static int vade;
        public double faizal(int para)
        {
            if (para > 0 && para <= 2000)
            {
                faiz = 1.45;
                if (vade == 3)
                {
                    faiz = 1.45;
                }
                else if (vade == 6)
                {
                    faiz = 1.55;
                }
                else if (vade == 12)
                {
                    faiz = 1.65;
                }
                else if (vade == 24)
                {
                    faiz = 1.75;
                }
            }
            else if (para > 2000 && para <= 5000)
            {
                faiz = 1.75;
                if (vade == 3)
                {
                    faiz = 1.75;
                }
                else if (vade == 6)
                {
                    faiz = 1.85;
                }
                else if (vade == 12)
                {
                    faiz = 1.95;
                }
                else if (vade == 24)
                {
                    faiz = 2.10;
                }
            }
            else
            {
                faiz = 1.95;
                if (vade == 3)
                {
                    faiz = 1.95;
                }
                else if (vade == 6)
                {
                    faiz = 2.05;
                }
                else if (vade == 12)
                {
                    faiz = 2.15;
                }
                else if (vade == 24)
                {
                    faiz = 2.25;
                }
            }
            return faiz;
        } 

        
    }
}
