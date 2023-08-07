using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_A
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double num = double.Parse(Console.ReadLine());
            //double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num:0.00}");
            //When using the sentnce below:
            //Console.WriteLine("{0:0.00}", num);
            //Do note that "$" should not be used if {0} refers to a variable after.
        }
    }
}
