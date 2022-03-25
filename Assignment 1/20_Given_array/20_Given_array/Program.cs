using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_Given_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            Console.Write(" \nEnter Count To Create Array : ");
            N = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("\n Enter Number : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Create_Product_Array(num);

            Console.ReadKey();
        }

        static void Create_Product_Array(int []arr)
        {
            
            int[] P = new int[arr.Length];

            int Ans = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        Ans = Ans * arr[j];
                        P[i] = Ans;

                    }
                }

                Ans = 1;    
            }

            Display_Product_Array(P);

            return;
        }

        static void Display_Product_Array(int []p)
        {
            Console.WriteLine();

            Console.Write("\n Product Array Elements : \n");

            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("\t\t\t P["+i+"] = "+p[i]);
            }

            Console.WriteLine();
            return;
        }
    }
}