using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class E_Q1b
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            int t = num;
            int rst = 1;
            do
            {
                rst = rst * t;
                t--;
            }
            while (t != 1);
            Console.WriteLine($"The factorial of {num} is {rst}.");
        }
    }
}
