using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class E_Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer to see if it is a prime number: ");
            int num = int.Parse(Console.ReadLine());
            int i = 2;
            while (true)
            {
                if (num % i == 0) 
                {
                    Console.WriteLine("Not Prime.");
                    break;
                }
                i++;
                if (i * i > num) 
                {
                    Console.WriteLine("Prime.");
                    break; 
                }
            }
        }
    }
}
