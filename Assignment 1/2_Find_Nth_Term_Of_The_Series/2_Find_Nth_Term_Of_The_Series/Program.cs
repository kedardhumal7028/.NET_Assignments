using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Find_Nth_Term_Of_The_Series
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int A1 = 0, A2 = 0 , N;

            Console.Write(" Enter 1st Number : ");
            A1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter 2nd Number : ");
            A2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Term And Find : ");
            N = Convert.ToInt32(Console.ReadLine());

           

            Console.Write("\n\t"+N+"th Term Of The Series is = "+ Find_Arithmetic_Series_Term(A1, A2,N));

           

            Console.ReadKey();
        }

        static int Find_Arithmetic_Series_Term(int a1, int a2,int n)
        {
            int Term = 0, Diff = 0;

            Diff = a2-a1;

            Term = a1 + (n - 1) * Diff;

            return Term;
        }
    }
}