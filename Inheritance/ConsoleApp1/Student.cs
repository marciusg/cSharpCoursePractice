using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {

        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public int AvgMark { set; get; }
        public bool IsGetTuit { set; get; }



        public override string ToString() => "Students can buy alcohol - "+ Id +" "+Name+" "+Age+" " +AvgMark+" "+IsGetTuit;

        





    }
}
