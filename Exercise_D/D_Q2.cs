using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class D_Q2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter integer numbers A and B(seperate by space): ");
            string stringInput = Console.ReadLine();
            char blk = ' ';
            string[] v = stringInput.Split(blk);
            int a = int.Parse(v[0]); int A = a;
            int b = int.Parse(v[1]); int B = b;
            int t;
            while (true) 
            {
                if (A == B) { break; }
                if (A > B) { t = A; A = B; B = t; }
                B = B - A;
            }
            int HCF = A;
            int LCM = a * b / HCF;
            Console.WriteLine($"LCM = {LCM}, HCF = {HCF}");
        }
    }
}
