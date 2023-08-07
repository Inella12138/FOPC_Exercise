using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Exercise
{
    internal class C_Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your travel distance(km): ");
            double x = Math.Ceiling(double.Parse(Console.ReadLine())*10)/10;
            double fare = 0;
            if (x < 0)
            {
                Console.WriteLine("Travel distance should not be a negative number!");
            }
            else if (x >= 0 && x <= 0.5)
            {
                fare = 2.4;
            }
            else if (x > 0.5 && x <= 9) 
            {
                fare = 2.4 + 0.4 * (x - 0.5);
            }
            else
            {
                fare = 2.4 + 0.4 * 8.5 + 0.5 * (x - 9);
            }
            Console.WriteLine($"The total fare is ${fare:0.00}.");
        }
    }
}
