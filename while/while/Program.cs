using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stars: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            while (x < number)
            {
                Console.Write("*");
                x++;
            }

            //=============================================================


            int game = 0;
            do
            {
                Console.WriteLine("\n input your number for game: ");
                game = Convert.ToInt32(Console.ReadLine());
                if (game == 1)
                {
                    Console.WriteLine("game one");
                }
                if (game == 2)
                {
                    Console.WriteLine("game tow");
                }
            }
            while (game != 0);

            //=========================

            int game2 = 0;
            while (game2 == 0)
            {
                Console.WriteLine("\n input your number for game: ");
                game2 = Convert.ToInt32(Console.ReadLine());
                if (game2 == 1)
                {
                    Console.WriteLine("game one");
                }
                if (game2 == 2)
                {
                    Console.WriteLine("game tow");
                }
            }

        }
    }
}
