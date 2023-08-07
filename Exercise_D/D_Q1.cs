using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class D_Q1
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Please enter an integer number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 88) 
                {
                    Console.WriteLine("Lucky you...");
                    break;
                }
            }
        }
    }
}
