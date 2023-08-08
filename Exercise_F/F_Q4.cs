using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class F_Q4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string read = Console.ReadLine();
            string[] p = read.Split(' ');
            string t;
            string r = "";
            for (int i = 0; i < p.Length; i++)//to search each word
            {                             //in this program, p.Length returns the length of an array
                for(int j=0;j < p[i].Length; j++) // to search each letter
                {                         //in this program, p[i].Length returns the length of a word
                    t = p[i].Substring(j, 1);
                    if (j==0)
                    {
                        t = t.ToUpper();//Capitalize the first letter of each word
                    }
                    r = r + t;
                }
                r = r + " ";//when using Split(' '), space was removed, so we add space again at here
            }
            Console.Write(r);
        }
    }
}
