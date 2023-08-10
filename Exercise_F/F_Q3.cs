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
            string t;
            string r = "";
            string s = "";
            p = p.ToLower();
            string[] others = { ".", " ", "?", "!", "," };
            for (int i = 0; i < p.Length; i++) 
            {
                t = p.Substring(i, 1);
                //if (!t.Equals(".") && !t.Equals(" "))
                if (!others.Contains(t))
                {
                    s = s + t;//form a string without " "and "."
                }
            }
            for (int i = p.Length - 1; i >= 0; i--)
            {
                t = p.Substring(i, 1);
                if (!t.Equals(".") && !t.Equals(" ")) 
                {
                    r = r + t;//form an inverted string without " "and "."
                }
                
            }
            if (r.Equals(s)) { Console.Write("The phrase is a palindrome."); }
            else { Console.Write("The phrase is NOT a palindrome."); }
        }
    }
}
