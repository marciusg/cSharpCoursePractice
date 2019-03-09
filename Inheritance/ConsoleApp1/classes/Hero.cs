using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    class Hero : IPrintable, ISpeaks, IMovable, IRenderable
    {
        private string _superpower;

        public Hero(string superpower)

        {
            _superpower = superpower;
        }

        public bool Speaks { get; set; }
        public bool Moves { get; set; }
        public bool IsRenderable { get; set; }

        public void Print()
        {
            Console.WriteLine(_superpower);
        }

        public void Rederable()
        {
            throw new NotImplementedException();
        }

        public void Renderable()
        {
            Console.WriteLine(_superpower + " can be renederable");
        }

    }
    }
