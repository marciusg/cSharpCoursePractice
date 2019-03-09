using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Gyvunas
    {
        protected string _klase;
        public string _gyvVieta;
        private bool _arNyksta;

        public Gyvunas(string ti, string gV, bool aN)
        {
            _klase = ti;
            _gyvVieta = gV;
            _arNyksta = aN;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Gyvuno klase: "+_klase +", gyvenamoji vieta: "+ _gyvVieta +", ar jis nykstantis gyvunas"+_arNyksta);

        }



    }

}
