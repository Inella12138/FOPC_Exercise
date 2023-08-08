using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class F_Q2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string p = Console.ReadLine();
            string t;
            string r = "";//need to have a value at first, or Line 20 "r=r+t" won't work
            for (int i = p.Length - 1; i >= 0; i--) //count from the last letter to 0
            {
                t = p.Substring(i, 1);//substract each letter from the last to the origin
                r = r + t;//form a inverted string
            }
            if (r.Equals(p)) {Console.Write("The phrase is a palindrome.");}
            else {Console.Write("The phrase is NOT a palindrome."); }
        }
    }
}
