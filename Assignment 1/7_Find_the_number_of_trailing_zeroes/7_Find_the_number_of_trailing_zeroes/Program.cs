using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_Find_the_number_of_trailing_zeroes
{

    class Program
    {
        static void Main(string[] args)
        {
            int Num = 0;

            Console.Write(" Enter Number : ");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("\tCount Of Zero In "+Find_Factorial(Num)+ " = "+Count_Zero(Num));
            Console.WriteLine();

            Console.ReadKey();
        }

        static int Find_Factorial(int N)
        {
            int Fact = 1;

            for (; N > 0; N--)
            {
                Fact = Fact * N;
            }

            return Fact;
        }

        static int Count_Zero(int No)
        {
            int Cnt = 0 , F = 0, Temp = 0;


            F = Find_Factorial(No);

            for (; F > 0; F = F / 10)
            {
                Temp = F % 10;

                if (Temp == 0)
                {
                    Cnt++;
                }
            }

            return Cnt;
        }
    }
}