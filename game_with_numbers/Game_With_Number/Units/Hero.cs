using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.Unit
{
    class Hero : Unit
    {
       
        public Hero (int x, int y, string name) : base(x, y, name)
        {
                    
        }

        
        public void MoveRight()
        {
           X++;
        }
       
        public void MoveLeft()
        {
           X--;
        }

       /* public void PrintInfo()
        {
            Console.WriteLine(_name + " is at " + _x + " , " + _y);

        }*/
    }

}
