using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class H_Q6
    {
        public static bool IsPrime(int n)
        {
            bool flag = true;
            int i = 2;
            while (flag)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
                i++;
                if (i * i > n) { break; }
            }
            return flag;
        }

        static void Main(string[] args)
        {
            for (int i = 5; i < 1001; i++) 
            {
                bool flag = IsPrime(i);
                if (flag) { Console.Write("{0}\t", i); }
            }
        }
    }
}
