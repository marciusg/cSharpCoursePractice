using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Paukstis : 
    {
        public string _name;
        protected string _tipas;
        private int _esamasKiekis;


        public Paukstis (string nm, string tp, int kiekis, string ti, string gV, bool aN)
        {
            _name = nm;
            _tipas = tp;
            _esamasKiekis = kiekis;
        }


        public void PrintInfo()
        {
            Console.WriteLine("Paukscio pavadinimas: "+_name +", koks paukstis: "+_tipas+", kiek ju yra is viso mazdaug"+ _esamasKiekis);

        }


    }
}
