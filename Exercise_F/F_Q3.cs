using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class F_Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string p = Console.ReadLine();
            string t,t1;
            string r = "";
            string s = "";
            p = p.ToLower();
            string[] others = { ".", " ", "?", "!", "," };
            for (int i = 0; i < p.Length; i++) 
            {
                t = p.Substring(i, 1);
                t1 = p.Substring(p.Length - 1 - i, 1);
                if (!others.Contains(t))
                {
                    s = s + t;//form a string without " "and "."
                }
                if (!others.Contains(t1))
                {
                    r = r + t;
                }
            }
            if (r.Equals(s)) { Console.Write("The phrase is a palindrome."); }
            else { Console.Write("The phrase is NOT a palindrome."); }
        }
    }
}
