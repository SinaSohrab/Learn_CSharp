using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert your number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);

            //==============================
            // or

            int sum2 = 0;

            for (int i = 2; i <= number; i += 2)
            {
                sum2 += i;
            }
            Console.WriteLine(sum2);

            // fibonacci number
            int first = 1;
            int second = 1;
            int sum3 = 0;
            for (int i = 0; i < number; i++)
            {
                sum3 = first + second;
                first = second;
                second = sum3;
            }
            Console.WriteLine(sum3);
        }
    }
}
