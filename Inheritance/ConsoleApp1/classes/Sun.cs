using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    class Sun : IPrintable, IMovable, IGlows, IRenderable
    {
        public string _name;

        public Sun(string name)

        {
            _name = name;
        }

       
        public bool Moves { get; set; }
        public bool Glows { get; set; }
        public bool IsRenderable { get; set; }

        public void Print()
        {
            Console.WriteLine(_name); ;
        }

        public void Renderable ()
        {
            Console.WriteLine(_name+" can be renederable");
        }
    }


}
