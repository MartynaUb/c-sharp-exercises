using System;
using System.Linq;

namespace csharpExercises.StringManipulation
{
    public class StringTasks
    {
        public static string CompressString(string word)
        {
            {
                int count = 0;
                char currentChar = word[0];
                string newStr = string.Empty;

                foreach (char s in word)
                {
                    if (s == currentChar)
                    {
                        count++;
                    }
                    else
                    {
                        newStr += currentChar.ToString() + count;
                        currentChar = s;
                        count = 1;
                    }
                }

                newStr += currentChar.ToString() + count;

                return newStr;
            }
        }

        public static string FizzBuzz(int lastInteger)
        {
            return Enumerable.Range(1, lastInteger)
                .Select(FizzBuzzHelper)
                .Aggregate("", (acc, curr) => acc + curr + "\n");
        }

        private static string FizzBuzzHelper(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            return number % 5 == 0 ? "Buzz" : number.ToString();
        }

        public static string RevertWordOrder(string word)
        {
            string[] words = word.Split(' ');
            int numOfWords = words.Length;
            int num = numOfWords;

            for (int i = 0; i < numOfWords / 2; i++)
            {
                num--;
                string temp = words[num];
                words[num] = words[i];
                words[i] = temp;
            }

            return string.Join(" ", words);
        }
    }
}