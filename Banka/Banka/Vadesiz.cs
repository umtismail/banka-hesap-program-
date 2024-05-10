using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Vadesiz:Banka_Hesap
    {
        public double para_çek(int miktar)
        {
            bakiye = bakiye - miktar;
            return bakiye;
        }
        public double para_yatır(int miktar)
        {
            bakiye = bakiye + miktar;
            return bakiye;
        }
    }
}
