using System;

namespace Harjoitussivu3
{
    class Program
    {
        static void Main(string[] args)
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

                case 8:
                    tehtava8(test);
                    break;

                case 9:
                    tehtava9(test);
                    break;

                case 10:
                    tehtava10(test);
                    break;

                case 11:
                    tehtava11(test);
                    break;

                case 12:
                    tehtava12(test);
                    break;

                case 13:
                    tehtava13(test);
                    break;

                case 14:
                    tehtava14(test);
                    break;

                case 15:
                    tehtava15(test);
                    break;

                case 16:
                    tehtava16(test);
                    break;

                case 17:
                    tehtava17(test);
                    break;


                default:
                    Console.WriteLine("Antamanne luku ei sovi yhteenkään tehtävään.");
                    break;
            }
        }

        static void tehtava1(int test)
        {

            int num1 = 8;
            int num2 = 14;
            int sum = num1 + num2;

            Console.WriteLine("This is just here to not overflow the system. Write anything to start: ");
            Console.ReadLine();

            Console.WriteLine(num1 + " + " + num2 + " on yhtä kuin " + sum);

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
            Console.WriteLine("This is just here to not overflow the system. Write anything to start: ");
            Console.ReadLine();

            float cel = 27f;
            float fahr = cel * 1.8f + 32f;

            Console.WriteLine("27 Celsius astetta on: " + fahr + " fahrenheittia.");

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
            Console.WriteLine("This is just here to not overflow the system. Write anything to start: ");
            Console.ReadLine();

            float num1 = 12f;
            float num2 = 5f;

            float sumpl = num1 + num2;
            float summi = num1 - num2;
            float summu = num1 * num2;
            float sumdi = num1 / num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + sumpl + ", " + num1 + " - " + num2 + " = " + summi + ", " + num1 + " * " + num2 + " = " + summu + ", " + num1 + " / " + num2 + " = " + sumdi + ".");

            if (test == 0)
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
            Console.WriteLine("This is just here to not overflow the system. Write anything to start: ");
            Console.ReadLine();

            int num1 = 9;
            int num2 = 4;
            int sum = num1 % num2;

            Console.WriteLine("Lukujen " + num1 + " ja " + num2 + " jakojäännös on " + sum);

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
            Console.WriteLine("Anna nimesi: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hei " + name);

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
            Console.WriteLine("Anna kaksi lukua niin lasken ne yhteen.");
            Console.WriteLine("Anna ensimmäinen luku: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            float num2 = float.Parse(Console.ReadLine());
            float sum = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " on yhtä kuin " + sum);

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
            Console.WriteLine("Anna celsius luku niin lasken kuinka paljon se on fahrenheitteina: ");
            float cel = float.Parse(Console.ReadLine());
            float fahr = cel * 1.8f + 32f;

            Console.WriteLine("27 Celsius astetta on: " + fahr + " fahrenheittia.");

            if (test == 0)
            {
                tehtava8(test);
            }
            else
            {
                tehtava7(test);
            }
        }

        static void tehtava8(int test)
        {
            Console.WriteLine("Anna kaksi lukua niin kerron sinulle niiden plus, miinus, kerto ja jakolaskujen tuloksen.");
            Console.WriteLine("Anna ensimmäinen luku: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            float num2 = float.Parse(Console.ReadLine());

            float sumpl = num1 + num2;
            float summi = num1 - num2;
            float summu = num1 * num2;
            float sumdi = num1 / num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + sumpl + ", " + num1 + " - " + num2 + " = " + summi + ", " + num1 + " * " + num2 + " = " + summu + ", " + num1 + " / " + num2 + " = " + sumdi + ".");

            if (test == 0)
            {
                tehtava9(test);
            }
            else
            {
                tehtava8(test);
            }
        }

        static void tehtava9(int test)
        {
            Console.WriteLine("Anna kaksi lukua niin kerron niiden jakojäännöksen.");
            Console.WriteLine("Anna ensimmäinen luku: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            float num2 = float.Parse(Console.ReadLine());
            float sum = num1 % num2;

            Console.WriteLine("Lukujen " + num1 + " ja " + num2 + " jakojäännös on " + sum);

            if (test == 0)
            {
                tehtava10(test);
            }
            else
            {
                tehtava9(test);
            }
        }

        static void tehtava10(int test)
        {
            Console.WriteLine("Anna minulle kokonaisluku 1-10 ja näytän sinulle sen koko kertotaulun kymmeneen asti.");
            int num = int.Parse(Console.ReadLine());
            int sum;
            if (num > 0 && num < 11)
            {
                for (int i = 1; i < 11; i++)
                {
                    sum = num * i;
                    Console.WriteLine(num + " * " + i + " = " + sum);
                }
            }
            else
            {
                Console.WriteLine("Luvun täytyy olla 1-10!");
            }


            if (test == 0)
            {
                tehtava11(test);
            }
            else
            {
                tehtava10(test);
            }
        }

        static void tehtava11(int test)
        {
            Console.WriteLine("Kerro ikäsi: ");
            string age = Console.ReadLine();

            Console.WriteLine(age + ", näytät ikäistäsi nuoremmalta.");

            if (test == 0)
            {
                tehtava11(test);
            }
            else
            {
                tehtava10(test);
            }
        }

        static void tehtava12(int test)
        {
            Console.WriteLine("Anna kokonaisluku joka on suurempi kuin 10: ");
            int num = int.Parse(Console.ReadLine());

            string text = "";
            string text2 = "";
            if (num > 10)
            {
                for (int i = 0; i < num; i++)
                {
                    for (int a = 0; a < num; a++)
                    {
                        text += num + " ";
                    }

                    for (int b = 0; b < num; b++)
                    {
                        text2 += num;
                    }
                    Console.WriteLine(text);
                    Console.WriteLine(text2);
                    text = "";
                    text2 = "";
                }
            }
            else
            {
                Console.WriteLine("Luvun täytyy olla suurempi kuin 10!");
            }
            

            if (test == 0)
            {
                tehtava11(test);
            }
            else
            {
                tehtava10(test);
            }
        }

        static void tehtava13(int test)
        {
            Console.WriteLine("Anna minulle sana niin vaihdan sen ensimmäisen ja viimeisen kirjaimen paikkaa:");
            string word = Console.ReadLine();

            int length = word.Length;
            char fc = word[length - 1];
            char lc = word[0];

            string res = word;

            res = fc + res.Remove(0, 1);
            res = res.Remove(res.Length - 1, 1) + lc;

            Console.WriteLine(res);

            if (test == 0)
            {
                tehtava11(test);
            }
            else
            {
                tehtava10(test);
            }
        }

        static void tehtava14(int test)
        {


            if (test == 0)
            {
                tehtava11(test);
            }
            else
            {
                tehtava10(test);
            }
        }

        static void tehtava15(int test)
        {


            if (test == 0)
            {
                tehtava11(test);
            }
            else
            {
                tehtava10(test);
            }
        }

        static void tehtava16(int test)
        {


            if (test == 0)
            {
                tehtava11(test);
            }
            else
            {
                tehtava10(test);
            }
        }

        static void tehtava17(int test)
        {


            if (test != 0)
            {
                tehtava17(test);
            }
        }
    }
}
