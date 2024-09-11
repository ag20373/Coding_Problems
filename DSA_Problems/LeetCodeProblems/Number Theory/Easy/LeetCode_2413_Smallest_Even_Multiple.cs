using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Number_Theory.Easy
{
    class LeetCode_2413_Smallest_Even_Multiple
    {
        public LeetCode_2413_Smallest_Even_Multiple()
        {
            Solution();
        }

        public void Solution()
        {
            int n = 5;

            if(n%2 == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n*2);
            }
        }
    }
}

// Time Complexity : O(1)
// Spce Complexiity :O(1)

// smallest number whose divisor is  2 and n
// In case of even 'n' itself
// In case of Odd 'n*2' .
