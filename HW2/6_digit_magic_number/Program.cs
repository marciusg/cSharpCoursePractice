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
            int a = 102345;
            int b = 987654;
            int[] NumList = Int_to_array(a, b);
            int[] NumList2 = (int[])NumList.Clone();

            int[] SortedNr = new int[999999];


            for (int i = 0; i <= b - a; i++)
            {

                if (AreDigitsUnique(NumList2[i]))
                {
                    SortedNr[i] = NumList2[i];
                }
                else
                {
                    continue;
                }
            }

            // Console.WriteLine(SortedNr.Length-1);
            int[] tst = new int[999999];
            for (int i = 0; i < (b - a) - 1; i++)
            { 
                if (SortedNr[i] != 0)
                {
                    Console.WriteLine(SortedNr[i]);
                }
               




                /* for(int j = i+1; j < b - a; j++)
                {

                    if (SortedNr[j] == SortedNr[i]*2)
                    {

                        if (SortedNr[j] == SortedNr[i] * 3)
                        {
                            Console.WriteLine(SortedNr[j]);
                            if (SortedNr[j] == SortedNr[i] * 4)
                            {
                                Console.WriteLine(SortedNr[j]);
                                if (SortedNr[j] == SortedNr[i] * 5)
                                {
                                    Console.WriteLine(SortedNr[j]);
                                    if (SortedNr[j] == SortedNr[i] * 6)
                                    {
                                        Console.WriteLine(SortedNr[j]);
                                    }
                                }
                            }
                        }
                    }
                }*/
            }

                Console.Read();
        }
            
       

         
            //Console.WriteLine(NumList2.Length);


            //Console.WriteLine(NumList2.Length);
           

        


        static public int[] Int_to_array(int a, int b)
        {
            int[] number_array = new int[b];
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

            for (int i = 0; i < Unique.Length - 1; i++)

            {
                for (int j = i + 1; j < Unique.Length; j++)
                {
                    if (Unique[i] == Unique[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    
    }




}


