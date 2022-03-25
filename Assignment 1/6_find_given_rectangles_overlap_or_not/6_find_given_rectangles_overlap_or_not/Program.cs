using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_find_given_rectangles_overlap_or_not
{

    class Program
    {
       public int x, y;

        static void Main(string[] args)
        {
            Program l1 = new Program(), r1 = new Program(),
                l2 = new Program(), r2 = new Program();

            Console.Write(" Enter Top Left 1st Co-ordinate Of 1st Rectangle : ");
            l1.x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Top Left 2nd Co-ordinate Of 1st Rectangle : ");
            l1.y = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Bottom Right 1st Co-ordinate Of 1st Rectangle : ");
            r1.x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Bottom Right 2nd Co-ordinate Of 1st Rectangle : ");
            r1.y = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Top Left 1st Co-ordinate Of 2nd Rectangle : ");
            l2.x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Top Left 2nd Co-ordinate Of 2nd Rectangle : ");
            l2.y = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Bottom Right 1st Co-ordinate Of 2nd Rectangle : ");
            r2.x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter Bottom Right 2nd Co-ordinate Of 2nd Rectangle : ");
            r2.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (isOverlap(l1, r1, l2, r2)==1)
            {
                Console.WriteLine("\t Rectangles Overlap");
            }
            else
            {
                Console.WriteLine("\t Rectangles Don't Overlap");
            }

            Console.WriteLine();

            Console.ReadKey();
        }

        static int isOverlap(Program L1, Program R1, Program L2, Program R2)
        {
            if (L1.x >= R2.x )
            {
                return 0;
            }

            if (R1.y >= L2.y  )
            {
                return 0;
            }

            return 1;
        }
    }
}