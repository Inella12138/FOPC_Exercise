using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class B_Q09
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your travel distance: ");
            double x = double.Parse(Console.ReadLine());
            //double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Ceiling(24 + 4 * x) / 10;
            Console.WriteLine($"The total fare is ${y:0.0}.");
            //Console.WriteLine("The total fare is ${0:0.0}.",y);
        }
    }
}
