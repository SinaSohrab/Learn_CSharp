using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 25;
            int number2 = 25;
            number = number + 2;
            //or 
            number2 += 2;
            Console.WriteLine(number);
            Console.WriteLine(number2);
            number = number - 2;
            //or
            number2 -= 2;
            Console.WriteLine(number);
            Console.WriteLine(number2);





            int number3 = 2;
            int number4 = 15;
            int c = number4 / number3;

            int cc = number4 % number3;

            Console.WriteLine(c);
            Console.WriteLine(cc);

            //equal to
            bool check1 = number == number2;
            //unequal
            bool check2 = number != number2;
            //bigger
            bool check3 = number < number2;
            //smaller
            bool check4 = number > number2;
            //bigger equal
            bool check5 = number <= number2;
            //smaller equal
            bool check6 = number >= number2;

            Console.WriteLine(check1);
            Console.WriteLine(check2);
            Console.WriteLine(check3);
            Console.WriteLine(check4);
            Console.WriteLine(check5);
            Console.WriteLine(check6);

            // and &&
            // or ||
            // not !
        }
    }
}
