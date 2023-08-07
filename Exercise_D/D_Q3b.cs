using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class D_Q3b
    {
        static void Main(string[] args)
        {
            Random ra = new Random();
            int ans = ra.Next(9);
            int count = 0;
            Console.WriteLine("Let's play a game, I'll think of an integer between 0 and 9," +
                " and you can guess what the number is.");
            while (true)
            {
                count = count + 1;
                Console.Write("Can you guess what the number is? ");
                int gues = int.Parse(Console.ReadLine());
                if (gues == ans) { break; }
                else { Console.WriteLine("Sorry, that's not correct, you may try again!"); }
            }
            if (count == 1)
            {
                Console.WriteLine($"You are a Wizard! The number is {ans}, you tried for only 1 time!"); 
            }
            else if(count>1&&count<3)
            {
                Console.WriteLine($"You are a good guess! The number is {ans}, you tried for {count} times!");
            }
            else
            {
                Console.WriteLine($"You are lousy! The number is {ans}, you tried for {count} times!");
            }
        }
    }
}
