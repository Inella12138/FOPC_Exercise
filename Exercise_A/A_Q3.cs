using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_A
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            //int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The square of that number is {num * num}.");
        }
    }
}
