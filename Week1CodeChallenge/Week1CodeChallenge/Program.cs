using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }

            for (int i = 92; i > 79; i--)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.ReadKey();
        }


        public static string FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            if (number%5 == 0)
            {
                return "Fizz";
            }
            if (number%3 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
        public static string Yodaizer(string text)
        {
            return string.Empty;
        }
        public static bool IsPrime(int number)
        {
            return true;
        }
        public static string DashInsert(int number)
        {
            return string.Empty;
        }
    }
}
