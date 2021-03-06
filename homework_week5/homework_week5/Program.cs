using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();

            if (input1 == "time")
            {
                double x1, y1, t1, p1;
                x1 = double.Parse(Console.ReadLine());
                y1 = double.Parse(Console.ReadLine());

                t1 = x1;
                p1 = Math.Pow((t1 - 1), 2);

                if (t1 < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }

                else
                {
                    Console.WriteLine("{0},{1}", t1, p1);
                }
            }

            else if (input1 == "price")
            {
                double x2, y2, t2, p2;
                x2 = double.Parse(Console.ReadLine());
                y2 = double.Parse(Console.ReadLine());

                p2 = y2;
                t2 = Math.Sqrt(p2) + 1;

                Console.WriteLine("{0},{1}", t2, p2);
            }

            else
            {
                double x3, y3;
                x3 = double.Parse(Console.ReadLine());
                y3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Invalid mode");
            }

            Console.ReadLine();

        }
    }
}
