using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_A
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double num = double.Parse(Console.ReadLine());
            //double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of {0} is {1}.", num, num * num);
            //Console.WriteLine($"The square of {num} is {num * num}.");
        }
    }
}
