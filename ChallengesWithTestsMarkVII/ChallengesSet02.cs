using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }


        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {


            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int i;
            int sum = 0;

            if (!(numbers?.Length > 0))
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

            if (!(numbers?.Length > 0))
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

            if (numbers == null)
            {
                return false;
            }

            else
            {
                int total = numbers.Sum();

                if (numbers.Count == 0)
                {
                    return false;
                }
                else if (total % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
           
           

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0 || number == 0)
            {
                return 0;
            }

            else if (number % 2 == 0)
            {
                return number / 2;
            }
            else
            {
                return (number - 1) / 2;
            }

        }
    }
}
