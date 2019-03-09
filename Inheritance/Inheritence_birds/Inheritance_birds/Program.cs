using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_birds
{
    class Program
    {
        static void Main(string[] args)
        {

            Gyvunas NewGyvunas = new Gyvunas("sausumos", "europa", false);

            Paukstis newPaukstis = new Paukstis("gandras" , "paukstis", 2500 , "vandens", "afrika", true);



            newPaukstis.PrintDataPaukstis();
            

            newPaukstis.PrintInfoGyunas();

            Console.ReadLine();

        }
    }
}
