using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    class Ghost : IPrintable , IMovable
    {
        public string _ghostName;

        public Ghost(string ghostName)

        {
            _ghostName = ghostName;
        }

        public bool Moves { get; set; }

        public void Print()
        {
            Console.WriteLine(_ghostName);
        }
    }
}
