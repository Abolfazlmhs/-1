﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Fibonacci
{
    class program
    {
        public static int Fibonacci (int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main()
        {
            for (int i = 0;i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadLine();
        }
    }
}
