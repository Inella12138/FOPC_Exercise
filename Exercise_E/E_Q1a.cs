using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class E_Q1a
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            int rst = 1;
            for (int i = 1; i < num + 1; i++) 
            {
                rst = rst * i;
            }
            Console.WriteLine($"The factorial of {num} is {rst}.");
        }
    }
}
