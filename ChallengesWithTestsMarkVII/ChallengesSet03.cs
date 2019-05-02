using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
                if(vals[i] == false)
                {
                    return true;
                }
            return false;  
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }

            int startingPoint = 0;

            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    startingPoint++;
                }

            }
            return (startingPoint % 2 != 0);
        }    

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0]; ;
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddsValues = new int[50];
            int odds = 1;

            for (int i = 0; i < 50; i++)

            {
                if (odds % 2 != 0)
                {
                    oddsValues[i] = odds;
                    odds += 2;
                }

            }
            return oddsValues;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
