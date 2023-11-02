using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] even_numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                even_numbers[i] = i * 2;
            }

            for (int i = even_numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(even_numbers[i]);
            }

            //============================


            Console.WriteLine("enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int first = 1;
            int second = 2;
            int sum = 0;
            int[] is_iven = new int[number];
            for (int i = 0; i < number; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
                is_iven[i] = sum;
            }
            Console.WriteLine(sum);
            for (int i = is_iven.Length - 1; i < number; i--)
            {
                Console.WriteLine(is_iven[i]);
            }
        }
    }
}
