using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    class Dog : IPrintable, IMovable, IRenderable
    {
        public string _dogBreed;

        public Dog(string dogBreed)

        {
            _dogBreed = dogBreed;
        }

        public bool Moves { get; set; }
        public bool IsRenderable { get; set; }

        public void Print()
        {
            Console.WriteLine(_dogBreed);
        }

        public void Renderable()
        {
            Console.WriteLine(_dogBreed + " can be renederable");
        }
    }
}
