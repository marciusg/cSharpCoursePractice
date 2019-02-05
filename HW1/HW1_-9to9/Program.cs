using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            int rng1 = -999;
            int rng2 = 999;

            do
            {



                Console.WriteLine("Įveskite skaičių nuo " + rng1 + " iki " + rng2 + "\n");
                string nr = Console.ReadLine();

                if (isNumber(nr))
                {
                    int SkaiciusInt = Convert.ToInt32(nr);

                    if (SkaiciusInt > 0)
                    {


                        Console.WriteLine("\nJūsų įvestas skaičius yra teisingo formato: " + nr + "\n");
                        inRange(nr, rng1, rng2);
                        if (SkaiciusInt > 0 && SkaiciusInt <= 9)
                        {
                            Console.WriteLine(vienetai(SkaiciusInt)); // kai tik vienetai
                        }
                        else if (SkaiciusInt < 0 && SkaiciusInt >= -9)
                        {
                            Console.WriteLine("minus" + vienetai(SkaiciusInt)); // kai tik vienetai
                        }



                        else if (SkaiciusInt > 9 && SkaiciusInt <= 20)
                        {
                            Console.WriteLine(desimtys(SkaiciusInt)); // kai desimtys nuo 10 iki 20
                        }



                        else if (SkaiciusInt > 20 && SkaiciusInt <= 99)
                        {
                            string des = nr.Substring(0, 1) + "0";
                            string vnt = nr.Substring(1);
                            Console.WriteLine(desimtys(Convert.ToInt32(des)) + " " + vienetai(Convert.ToInt32(vnt))); //nuo 21 iki 99
                        }


                        else if (SkaiciusInt > 99 && SkaiciusInt <= 999)
                        {
                            string simt1 = nr.Substring(0, 1);
                            string simt = nr.Substring(0, 1) + "00";
                            string vnt = nr.Substring(2);
                            if ((SkaiciusInt % 100 < 20) && (SkaiciusInt % 100 >= 10))
                            {

                                string des = nr.Substring(1, 2);
                                Console.WriteLine(vienetai(Convert.ToInt32(simt1)) + " " + simtai(Convert.ToInt32(simt)) + " " + desimtys(Convert.ToInt32(des))); // kai X11...X19
                            }
                            else if (SkaiciusInt % 100 < 10)
                            {
                                string des = nr.Substring(1, 2);
                                Console.WriteLine(vienetai(Convert.ToInt32(simt1)) + " " + simtai(Convert.ToInt32(simt)) + " " + vienetai(Convert.ToInt32(vnt))); // kai x01 ..... x09
                            }
                            else
                            {
                                string des = nr.Substring(1, 1) + "0";
                                Console.WriteLine(vienetai(Convert.ToInt32(simt1)) + " " + simtai(Convert.ToInt32(simt)) + " " + desimtys(Convert.ToInt32(des)) + " " + vienetai(Convert.ToInt32(vnt))); // cia jei viskas OK
                            }
                        }




                    }

                    else if (SkaiciusInt < 0) ///neigiami skaiciai  - minus prieki

                    {
                        Console.WriteLine("Jusu ivestas skaicius yra teisingo formato: " + nr);
                        inRange(nr, rng1, rng2);
                        if (SkaiciusInt < 0 && SkaiciusInt >= -9)
                        {
                            string vnt = nr.Substring(1, 1);
                            Console.WriteLine("minus " + vienetai(Convert.ToInt32(vnt))); // kai tik vienetai
                        }

                        else if (SkaiciusInt < -9 && SkaiciusInt >= -20)
                        {
                            string dec = nr.Substring(1, 2);
                            Console.WriteLine("minus " + desimtys(Convert.ToInt32(dec))); // kai desimtys nuo 10 iki 20
                        }



                        else if (SkaiciusInt < -20 && SkaiciusInt >= -99)
                        {
                            string des = nr.Substring(1, 1) + "0";
                            string vnt = nr.Substring(2);
                            Console.WriteLine("minus " + desimtys(Convert.ToInt32(des)) + " " + vienetai(Convert.ToInt32(vnt))); //nuo 21 iki 99
                        }


                        else if (SkaiciusInt < -99 && SkaiciusInt >= -999)
                        {
                            string simt1 = nr.Substring(1, 1);
                            string simt = nr.Substring(1, 1) + "00";
                            string vnt = nr.Substring(3);
                            if ((SkaiciusInt * -1 % 100 < 20) && (SkaiciusInt * -1 % 100 >= 10))
                            {

                                string des = nr.Substring(2, 2);
                                Console.WriteLine("minus " + vienetai(Convert.ToInt32(simt1)) + " " + simtai(Convert.ToInt32(simt)) + " " + desimtys(Convert.ToInt32(des))); // kaip X11...X19
                            }
                            else if (SkaiciusInt * -1 % 100 < 10)
                            {
                                string des = nr.Substring(2, 2);
                                Console.WriteLine("minus " + vienetai(Convert.ToInt32(simt1)) + " " + simtai(Convert.ToInt32(simt)) + " " + vienetai(Convert.ToInt32(vnt))); // kai x01 ..... x09
                            }
                            else
                            {
                                string des = nr.Substring(2, 1) + "0";
                                Console.WriteLine("minus " + vienetai(Convert.ToInt32(simt1)) + " " + simtai(Convert.ToInt32(simt)) + " " + desimtys(Convert.ToInt32(des)) + " " + vienetai(Convert.ToInt32(vnt))); // cia jei viskas OK
                            }
                        }


                    }

                }

                else
                {
                    Console.WriteLine("Jusu ivestas skaičius yra netinkamo formato! : " + nr);
                }





            }
            while (Console.ReadLine() == "");

            Console.ReadLine();


        }

        static bool isNumber(string nr)
        {
            for (int i = 0; i < nr.Length; i++)
            {

                char simbolis = nr[i];
                if (simbolis == '-' || simbolis == '0' || simbolis == '1' || simbolis == '2' || simbolis == '3' || simbolis == '4' || simbolis == '5' || simbolis == '6' || simbolis == '7' || simbolis == '8' || simbolis == '9')
                {
                    return true;
                }
                else

                    return false;
            }

            return false;
        }


        static void inRange(string nr, int rng1, int rng2)
        {

            if (Convert.ToInt32(nr) > rng1 && Convert.ToInt32(nr) < rng2)
            {
                Console.WriteLine("Skaičius patenka į rėžius tarp: " + rng1 + "..." + rng2 + "\n");
            }
            else
            {
                Console.WriteLine("Skaičius NEPATENKA! i rėžius tarp: " + rng1 + "..." + rng2 + "\n");
            }
        }




        static string vienetai(int SkaiciusInt)
        {
            string vnt = "";

            switch (SkaiciusInt)
            {
                case 0:
                    vnt = "";
                    break;
                case 1:
                    vnt = "vienas";
                    break;
                case 2:
                    vnt = "du";
                    break;
                case 3:
                    vnt = "trys";
                    break;
                case 4:
                    vnt = "keturi";
                    break;
                case 5:
                    vnt = "penki";
                    break;
                case 6:
                    vnt = "šeši";
                    break;
                case 7:
                    vnt = "septyni";
                    break;
                case 8:
                    vnt = "aštuoni";
                    break;
                case 9:
                    vnt = "devyni";
                    break;
            }

            return vnt;
        }


        static string desimtys(int SkaiciusInt)
        {
            string tenToninety = "";

            switch (SkaiciusInt)
            {
                case 10:
                    tenToninety = "dešimt";
                    break;
                case 11:
                    tenToninety = "vienuolika";
                    break;
                case 12:
                    tenToninety = "dvylika";
                    break;
                case 13:
                    tenToninety = "trylika";
                    break;
                case 14:
                    tenToninety = "keturiolika";
                    break;
                case 15:
                    tenToninety = "penkiolika";
                    break;
                case 16:
                    tenToninety = "šešiolika";
                    break;
                case 17:
                    tenToninety = "septyniolika";
                    break;
                case 18:
                    tenToninety = "aštuoniolika";
                    break;
                case 19:
                    tenToninety = "devyniolika";
                    break;
                case 20:
                    tenToninety = "dvidešimt";
                    break;
                case 30:
                    tenToninety = "trisdešimt";
                    break;
                case 40:
                    tenToninety = "keturiasdešimt";
                    break;
                case 50:
                    tenToninety = "penkiasdešimt";
                    break;
                case 60:
                    tenToninety = "sesiasdešimt";
                    break;
                case 70:
                    tenToninety = "septyniasdešimt";
                    break;
                case 80:
                    tenToninety = "astuoniasdešimt";
                    break;
                case 90:
                    tenToninety = "devyniasdešimt";
                    break;
                default:
                    tenToninety = "";
                    break;
            }

            return tenToninety;
        }



        static string simtai(int SkaiciusInt)
        {
            string hundreds = "";

            if (SkaiciusInt >= 100 && SkaiciusInt < 200)
            {
                hundreds = "šimtas";
            }
            else if (SkaiciusInt >= 200)
            {
                hundreds = "šimtai";
            }
            else if (SkaiciusInt == null)
            {
                hundreds = "";
            }

            return hundreds;
        }



    }
}