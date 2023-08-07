using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_B
{
    internal class Q03
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your salary: ");
            double sal = double.Parse(Console.ReadLine());
            //double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your total income is ${sal} + ${sal * 0.1} + ${sal * 0.03} = ${sal * 0.13}.");
            //Console.WriteLine("Your total income is ${0} + ${1} + ${2} = ${3}.", sal, sal * 0.1, sal * 0.03, sal * 0.13);
        }
    }
}
