using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class F_Q6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a matriculation number: ");
            string user = Console.ReadLine();
            bool flag = true;//to tell output in an easier way
            
            if (user.Length != 7) { flag = false; }
            while (flag) //when user.Length != 7, no need to check
            {
                user = user.ToUpper();
                string num = user.Substring(1, 5);
                string checksum = user.Substring(6, 1);
                int sum = 0;
                int remainder;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum + (6 - i) * int.Parse(num.Substring(i, 1));
                }
                remainder = sum % 5;
                switch (remainder)
                {
                    case 0:
                        if (checksum == "O") { break; }
                        else { flag = false; break; }
                    case 1:
                        if (checksum == "P") { break; }
                        else { flag = false; break; }
                    case 2:
                        if (checksum == "Q") { break; }
                        else { flag = false; break; }
                    case 3:
                        if (checksum == "R") { break; }
                        else { flag = false; break; }
                    case 4:
                        if (checksum == "S") { break; }
                        else { flag = false; break; }
                }
                break;
            }
            if (flag) { Console.WriteLine("Valid"); }
            else{ Console.WriteLine("Invalid"); }
        }
    }
}
