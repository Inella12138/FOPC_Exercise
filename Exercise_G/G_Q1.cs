using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class G_Q1
    {
        static void Main(string[] args)
        {
            int[] sales = { 23, 12, 98, 55, 76, 32, 45, 124, 32, 76, 47, 86 };
            string[] month = {"January","February","March","April","May","June",
                            "July","August","September","October","November","December" };
            int max = sales[0];
            int min = sales[0];
            int sum = 0;
            int ma = 0, mi = 0;
            for (int i = 1; i < sales.Length; i++)
            {
                if (sales[i] > max) { max = sales[i]; ma = i; }
                if (sales[i] < min) { min = sales[i]; mi = i; }
                sum = sum + sales[i];
            }
            Console.WriteLine(month[ma] + $" recorded the Maximum Sales of {max}");
            Console.WriteLine(month[mi] + $" recorded the Minimum Sales of {min}");
            Console.WriteLine($"The average monthly sales of the year is {sum / 12}");
        } 
    }
}
