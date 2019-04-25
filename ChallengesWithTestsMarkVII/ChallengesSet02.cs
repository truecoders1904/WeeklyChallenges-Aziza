using System;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = numbers.Sum();
            return total % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
