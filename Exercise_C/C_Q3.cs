using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class C_Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your mark: ");
            int mark = int.Parse(Console.ReadLine());
            if (mark < 0 || mark > 100)  
            {
                Console.WriteLine("Please check your mark!");
            }
            string[] grade = new string[] { "F", "F", "C", "B", "A" };
            for(int i = 0; i < 5; i++) 
            {
                if (mark > i * 20 && mark < i * 20 + 20) 
                {
                    Console.WriteLine($"Your mark is {mark} which is " + grade[i] + " grade");
                }
            }

        }
    }
}
