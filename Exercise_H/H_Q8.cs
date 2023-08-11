using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise
{
    internal class H_Q8
    {
        delegate double DoubleOps(double x);

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            int len = arr.Length;
            double[] result = new double[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = ops(arr[i]);
            }
            return result;
        }

        static double Square (double x)
        {
            return x*x;
        }

        static double SquareRoot (double x)
        {
            return Math.Sqrt (x);
        }

        static void Main(string[] args)
        {
            double[] a = { 1, 2, 3, 4, 5 };
            double[] pow = ProcessArray(a, Square);
            double[] sqrt = ProcessArray(a, SquareRoot);
            Console.WriteLine("arr\tpow\tsqrt");
            for (int i = 0;i < a.Length;i++)
            {
                Console.WriteLine($"{a[i]}\t{pow[i]}\t{sqrt[i]:0.###}");
            }
        }
    }
}
