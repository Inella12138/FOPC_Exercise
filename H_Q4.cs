using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class H_Q4
    {
        public static void SetArray(int[] arr, int value)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                arr[i] = value;
            }
        }
    }
}
