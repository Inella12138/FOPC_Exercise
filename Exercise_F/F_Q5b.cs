using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class F_Q5b
    {
        static void Main(string[] args)
        {
            string[] name = new string[]{ "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            string[] name_a = name;
            int[] mark_a = mark;
            int t;      //temperory
            string ts;  //temp string
            char[] tc =new char[name.Length];    //temp char, for sorting by alphabet
            char[] tc2 = new char[name.Length];
            char x;
            for (int i = 0; i < name.Length; i++)
            {
                char[] temp = name[i].ToCharArray();//第i个名字转为字符数组
                tc[i] = temp[0];                    //读取名字首字母放在tc[]中
                tc2[i] = temp[1];
            }
            for(int i=0; i<mark.Length-1; i++) 
            {
                for (int j = i + 1; j < mark.Length; j++) 
                {
                    if (tc[i] > tc[j]) 
                    {
                        x = tc[i];
                        tc[i] = tc[j];
                        tc[j] = x;
                        t = mark_a[i];
                        mark_a[i] = mark_a[j];
                        mark_a[j] = t;//mark follow the first letter of name
                        ts = name_a[i];
                        name_a[i] = name_a[j];
                        name_a[j] = ts;//name follow mark
                    }
                    else if(tc[i] == tc[j])  //to make sure Venkat and Victor are correctly sorted             
                    {
                        tc[i] = tc2[i];
                        tc[j] = tc2[j];
                        if (tc[i] > tc[j])
                        {
                            x = tc[i];
                            tc[i] = tc[j];
                            tc[j] = x;
                            t = mark_a[i];
                            mark_a[i] = mark_a[j];
                            mark_a[j] = t;//mark follow the first letter of name
                            ts = name_a[i];
                            name_a[i] = name_a[j];
                            name_a[j] = ts;//name follow mark
                        }
                    }
                }
            }//bubble sort
            Console.WriteLine("Sort by Alphabet:\nName\tMark");//output sort by mark
            for (int i=0;i<mark.Length;i++)
            {
                Console.WriteLine(name[i] + $"\t{mark[i]}");
            }
        }
    }
}
/*string[] name = new string[]{ "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[] { 63, 29, 75, 82, 55 };
            string[] name_a = name;
            int[] mark_a = mark;
            int t;      //temperory
            string ts;  //temp string
            char[,] tc =new char[5,6];    //temp char, for sorting by alphabet
            char x;
            for (int i = 0; i < name.Length; i++)
            {
                char[] temp = name[i].ToCharArray();//第i个名字转为字符数组
                for (int j = 1; j < temp.Length; j++)
                {
                    tc[i,j] = temp[j];
                }//读取名字首字母放在tc[]中
            }
            for(int i=0; i<mark.Length-1; i++) 
            {
                for (int j = i + 1; j < mark.Length; j++) 
                {
                    while (true)
                    {
                        int k = 1;
                        if (tc[i, k] > tc[j, k])
                        {
                            x = tc[i, k];
                            tc[i, k] = tc[j, k];
                            tc[j, k] = x;
                            t = mark_a[i];
                            mark_a[i] = mark_a[j];
                            mark_a[j] = t;//mark follow the first letter of name
                            ts = name_a[i];
                            name_a[i] = name_a[j];
                            name_a[j] = ts;//name follow mark
                            break;
                        }
                        else if (tc[i, k] == tc[j, k]) 
                        {
                            k++;
                        }
                        else { break; }
                    }
                }
            }//bubble sort
            Console.WriteLine("Sort by Alphabet:\nName\tMark");//output sort by mark
            for (int i=0;i<mark.Length;i++)
            {
                Console.WriteLine(name[i] + $"\t{mark[i]}");
            }
*/
