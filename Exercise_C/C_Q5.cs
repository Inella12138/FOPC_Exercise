using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class C_Q5
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a 3-digit integer to see whether it is an Armstrong number: ");
            double num = double.Parse(Console.ReadLine());
            double n1 = Math.Floor(num / 100);
            double n2 = Math.Floor((num-100*n1) / 10);
            double n3 = num - 100 * n1 - 10 * n2;
            double n = Math.Pow(n1, 3) + Math.Pow(n2, 3) + Math.Pow(n3, 3);
            if (n == num)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");        
            }
        }
    }
}
