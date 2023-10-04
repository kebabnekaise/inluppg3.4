using System;

namespace inluppg3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många hela minuter är din låt?");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många resterande sekunder är din låt?");
            int sekunder = int.Parse(Console.ReadLine());

            int totalaSekunder = (minuter * 60) + sekunder;
            if (totalaSekunder <= 4*60+20 && totalaSekunder >= 2 * 60 + 45)
            {
                Console.WriteLine("Din låt får spelas på stationen");
            }
            else
            {
                Console.WriteLine("Din låt får inte spelas på stationen");
            }

        }
    }
}