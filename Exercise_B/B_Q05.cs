using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class B_Q05
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter x: ");
            double x = double.Parse(Console.ReadLine());
            //double x = Convert.ToDouble(Console.ReadLine());
            double y = 5 * x * x - 4 * x + 3;
            Console.WriteLine($"The value for 5x^2-4x+3 is {y:0.###}.");
            //Console.WriteLine("The value for 5x^2-4x+3 is {0:0.###}.",y);
        }
    }
}
