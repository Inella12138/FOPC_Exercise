using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class E_Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer to see if it is a perfect number: ");
            int num = int.Parse(Console.ReadLine());
            int i = 2;
            int sum = 1;
            while (true)
            {
                if (num % i == 0){ sum = sum + i + num / i; }          
                i++;
                if (i * i > num) { break;}
            }
            if (sum == num) { Console.Write("The number is a perfect number.");}
            else { Console.Write("The number is Not a perfect number."); }
        }
    }
}
