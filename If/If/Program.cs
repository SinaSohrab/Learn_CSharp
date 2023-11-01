using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert your number: ");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            if (age % 2 == 0)
            {
                Console.WriteLine("zoje");
            }
            else
            {
                Console.WriteLine("fard");
            }
        }
    }
}
