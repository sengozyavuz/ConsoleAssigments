using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("   (1)- Enter \" 1 \" for the List o Prime Numbers " +
                          "\n   and Multiply the Prime Numbers Found" +
                          "\n   (000)- Enter \" 000 \" to exit the program", Console.ForegroundColor = ConsoleColor.Green);

                Console.Write("\n\n Enter Number   :                                     ", Console.ForegroundColor = ConsoleColor.White);
                Console.SetCursorPosition(18, 4);
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Display Option :                                     ", Console.ForegroundColor = ConsoleColor.Cyan);
                Console.ResetColor();
                Console.SetCursorPosition(18, 5);
                string caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "1":
                        MultiRowDelete(40);
                        Console.SetCursorPosition(0, 7);
                        Console.WriteLine("List of Prime Numbers -----> {0}", string.Join(",", ListPrimesNumbers(number)));
                        Console.WriteLine("Multiply the Prime Numbers Found -----> {0}", string.Join(",", ListPrimesNumbers(number).Aggregate((total, next) => total * next)));

                        break;
                    case "999":
                        Environment.Exit(3);
                        break;
                    default:
                        MultiRowDelete(40);
                        Console.SetCursorPosition(0, 7);
                        Console.WriteLine("\n\n*** P.S. : Please enter a value from the list! ***", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();

                        break;
                }

            }
        }


        private static IEnumerable<int> PrimesNumbers()
        {

            IEnumerable<int> primes =
                Enumerable.Range(2, Int32.MaxValue - 1)
                .Where(number =>
                    Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
                    .All(divisor => number % divisor != 0));
            return primes;

        }

        private static List<int> ListPrimesNumbers(int number)
        {
            return PrimesNumbers()
                .TakeWhile(p => p < number)
                .ToList();
        }

        public static void MultiRowDelete(int line)
        {

            for (int i = 1; i < line; i++)
            {
                Console.Write(new String(' ', Console.BufferWidth));
            }


        }

    }
}
