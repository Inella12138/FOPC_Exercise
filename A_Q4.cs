using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class A_Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double num = double.Parse(Console.ReadLine());
            //double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The square of that number is {num * num}.");
        }
    }
}
