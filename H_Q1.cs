using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class H_Q1
    {
        public static int ReadInteger(string message)
        {
            bool flag = false;
            int output;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                flag = Int32.TryParse(input, out output);
                if (!flag)
                {
                    Console.WriteLine("Not an integer, please check your input!");
                }
                else
                {
                    break;
                }
            }while (!flag);
            return output;
        }

        static void Main()
        {
            int x1 = ReadInteger("Please enter x1: ");
            Console.WriteLine(x1);
            int x2 = ReadInteger("Please enter x2: ");
            Console.WriteLine(x2);
        }
    }
}
