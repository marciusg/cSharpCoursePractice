using ConsoleApp1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApp1.Extensions;

namespace ConsoleApp1
{
    public class Program
    {



        public static void Main(string[] args)
        {



            List<int> Lisst = new List<int>() {1,2,3,4,5,6,7,8,9,10 };


            var result = from s in Lisst
                         where s % 5 == 0
                         select s;

            foreach (int a in result)
            {
                Console.WriteLine(a);
            }

            //

            for (int i = 0; i < Lisst.Count; i++)
            {
                LygArNe(Lisst[i]);
            }
            ;

            
            
            //var abc = Lisst[0];

            //Console.WriteLine(result);



            /*
            List<Student> student_lst = new List<Student>();        
            student_lst.Add(new Student() { Id = 1, Name = "Tomas",Age = 18, AvgMark = 7, IsGetTuit = true });
            student_lst.Add(new Student() { Id = 2, Name = "Jonas",Age = 11, AvgMark = 2, IsGetTuit = false });
            student_lst.Add(new Student() { Id = 3, Name = "Kestutis",Age = 25, AvgMark = 4, IsGetTuit = false });
            student_lst.Add(new Student() { Id = 4, Name = "Gedas",Age = 10, AvgMark = 6, IsGetTuit = true });
            student_lst.Add(new Student() { Id = 5, Name = "Gediminas",Age = 33, AvgMark = 10,IsGetTuit = false });
                                 

            var result = from s in student_lst
                         where s.Name.Length <= 6 && s.AvgMark <= 4
                         select s;

            

            foreach(Student a in result)
            {
                Console.WriteLine(a);
            }
            */
            //-------------------------------------------------
            //List<Student> new_list = student_lst.FindAll(s => s.IsGetTuit);
            /*
            List<Student> new_list = student_lst.FindAll(s => s.Age >= 18);

            new_list.ForEach(Console.WriteLine);
            int a = 9;
            List<int> lst = new List<int>() { 1,2,3,4,5,6,7,8,9};

            for (int i = 0; i <= 8 ; i++ )
            {
                Console.WriteLine();
            }
            //Console.WriteLine(a.PowerTwo());
            //int a = 9;
           

            Console.WriteLine(a.PowerTwo());*/

            Console.ReadKey();
            





        }

       public static void LygArNe(int a)
        {
            
            if (a % 5 == 0)

                Console.WriteLine(a);
            

           

        }







    }















    
}
