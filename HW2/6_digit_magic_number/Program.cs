using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 100000;
            int b = 999999;




            Int_to_array_min(a);
            Int_to_array_max(b);
            Console.WriteLine();
            Console.ReadLine();


        }


        static int[] Int_to_array_min(int a)
        {
            int[] number_array_min = new int[6];
            string b = a.ToString();

            for (int i = 0; i < number_array_min.Length; i++)
            {
                number_array_min[i] = Convert.ToInt32(b.Substring(i, 1));
            }

            for (int i = 0; i < number_array_min.Length; i++)
            {
                Console.Write(number_array_min[i]);
            }

            return number_array_min;


        }


        static int[] Int_to_array_max(int b)
        {
            int[] number_array_max = new int[6];
            string c = b.ToString();

            for (int i = 0; i < number_array_max.Length; i++)
            {
                number_array_max[i] = Convert.ToInt32(c.Substring(i, 1));
            }

            for (int i = 0; i < number_array_max.Length; i++)
            {
                Console.Write(number_array_max[i]);
            }

            return number_array_max;


        }

    }

}
