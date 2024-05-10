using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Altın:Banka_Hesap
    {
        public double çeyrek = 250 , yarım = 509 , gram = 154 , tam = 1093 , cumhuriyet = 1150;
        
        
        public double gram_sat( double miktar)
        {
            if (miktar > 0)
            {
                bakiye += gram ;
                miktar--;
            }
            return bakiye;
        }
        public double gram_al( double miktar)
        {
            miktar++;
            bakiye -= gram ;
            return bakiye;
        }
        
        public double çeyrek_sat( double miktar)
        {
            
            if (miktar > 0)
            {
                bakiye += çeyrek ;
                miktar--;
            }
            return bakiye;
        }
        public double çeyrek_al( double miktar)
        {
            miktar++;
            bakiye -= çeyrek ;
            return bakiye;
        }
       
        public double yarım_sat( double miktar)
        {
            if (miktar > 0)
            {
                bakiye += yarım ;
                miktar--;
            }
            return bakiye;
        }
        public double yarım_al( double miktar)
        {
            miktar++;
            bakiye -= yarım ;
            return bakiye;
        }
       
        public double tam_sat( double miktar)
        {
            if (miktar > 0)
            {
                bakiye += tam ;
                miktar--;
            }
            return bakiye;
        }
        public double tam_al( double miktar)
        {
            miktar++;
            bakiye -= tam ;
            return bakiye;
        }
        
        public double cumhuriyet_sat( double miktar)
        {
            if (miktar > 0)
            {
                bakiye += cumhuriyet ;
                miktar--;
            }
            return bakiye;
        }
        public double cumhuriyet_al( double miktar)
        {
            miktar++;
            bakiye -= cumhuriyet ;
            return bakiye;
        }
        

    }
}
