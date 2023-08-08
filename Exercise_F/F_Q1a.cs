using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class F_Q1a
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string p = Console.ReadLine();
            string vow = "aeiou";   //use .Contains() to tell whether a letter is a vowel
            string t;               //temporary, act as a container of substring
            p = p.ToLower();        //easier for compare, no need to care about capitals, AEIOU
            int sum = 0;            //a counter
            for (int i = 0; i < p.Length; i++)
            {
                t = p.Substring(i, 1);  //substract each character
                if (vow.Contains(t)) 
                {
                    sum++;
                }            
            }
            Console.WriteLine("The number of vowels in the phrase is: {0}",sum);
        }
    }
}
