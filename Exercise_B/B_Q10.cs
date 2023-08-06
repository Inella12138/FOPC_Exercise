using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class B_Q10
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the triangle's three sides(seperate by space): ");
            string stringInput = Console.ReadLine();
            char blk = ' ';
            string[] v = stringInput.Split(blk);
            double[] l = new double[3];
            l[0] = double.Parse(v[0]);
            l[1] = double.Parse(v[1]);
            l[2] = double.Parse(v[2]);
            double t = 0;
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (l[i] > l[i + 1])
                    {
                        t = l[i];
                        l[i] = l[i + 1];
                        l[i + 1] = t;
                    }
                }
            }
            double s = (l[0] + l[1] + l[2]) / 2;
            if (l[0] + l[1] > l[2])
            {
                double area = Math.Sqrt(s * (s - l[0]) * (s - l[1]) * (s - l[2]));
                Console.WriteLine($"The area of the triangle is {area:0.000}.");
                Console.WriteLine("The area of the triangle is {0:0.000}.", area);
            }
            else Console.WriteLine("The three sides can not form a triangle!");
        }
    }
}
