using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstmissinginteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 8, 7, 9, 5, 3};
            Solution solution = new Solution();
            int result = solution.FirstMissingPositive(nums);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
