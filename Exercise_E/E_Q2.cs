using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class E_Q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NO \tINVERSE\tSQUARE ROOT\tSQUARE");
            for (int i = 1; i < 11; i++) 
            {
                Console.WriteLine($"{i:0.0} \t{1 / i:0.0##} \t{Math.Sqrt(i):0.0##} \t\t{i*i:0.0}");
            }
        }
    }
}
