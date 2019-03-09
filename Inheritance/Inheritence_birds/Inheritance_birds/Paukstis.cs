using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_birds
{
    public class Paukstis : Gyvunas
     {
        public string _name;
        public string _tipas;
        public int _esamasKiekis;


        public Paukstis (string nm, string tp, int kiekis, string klase, string gyvVieta, bool arNyksta):base(klase,gyvVieta,arNyksta)
        {
            _name = nm;
            _tipas = tp;
            _esamasKiekis = kiekis;
            //this._klase = base._klase;
            //this._gyvVieta = base._gyvVieta;
            //this._arNyksta = base._arNyksta;



        }


        public void PrintDataPaukstis()
        {
            Console.WriteLine("Paukscio pavadinimas: " + _name + ", koks paukstis: " + _tipas + ", kiek ju yra is viso mazdaug: " + _esamasKiekis
               +" klase "+ _klase +" gyvvieta "+_gyvVieta+ " arNyksta "+_arNyksta);
            //Console.WriteLine(_name, _tipas,_esamasKiekis, _klase, _gyvVieta, _arNyksta);
        }


    }
}
