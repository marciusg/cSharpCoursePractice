using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    class House : IPrintable, IRenderable
    {
        public int _numberOfHouse;

        public House(int numberOfHouse)

        {
            _numberOfHouse = numberOfHouse;
        }

        public bool IsRenderable { get; set; }

        public void Print()
        {
            Console.WriteLine(_numberOfHouse);
        }
        public void Renderable()
        {
            Console.WriteLine(_numberOfHouse + " can be renederable");
        }
    }
}
