// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Abolfazl_Mohseni
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("the number 2 times the entered number equals to " + Tavan(number));

            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            

        }
        public static int Tavan(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return 2 * Tavan(number - 1);
            }
        }
    }
}

