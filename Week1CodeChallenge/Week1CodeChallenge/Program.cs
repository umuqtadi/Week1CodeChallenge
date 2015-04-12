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
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }

            for (int i = 92; i > 78; i--)
            {
                Console.WriteLine(FizzBuzz(i));
            }

            Console.WriteLine(Yodaizer("I like code"));

            TextStats("West philadelphia born and raised, on the playground is where I spent most of my days?");

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
            string[] theForce = text.Split(' ');
            Array.Reverse(theForce);
            return string.Join(" ", theForce);
        }

        public static bool IsPrime(int number)
        {
            int primeCount = 0;

            return true;
        }
        public static string DashInsert(int number)
        {
            return string.Empty;
        }

        public static void TextStats(string input)
        {
            int charCount = input.Length;
            int vowelCount = 0;
            int consoCount = 0;
            int specCount = 0;
            
            string[] wordArray = input.Split(' ');
            int wordCount = wordArray.Length;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "o" || input[i].ToString() == "i" || input[i].ToString() == "u" )
                {
                    vowelCount++;
                }
                else if (input[i].ToString() == "." || input[i].ToString() == " " || input[i].ToString() == "?")
                {
                    specCount++;
                }
                else
                {
                    consoCount++;
                }
            }
            Console.WriteLine("Number of characters: " + charCount);
            Console.WriteLine("Number of words: " + wordCount);
            Console.WriteLine("Number of vowels: "+ vowelCount);
            Console.WriteLine("Number of consonants: "+ consoCount);
            Console.WriteLine("Number of special characters: "+ specCount);
        }

    }
}
