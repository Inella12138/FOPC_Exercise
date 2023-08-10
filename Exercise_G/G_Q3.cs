using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class G_Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter students' scores(12 students and 4 subjects): ");

            int[,] mark = new int[12, 4];

            for (int i = 0; i < 12; i++)
            {
                string stringInput = Console.ReadLine();
                string[] user = stringInput.Split(' ');

                for (int j = 0; j < user.Length; j++)
                {
                    mark[i, j] = int.Parse(user[j]);
                }
            }

            int[] total = new int[mark.GetLength(0)];
            double[] avgStu = new double[mark.GetLength(0)];
            for (int i = 0; i < mark.GetLength(0); i++)
            {
                for (int j = 0; j < mark.GetLength(1); j++)
                {
                    total[i] += mark[i, j];
                }
                avgStu[i] = total[i] / 4;
            }

            double[] avgSbj = new double[mark.GetLength(1)];
            for (int j = 0; j < mark.GetLength(1); j++)
            {
                for (int i = 0; i < mark.GetLength(0); i++)
                {
                    avgSbj[j] += mark[i, j];
                }
                avgSbj[j] = avgSbj[j] / 12;
            }

            Console.WriteLine("Subject 1\tSubject 2\tSubject 3\tSubject 4\tTotal\tAvg\t");
            for (int i = 0; i < mark.GetLength(0); i++)
            {
                for (int j = 0; j < mark.GetLength(1); j++)
                {
                    Console.Write($"{mark[i, j]}\t\t");
                }
                Console.WriteLine($"{total[i]}\t{avgStu[i]}");
            }
            Console.WriteLine("Average per subject");
            for (int j = 0; j < mark.GetLength(1); j++)
            {
                Console.Write($"{avgSbj[j]}\t");
            }
            Console.WriteLine();
        }
    }
}
