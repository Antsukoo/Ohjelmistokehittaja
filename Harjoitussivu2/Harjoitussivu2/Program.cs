using System;

namespace Harjoitussivu2
{
    class Program
    {
        static void Main()
        {
            TehtavaValinta();
        }

        static void TehtavaValinta()
        {
            Console.WriteLine("Testausta varten valitse tehtävän numero jonka haluat testata (1-7), tai 0 jos haluat käydä kaikki läpi: ");
            int test = int.Parse(Console.ReadLine());

            switch (test)
            {
                case 0:
                    tehtava1(test);
                    break;

                case 1:
                    tehtava1(test);
                    break;

                case 2:
                    tehtava2(test);
                    break;

                case 3:
                    tehtava3(test);
                    break;

                case 4:
                    tehtava4(test);
                    break;

                case 5:
                    tehtava5(test);
                    break;

                case 6:
                    tehtava6(test);
                    break;

                case 7:
                    tehtava7(test);
                    break;


                default:
                    Console.WriteLine("Antamanne luku ei sovi yhteenkään tehtävään.");
                    break;
            }
        }

        static void tehtava1(int test)
        {
            int num1 = 0, num2 = 0;

            Console.WriteLine("Anna 2 lukua ja asetan ne suuruusjärjestykseen.");

            Console.WriteLine("Anna arvo ensimmäiselle luvulle: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna arvo toiselle luvulle");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Suuruusjärjestyksessä numero 1. " + num1 + " on suurempi kuin numero 2. " + num2 + ".");

            }
            else if (num1 == num2)
            {
                Console.WriteLine("Suuruusjärjestyksessä numero 1. " + num1 + " on yhtä iso kuin numero 2. " + num2 + ".");
            }
            else
            {
                Console.WriteLine("Suuruusjärjestyksessä numero 2. " + num2 + " on suurempi kuin numero 1. " + num1 + ".");
            }

            if (test == 0)
            {
                tehtava2(test);
            }
            else
            {
                tehtava1(test);
            }
        }

        static void tehtava2(int test)
        {
            

            int[] num = {0, 0, 0};

            int[] nums = {0, 0, 0};

            Console.WriteLine("Anna kolme kokonaislukua ja tulostan sinulle niistä suurimman.");
            Console.WriteLine("Anna ensimmäinen luku: ");
            num[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            num[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna kolmas luku: ");
            num[2] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (num[i] >= num[y])
                    {
                        nums[i]++;
                    }
                }
                
            }

            for (int a = 0; a < 3; a++)
            {
                if (nums[a] == 3)
                {
                    Console.WriteLine("Luvuista suurin on: " + num[a]);
                    break;
                }
                
            }

            if (test == 0)
            {
                tehtava3(test);
            }
            else
            {
                tehtava2(test);
            }
        }

        static void tehtava3(int test)
        {
            Console.WriteLine("Anna kokonaisluku (1-9) ja tulostan sen sanan.");
            int num = int.Parse(Console.ReadLine());

            bool got = true;

            switch (num)
            {
                case 1:
                    Console.WriteLine("Yksi.");
                    break;

                case 2:
                    Console.WriteLine("Kaksi.");
                    break;

                case 3:
                    Console.WriteLine("Kolme.");
                    break;

                case 4:
                    Console.WriteLine("Neljä.");
                    break;

                case 5:
                    Console.WriteLine("Viisi.");
                    break;

                case 6:
                    Console.WriteLine("Kuusi.");
                    break;

                case 7:
                    Console.WriteLine("Seitsemän.");
                    break;

                case 8:
                    Console.WriteLine("Kahdeksan.");
                    break;

                case 9:
                    Console.WriteLine("Yhdeksän.");
                    break;

                default:
                    Console.WriteLine("Numeron täytyy olla 1-9!");
                    got = false;
                    break;


            }


            if (test == 0 && got)
            {                
                tehtava4(test);
            }
            else
            {
                tehtava3(test);
            }
        }

        static void tehtava4(int test)
        {
            int[] num = { 0, 0, 0, 0, 0 };

            int[] nums = { 0, 0, 0, 0, 0 };

            Console.WriteLine("Anna viisi kokonaislukua ja tulostan sinulle niistä suurimman.");
                       
            Console.WriteLine("Anna ensimmäinen luku: ");
            num[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            num[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna kolmas luku: ");
            num[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna neljäs luku: ");
            num[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna viides luku: ");
            num[4] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (num[i] >= num[y])
                    {
                        nums[i]++;
                    }
                }

            }

            for (int a = 0; a < 5; a++)
            {
                if (nums[a] == 5)
                {
                    Console.WriteLine("Luvuista suurin on: " + num[a]);
                    break;
                }

            }

            if (test == 0)
            {
                tehtava5(test);
            }
            else
            {
                tehtava4(test);
            }
        }

        static void tehtava5(int test)
        {
            

            int number = 0;

            bool got = false;

            while (!got)
            {
                Console.WriteLine("Mitä haluaisit syöttää näistä minulle: kokonaisluku (k) vai double-luvun (d), jotka kasvattavat annosta vai merkkijonon (m), joka syöttää annoksen minulle.");
                string letter = Console.ReadLine();

                

                switch (letter)
                {
                    case "k":
                        number++;
                        break;

                    case "d":
                        number++;
                        break;

                    case "m":
                        got = true;
                        break;

                    default:
                        Console.WriteLine("Sinun täytyy valita joko k, d tai m.");
                        break;
                }
            }

            Console.WriteLine("Syötit: " + number + "*");
            

            if (test == 0)
            {
                tehtava6(test);
            }
            else
            {
                tehtava5(test);
            }
        }

        static void tehtava6(int test)
        {


            if (test == 0)
            {
                tehtava7(test);
            }
            else
            {
                tehtava6(test);
            }
        }

        static void tehtava7(int test)
        {
            Console.WriteLine("Anna luku 0-999 ja muutan sen sanaksi.");
            int num = int.Parse(Console.ReadLine());


            if (num.ToString().Length == 1)
            {
                
            }

            if (num.ToString().Length == 2)
            {
                for (int a = 0; a < 9; a++)
                {
                    if (num.ToString()[0] == a.ToString()[0])
                    {

                    }
                }
            }

            
            
            if (test != 0)
            {
                tehtava7(test);
            }
        }

        static string tehtava75(int num)
        {
            string sana = "";
            switch (num)
            {

                case 0:
                    sana = "Nolla";
                    break;

                case 1:
                    sana = "Yksi.";
                    break;

                case 2:
                    sana = "Kaksi.";
                    break;

                case 3:
                    sana = "Kolme.";
                    break;

                case 4:
                    sana = "Neljä.";
                    break;

                case 5:
                    sana = "Viisi.";
                    break;

                case 6:
                    sana = "Kuusi.";
                    break;

                case 7:
                    sana = "Seitsemän.";
                    break;

                case 8:
                    sana = "Kahdeksan.";
                    break;

                case 9:
                    sana = "Yhdeksän.";
                    break;
                    
            }
            return sana;
        }


    }
}
