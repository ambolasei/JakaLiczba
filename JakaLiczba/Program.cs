using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakaLiczba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWprowadź liczbe: ");

            var number = GetNumber();

            if (number%2==0)
            {
            Console.WriteLine($"\nWprowadzona liczba {number} jest liczbą parzystą.");
            }
            else
            {
                Console.WriteLine($"\nWprowadzona liczba {number} jest liczbą nieparzystą.");
            }
        }
        
        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int inputedNumber))
                {
                Console.WriteLine("\nWprowadzono nieprawidłową liczbe. Spróbuj ponownie:");
                continue;
                }
                return inputedNumber;
            }

        }
    }
}
