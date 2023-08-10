using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercise_G
{
    internal class G_Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter students' scores" +
                "(seperate each subject by space, and seperate each student by enter, " +
                "press enter when you finish): ");
            int stu = 0;
            while (true)
            {
                string stringInput = Console.ReadLine();
                if (stringInput == null) { break; }
                stu++;

                char blk = ' ';
                string[] user = stringInput.Split(blk);
                int[] num = new int[user.Length];

                for (int i = 0; i < user.Length; i++)
                {
                    num[i] = int.Parse(user[i]);
                }
            
            }
        }
    }
}
