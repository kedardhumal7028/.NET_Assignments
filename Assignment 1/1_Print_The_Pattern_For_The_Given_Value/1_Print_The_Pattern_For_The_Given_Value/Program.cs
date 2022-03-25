using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Print_The_Pattern_For_The_Given_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            Console.Write("Enter a Number : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = N; j > 0; j--)
                {
                    for (int k = N; k > i; k--)
                    {
                        Console.Write(j);

                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}