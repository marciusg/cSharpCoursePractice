using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_birds
{
    public class Gyvunas
    {
        public string _klase;
        public string _gyvVieta;
        public bool _arNyksta;

        public Gyvunas(string klase, string gyvVieta, bool arNyksta)
        {
            _klase = klase;
            _gyvVieta = gyvVieta;
            _arNyksta = arNyksta;
        }

        public void PrintInfoGyunas()
        {
            Console.WriteLine("Gyvuno klase: " + _klase + ", gyvenamoji vieta: " + _gyvVieta + ", ar jis nykstantis gyvunas: " + _arNyksta);

        }
    }
}
