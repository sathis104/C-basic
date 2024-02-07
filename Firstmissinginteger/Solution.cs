using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstmissinginteger
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            var positiveNumbers = nums.Where(x => x > 0).Distinct().ToArray();

            Array.Sort(positiveNumbers);

            int result = 1;

            for (int i = 0; i < positiveNumbers.Length; i++)
            {
                if (positiveNumbers[i] != result)
                {
                    return result;
                }
                result++;
            }

            return result;
        }
    }

}
