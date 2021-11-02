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
            Console.WriteLine("Mitä haluaisit syöttää näistä minulle: kokonaisluku (k) vai double-luvun (d), jotka kasvattavat annosta vai merkkijonon (m), joka syöttää annoksen minulle.");
                
            ALKU:
            string letter = Console.ReadLine().ToLower();

                

            switch (letter)
            {
                case "k":
                    Console.WriteLine("Anna jokin kokonaisluku: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Syötit luvun " + num + " ja lisäsin siihen yhden: " + (num + 1));
                    break;

                case "d":
                    Console.WriteLine("Anna jokin desimaaliluku: ");
                    int doub = int.Parse(Console.ReadLine());

                    Console.WriteLine("Syötit luvun " + doub + " ja lisäsin siihen yhden: " + (doub + 1));
                    break;

                case "m":
                    Console.WriteLine("Anna jokin kokonaisluku: ");
                    string merk = Console.ReadLine();

                    Console.WriteLine("Syötit merkkijonon " + merk + " ja lisäsin siihen tähden: " + merk + "*");
                    break;

                default:
                    Console.WriteLine("Sinun täytyy syöttää joko k, d tai m-kirjain.");
                    goto ALKU;
            }
            

            
            

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
            Console.WriteLine("Anna minulle bonuspisteiden määrä 1-9 ja kerron sen sille määrätyllä luvulla: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            if (num < 1 || num > 9)
            {
                Console.WriteLine("Määrän täytyy olla 1-9!");
            }else if (num > 0 && num < 4)
            {
                sum = num * 10;
                Console.WriteLine("Kertomisen jälkeen pisteenne nousi lukuun: " + sum);
            }
            else if (num > 3 && num < 7)
            {
                sum = num * 100;
                Console.WriteLine("Kertomisen jälkeen pisteenne nousi lukuun: " + sum);
            }
            else if (num > 6 && num < 10)
            {
                sum = num * 1000;
                Console.WriteLine("Kertomisen jälkeen pisteenne nousi lukuun: " + sum);
            }

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
            string word = "";
            

            if (num.ToString().Length == 1)
            {
                word += tehtava75(num) + ".";
            }

            if (num.ToString().Length == 2 && num.ToString()[0] != '0')
            {
                bool done = false;
                for (int a = 2; a < 10; a++)
                {
                    
                    if (num.ToString()[0] == '1' && !done)
                    {

                        string num2 = num.ToString()[1].ToString();

                        

                        switch (num2)
                        {
                            case "0":
                                word += "kymmenen.";
                                done = true;
                                break;

                            case "1":
                                word += tehtava75(1) + "toista";
                                done = true;
                                break;

                            case "2":
                                word += tehtava75(2) + "toista";
                                done = true;
                                break;

                            case "3":
                                word += tehtava75(3) + "toista";
                                done = true;
                                break;

                            case "4":
                                word += tehtava75(4) + "toista";
                                done = true;
                                break;

                            case "5":
                                word += tehtava75(5) + "toista";
                                done = true;
                                break;

                            case "6":
                                word += tehtava75(6) + "toista";
                                done = true;
                                break;

                            case "7":
                                word += tehtava75(7) + "toista";
                                done = true;
                                break;

                            case "8":
                                word += tehtava75(8) + "toista";
                                done = true;
                                break;

                            case "9":
                                word += tehtava75(9) + "toista";
                                done = true;
                                break;
                        }
                    }

                    if (num.ToString()[0] == a.ToString()[0] && num.ToString()[0] != '1')
                    {
                        word += tehtava75(a) + "kymmentä";
                    }
                }

                for (int b = 1; b < 10; b++) 
                {

                    if (num.ToString()[1] == b.ToString()[0] && num.ToString()[1] != '0' && num.ToString()[0] != '1')
                    {
                        word += " " + tehtava75(b) + ".";
                    }

                    if (num.ToString()[1] == b.ToString()[0] && num.ToString()[1] != '0' && num.ToString()[0] == '1')
                    {
                        word += ".";
                    }

                    if (num.ToString()[1] == b.ToString()[0] && num.ToString()[1] == '0' && num.ToString()[0] == '1')
                    {
                        word += ".";
                    }
                }
            }

            if (num.ToString().Length == 3 && num.ToString()[0] != '0')
            {
                bool done = false;
                bool done2 = false;
                for (int c = 2; c < 10; c++)
                {
                    if (num.ToString()[0] == c.ToString()[0] && num.ToString()[0] != '1')
                    {
                        word += tehtava75(c) + "sataa";
                    }

                    if (num.ToString()[0] == '1' && !done2)
                    {
                        done2 = true;
                        word += "sata";
                    }
                }

                for (int d = 1; d < 10; d++)
                {
                    
                    if (num.ToString()[1] == 0)
                    {
                        word += "";
                    }

                    if (num.ToString()[1] == d.ToString()[0] && num.ToString()[1] != '0' && num.ToString()[1] != '1')
                    {
                        word += " " + tehtava75(d) + "kymmentä";
                    } 
                }

                for (int e = 1; e < 10; e++)
                {
                    if (num.ToString()[1] == '1' && !done)
                    {

                        string num2 = num.ToString()[2].ToString();

                        switch (num2)
                        {
                            case "0":
                                word += "kymmenen.";
                                done = true;
                                break;

                            case "1":
                                word += tehtava75(1) + "toista";
                                done = true;
                                break;

                            case "2":
                                word += tehtava75(2) + "toista";
                                done = true;
                                break;

                            case "3":
                                word += tehtava75(3) + "toista";
                                done = true;
                                break;

                            case "4":
                                word += tehtava75(4) + "toista";
                                done = true;
                                break;

                            case "5":
                                word += tehtava75(5) + "toista";
                                done = true;
                                break;

                            case "6":
                                word += tehtava75(6) + "toista";
                                done = true;
                                break;

                            case "7":
                                word += tehtava75(7) + "toista";
                                done = true;
                                break;

                            case "8":
                                word += tehtava75(8) + "toista";
                                done = true;
                                break;

                            case "9":
                                word += tehtava75(9) + "toista";
                                done = true;
                                break;
                        }
                    }
                    if (num.ToString()[2] == 0)
                    {
                        word += ".";
                    }

                    if (num.ToString()[2] == e.ToString()[0] && num.ToString()[2] != '0' && num.ToString()[1] == '1')
                    {
                        word += ".";
                    }

                    if (num.ToString()[2] == e.ToString()[0] && num.ToString()[2] == '0' && num.ToString()[1] == '1')
                    {
                        word += ".";
                    }

                    if (num.ToString()[2] == e.ToString()[0] && num.ToString()[2] != '0' && num.ToString()[1] != '1')
                    {
                        word += " " + tehtava75(e) + ".";
                    }
                }                
            }

            if (word != "sata")
            {
                Console.WriteLine(word);
            }
            else
            {
                Console.WriteLine(word + ".");
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
                    sana = "nolla";
                    break;

                case 1:
                    sana = "yksi";
                    break;

                case 2:
                    sana = "kaksi";
                    break;

                case 3:
                    sana = "kolme";
                    break;

                case 4:
                    sana = "neljä";
                    break;

                case 5:
                    sana = "viisi";
                    break;

                case 6:
                    sana = "kuusi";
                    break;

                case 7:
                    sana = "seitsemän";
                    break;

                case 8:
                    sana = "kahdeksan";
                    break;

                case 9:
                    sana = "yhdeksän";
                    break;
                    
            }
            return sana;
        }


    }
}
