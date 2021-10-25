using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä nimesi.");
            
            string nimi = Console.ReadLine();

            Console.WriteLine("Hei " + nimi);
        }
    }
}
