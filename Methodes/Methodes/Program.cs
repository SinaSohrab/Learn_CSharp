using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    internal class Program
    {
        public static double calculate_average(List<int> user_ranks)
        {
            double sum = 0;
            for (int i = 0; i < user_ranks.Count; i++)
            {
                sum += user_ranks[i];
            }
            double average = sum / user_ranks.Count;
            return average;

        }
        static void Main(string[] args)
        {
            string[] games = new string[3] { "red dead", "dota2", "gta" };
            List<int> ranks = new List<int>();
            for (int i = 0; i < games.Length; i++)
            {
                Console.WriteLine("pleas insert your rank for the game " + games[i] + ":");
                int rank = Convert.ToInt32(Console.ReadLine());
                ranks.Add(rank);
            }
            double average = calculate_average(ranks);
            Console.WriteLine("avrage rank is: " + average);
        }
    }
}
