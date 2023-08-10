using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class G_Q2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a numeric array(seperate by space): ");
            string stringInput = Console.ReadLine();
            char blk = ' ';
            string[] user = stringInput.Split(blk);
            int[] num = new int[user.Length];
            int t;
            for (int i = 0; i < user.Length; i++)
            {
                num[i] = int.Parse(user[i]);
            }
            for (int i = 0; i < num.Length - 1; i++) 
            {
                int max = num[i];
                int ma = i;
                for (int j = i + 1; j < num.Length; j++) 
                {
                    if (num[j] > max)
                    {
                        max = num[j];
                        ma = j;
                    }
                }
                t = num[i];
                num[i] = max;
                num[ma] = t;
                Console.Write($"Pass {i+1}: ");
                for (int k = 0;k < user.Length; k++) 
                {
                    Console.Write($"{num[k]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
