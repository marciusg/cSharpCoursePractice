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
            string real = "1234567890";





            Int_to_array(a, b);


            // Int_to_array_min(a);
            //Int_to_array_max(b);
            Console.WriteLine();
            Console.ReadLine();


        }


        static int[] Int_to_array(int a, int b)
        {
            int[] number_array = new int[899999];

            for (int i = a; i < b; i++)
            {
                string w = i.ToString();
                number_array[i - a] = Convert.ToInt32(w);


            }

            /*for (int j = 0; j < number_array.Length; j++)
            {
                Console.Write(number_array[j] + ". ");
            }*/
            return number_array;
        }

      


    }




}


