using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.Unit
{
    class Enemy : Unit
    {
        private int _id;
       

        public Enemy (int id, int x, int y, string name) : base(x, y, name)
        {
            _id = id;
           
        }

        public void MoveDown()
        {
           Y++;
        }

       /*public void PrintInfo()
        {
            Console.WriteLine(_name + " is at " + _x + " , " + _y);

        }*/

        public int GetId()
        {
            return _id;
        }
    }
}
