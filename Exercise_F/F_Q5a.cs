using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class F_Q5a
    {
        static void Main(string[] args)
        {
            string[] name = new string[]{ "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            string[] name_a = name;
            int[] mark_a = mark;
            int t;      //temperory
            string ts;  //temp string
            for(int i=0; i<mark.Length-1; i++) 
            {
                for (int j = i + 1; j < mark.Length; j++) 
                {
                    if (mark_a[i] < mark_a[j]) 
                    {
                        t = mark_a[i];
                        mark_a[i] = mark_a[j];
                        mark_a[j] = t;
                        ts = name_a[i];
                        name_a[i] = name_a[j];
                        name_a[j] = ts;//name follow mark
                    }
                }
            }//bubble sort
            Console.WriteLine("Sort by Mark:\nName\tMark");//output sort by mark
            for (int i=0;i<mark.Length;i++)
            {
                Console.WriteLine(name[i] + $"\t{mark[i]}");
            }
        }
    }
}
