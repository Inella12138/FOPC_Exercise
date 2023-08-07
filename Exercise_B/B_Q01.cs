using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_B
{
    internal class Q01
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double num = double.Parse(Console.ReadLine());
            //double num = Convert.ToDouble(Console.ReadLine());
            double sqrt = Math.Sqrt(num);
            Console.WriteLine($"The square root of {num} is {sqrt:0.###}.");
            //Console.WriteLine("The square root of {0:0.###} is {1:0.###}.", num, sqrt);
        }
    }
}
