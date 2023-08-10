using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercise
{
    internal class H_Q3
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string[] t = s.Split(c1);
            string s1 = "";
            for (int i = 0; i < t.Length; i++)
            {
                s1 += t[i];
                if (i != t.Length - 1)
                {
                    s1 += Convert.ToString(c2);
                }
            }
            return s1;
        }

        static void Main()
        {
            string s = "Hello World";
            char a = 'o';
            char b = 's';
            string c = Substitute(s, a, b);
            Console.WriteLine(c);
        }
    }
}
