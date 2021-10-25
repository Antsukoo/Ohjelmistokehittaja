using System;

namespace OperaattoriHarjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0;
            float y = 0;

            Console.WriteLine("Anna X:lle numero arvo: ");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Anna Y:lle numero arvo: ");
            y = float.Parse(Console.ReadLine());

            Console.WriteLine(y);

            if (y != 0)
            {
                float firstRes = (y + 3);

                float secondRes = (y - 2);

                float thirdRes = (y * 5);

                float fourthRes = (x / y);

                float fifthRes = (x % y);

                float sixthRes = (x + y);

                float seventhRes = (x - y);

                float eigthRes = (x * y * 5);

                float ninthRes = (x / y);

                Console.WriteLine(y);
                Console.WriteLine("1. x = " + firstRes);
                Console.WriteLine("2. x = " + secondRes);
                Console.WriteLine("3. x = " + thirdRes);
                Console.WriteLine("4. x = " + fourthRes);
                Console.WriteLine("5. x = " + fifthRes);
                Console.WriteLine("6. x = " + sixthRes);
                Console.WriteLine("7. x = " + seventhRes);
                Console.WriteLine("8. x = " + eigthRes);
                Console.WriteLine("9. x = " + ninthRes);
            }
            
        }
    }
}
