using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class B_Q04
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature in Centigrade scale: ");
            double cent = double.Parse(Console.ReadLine());
            //double cent = Convert.ToDouble(Console.ReadLine());
            double fahr = 1.8 * cent + 32;
            Console.WriteLine($"The temperature in Fahrenheit is {fahr:0.###}.");
            //Console.WriteLine("The temperature in Fahrenheit is {0:0.###}.",fahr);
        }
    }
}
