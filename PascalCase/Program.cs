using System;
using System.Linq;

namespace PascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("   (1)- Enter \" 1 \" the value to find the words 'PascalCase'  " +
                          "\n   (000)- Enter \" 000 \" to exit the program", Console.ForegroundColor = ConsoleColor.Green);

                Console.Write("\n\n Enter Number   :                                                      " +
                    "                                             ", Console.ForegroundColor = ConsoleColor.White);
                Console.SetCursorPosition(18, 3);
                string str = Convert.ToString(Console.ReadLine());
                Console.Write(" Display Option :                                                           " +
                    "                                              ", Console.ForegroundColor = ConsoleColor.Cyan);
                Console.ResetColor();
                Console.SetCursorPosition(18, 4);
                string caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "1":
                        MultiRowDelete(40);
                        Console.SetCursorPosition(0, 7);
                        FoundUpperCaseCharacters(str);
                        break;
                    case "999":
                        Environment.Exit(3);
                        break;
                    default:
                        MultiRowDelete(40);
                        Console.SetCursorPosition(0, 7);
                        Console.WriteLine("\n\n*** P.S. : Please enter a value from the list! ***",
                                            Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();

                        break;
                }

            }
        }

        private static void FoundUpperCaseCharacters(string str)
        {
            string result = string.Concat(str.Where(c => char.IsUpper(c) || char.IsDigit(c)));

            Console.WriteLine("Result ----> {0}", string.Join(",", result));
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
