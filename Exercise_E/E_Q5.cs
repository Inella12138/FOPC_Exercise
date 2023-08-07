using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class E_Q5
    {
        static void Main(string[] args)
        {
            int num = 5;
            while (num<10001)
            {
                int i = 2;
                while (true)
                {
                    if (num % i == 0){break;}
                    i++;
                    if (i * i > num)
                    {
                        Console.Write($"{num}\t");
                        break;
                    }
                }
                num++;
            }
            Console.WriteLine("\n");
        }
    }
}
