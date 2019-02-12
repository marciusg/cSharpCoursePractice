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
            int b = 900000;
            int[] NumList = Int_to_array(a,b);

            for(int i = a; i <= b; i++)
            {
             if (AreDigitsUnique(NumList[i]))
               {
                   Console.WriteLine(NumList[i]);
               }
            }
           
            //Console.WriteLine(NumList[4545]);
            Console.Read();
            
        }


        static public int[] Int_to_array(int a, int b)
        {
            int[] number_array = new int[999999];
            for (int i = a; i <= b; i++)
            {
                int start_from_zero = (i - a);
                number_array[start_from_zero] = i;
            }
            return number_array;
        }

        static public bool AreDigitsUnique(int q)
        {
            int[] Unique = new int[6];
            Unique[0] = q % 1000000 / 100000;
            Unique[1] = q % 100000 / 10000;
            Unique[2] = q % 10000 / 1000;
            Unique[3] = q % 1000 / 100;
            Unique[4] = q % 100 / 10;
            Unique[5] = q % 10;

            for(int i = 0; i < Unique.Length-2; i++)
            {
                for( int j = i+1; j<= Unique.Length-1; j++ )
                {
                    if (Unique[i] == Unique[j])
                    {
                        return false;
                    }
                }
                return true;
            } 
            return true;
        }


    }




}


