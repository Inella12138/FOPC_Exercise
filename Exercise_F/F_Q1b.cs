using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise
{
    internal class F_Q1b
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string p = Console.ReadLine();
            string[] vow = new string[] { "a", "e", "i", "o", "u" };//array to tell each vowel
            string t;
            p = p.ToLower();
            int[] sum = { 0,0,0,0,0 };//counters for different vowels
            for( int i = 0; i < p.Length; i++)
            {
                t = p.Substring(i, 1);
                for (int j = 0; j < 5; j++)
                {
                    if (t.Equals(vow[j]))//compare t with vow[0-4]
                    {
                        sum[j]++;//if matched, sum + 1
                        break;//if matched, end circulation (no need to compare with the rest of letters)
                    }
                }
            }
            Console.WriteLine("The numbers of each vowel:\n" +
                "a: {0}, e: {1}, i: {2}, o: {3}, u: {4}", sum[0], sum[1], sum[2], sum[3], sum[4]);
        }
    }
}
