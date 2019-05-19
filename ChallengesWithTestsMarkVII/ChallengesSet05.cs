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
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
