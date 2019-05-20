using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int divisor = startNumber / n;
            if (n >= startNumber)
            {
                return n;
            }
            else
            {
                return n * (divisor + 1);
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business broke in businesses)
            {
                if (broke.TotalRevenue <= 0)
                {
                    broke.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sumOfNumbers = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sumOfNumbers += numbers[i];
                }
            }
            return sumOfNumbers;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string newSentence = "";
            int i = 0;

            for (i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == " ")
                {
                    newSentence += "";
                }

                else
                {
                    newSentence += words[i] + " ";
                }

            }

            newSentence += words[words.Length - 1];
            newSentence = newSentence.Trim();

            if (newSentence.Length == 0)
            {
                return "";
            }
            else
            {
                newSentence += ".";
            }

            return Regex.Replace(newSentence, @"\s+", " ");
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> listOfFourths = new List<double>();

            if(listOfFourths == null )
            {
                return null;
            }

            for (int i = 3; i < elements.Count; i += 4)
            {

                listOfFourths.Add(elements[i]);

            }
            double[] arrayOfFourths = listOfFourths.ToArray();
            return arrayOfFourths;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return (nums[i] + nums[j] == targetNumber);
                    }

                }
            }
            return false;
        }
    }
}
