using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            char ch1 = 'c';
            bool answer = char.IsLetter(ch1);
            return answer;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int i;
            int count = 0;

            for(i =0; i < 0; i++)
            {
                int x = i - '0';

                if (x % 2 == 0)
                {
                    count += (i + 1);
                }

            }
            return true;

          

        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }


        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double number = new double();

            double result = number.MaxValue();
            double nxtresult = number.MinValue();

            return result + nxtresult;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            string[] words = { };
            int shortestWord = words.Min(w => w.Length);
            return shortestWord;
        }

        public int Sum(int[] numbers)
        {
            int i;
            int sum = 0;

            if (numbers.Length == 0)
            {
                return 0;
            }

            else

               for (i = 0; i < numbers.Length; i++)
                {

                    {
                        sum += numbers[i];
                    }
                }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int i;
            int sum = 0;

            if (numbers.Length == 0)
            {
                return 0;
            }

            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    sum += 0;
                }
            }

            return sum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = numbers.Sum();
            return total % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long num = new long();

            if(num % 2 == 0)
            {
                return num;
            }

            else
            {
                return num + 1;
            }

        }
    }
}
