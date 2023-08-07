using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_B
{
    internal class Q08
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your travel distance: ");
            double x = double.Parse(Console.ReadLine());
            //double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Round(2.4 + 0.4 * x, 1);
            Console.WriteLine($"The total fare is ${y:0.00}.");
            //Console.WriteLine("The total fare is ${0:0.00}.",y);
        }
    }
}
