using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class B_Q07
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your travel distance: ");
            double x = double.Parse(Console.ReadLine());
            //double x = Convert.ToDouble(Console.ReadLine());
            double y = 2.4 + 0.4 * x;
            Console.WriteLine($"The total fare is ${y}.");
            //Console.WriteLine("The total fare is ${0}.",y);
        }
    }
}
