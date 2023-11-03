using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            for (int i = 0; i <= 5; i++)
            {
                number.Add(i);
            }
            number.Insert(2, 50);
            number.RemoveAt(4);
            number.Remove(5);

            bool check = number.Contains(50);
            int count = number.Count;
            int idx = number.IndexOf(50);
            number[0] = 11;
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(check);
            Console.WriteLine(count);
            Console.WriteLine(idx);
        }
    }
}
