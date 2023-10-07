using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class E_Q6
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num < 10001)
            {
                int i = 2;
                int sum = 1;
                while (i * i <= sum) 
                {
                    if (num % i == 0) { sum = sum + i + num / i; }
                    i++;
                }
                if (sum == num) { Console.Write($"{num}\t"); }
                num++;
            }
            Console.WriteLine("\n");
        }
    }
}
