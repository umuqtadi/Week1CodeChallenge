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

            for (int i = 0; i <= 25; i++)
            {
                if (i %2 !=0)
                {
                    if (IsPrime(i) == true)
                    {
                        Console.WriteLine("{0} is a prime number", i);
                    }
                }
            }

            Console.WriteLine(DashInsert(454793));
            Console.WriteLine(DashInsert(8675309));

            Console.ReadKey();
        }

        /// <summary>
        /// Based on what numbers are divisible by determines what will display. %5 = Fizz, %3= buzz, %3 and %5 = FizzBuzz
        /// </summary>
        /// <param name="number">number which you are entering to see its divisibility</param>
        /// <returns></returns>
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

        /// <summary>
        /// Reverses the order of the words in a string
        /// </summary>
        /// <param name="text">string you wish to have words reversed</param>
        /// <returns></returns>
        public static string Yodaizer(string text)
        {
            // taking a string and turning it into an array, splitting up the string by spaces to determine where one word ends and the other starts
            string[] theForce = text.Split(' ');
            Array.Reverse(theForce);
            return string.Join(" ", theForce);
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static string DashInsert(int number)
        {
            //Convert number to string
            string firstOne = number.ToString();

            string second = string.Empty;

            
            foreach (char c in firstOne)
            {
                //Check to see if there is 2 odd numbers in a row
                if (Convert.ToInt32(c) % 2 != 0 && Convert.ToInt32(second[second.Length - 1]) % 2 != 0)
                {
                    second = second + "-" + c;
                }
                else
                {
                    second = second + c;
                }
            }
            return second.ToString();
        }

        /// <summary>
        /// Takes any string you enter and gives out stats about word count, character count, vowel count, spec char count, consonant count
        /// </summary>
        /// <param name="input">the string you wish to receive stats about</param>
        public static void TextStats(string input)
        {
            int charCount = input.Length;
            int vowelCount = 0;
            int consoCount = 0;
            int specCount = 0;
            
            string[] wordArray = input.Split(' ');
            int wordCount = wordArray.Length;

            // going through the string letter by letter and counting up the stats
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "o" || input[i].ToString() == "i" || input[i].ToString() == "u" )
                {
                    vowelCount++;
                }
                    // if it contains any of these add to special character count
                else if (input[i].ToString() == "." || input[i].ToString() == " " || input[i].ToString() == "?" || input[i].ToString() == ",")
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
