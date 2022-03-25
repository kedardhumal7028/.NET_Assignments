using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_Check_Given_No_Of_Power
{
 class Program
    {
        static void Main(string[] args)
        {
            int X = 0, Y = 0 , Ret = 0;

            Up:
            Console.Write(" Enter 1st Number : ");
            X = Convert.ToInt32(Console.ReadLine());

            if (X <= 0)
            {
                Console.WriteLine("\n Please Enter Positive Number...\n");
                goto Up;
            }

            up:
            Console.Write("\n Enter 2nd Number : ");
            Y = Convert.ToInt32(Console.ReadLine());

            if (Y <= 0)
            {
                Console.WriteLine("\n Please Enter Positive Number...\n");
                goto up;
            }

            Ret = Check(X,Y);

            if (Ret == 1)
            {
                Console.WriteLine();

                Console.Write("\n"+Y + " is a Power Of " + X);

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();

                Console.Write("\n"+Y + " is Not a Power Of " + X);

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int Check(int x, int y)
        {
            int Res = 1;

            Console.WriteLine("\n Powers Of " + x + " : ");
            for (; Res<y ; )
            {
                Res = x * Res;
                Console.WriteLine("\t\t"+Res);
            }

            if (Res == y)
            {
                return 1;
            }

            return 0;
              
        }
    }
}