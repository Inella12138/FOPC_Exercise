using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class H_Q5
    {
        public static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] newarray = new int[newSize];
            int len;
            if (newSize > arr.Length)
            {
                len = arr.Length;
            }
            else { len  = newSize; }
            for (int i = 0; i < len; i++)
            {
                newarray[i] = arr[i];
            }
            return newarray;
        }
    }
}
