using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_Print_Alternate_Order
{

    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Up:
            Console.Write("\n Enter Elements Count : ");
            N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("\n Please Enter Positive Number.\n");
                goto Up;
            }

            int[] arr = new int[N];

           

            Alternate_Order(arr);

           

            Console.ReadKey();
        }
          
     static void Alternate_Order(int[] A)
        {

                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("\n Enter Element : ");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }

               

                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine("\n "+i+"th Element = "+A[i]);
                }

                Console.WriteLine("\n Alternate Order : \n\t");

                for (int j = 0; j < A.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(" " + A[j]);
                    }
                }

                

            return;
        }
    }
}