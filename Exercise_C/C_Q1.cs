using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender(M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());
            if (gender == 'M'|| gender == 'm')
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == 'F'|| gender == 'f')
            {
                Console.WriteLine("Good Morning Ms." + name);
            }
            else 
            {
                Console.WriteLine("Please check your input!");
            }
                     
        }
    }
}
