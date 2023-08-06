using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class B_Q06
    {
        static void Main(string[] args)
        {
            //This is a method to get the four inputs from user at once
            /*Console.Write("Please enter a1, a2, b1, b2(seperate by space): ");
            string stringInput = Console.ReadLine();
            char blk = ' ';
            string[] v = stringInput.Split(blk);
            double a1 = double.Parse(v[0]);
            double a2 = double.Parse(v[1]);
            double b1 = double.Parse(v[2]);
            double b2 = double.Parse(v[3]);*/
            Console.Write("Please enter a1, a2, b1, b2(seperate by enter): ");
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double d = Math.Sqrt((a1 - b1) * (a1 - b1) + (a2 - b2) * (a2 - b2));
            Console.WriteLine("The distance between A and B is {0}",d);
        }
    }
}
