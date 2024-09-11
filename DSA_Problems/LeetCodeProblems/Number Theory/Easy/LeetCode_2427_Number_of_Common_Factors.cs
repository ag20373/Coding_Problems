using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Number_Theory.Easy
{
    class LeetCode_2427_Number_of_Common_Factors
    {
        public LeetCode_2427_Number_of_Common_Factors()
        {
            solution();
        }

        public void solution()
        {
            int a = 850;//25;//32; //12
            int b = 442;//30;//408; // 6

            int min = a > b ? b : a;
            int max = a < b ? b : a;

            for (int i = 1; i*i <= min; i++)
            {
                if(a % i == 0 && b% i == 0)
                {
                    Console.WriteLine(i);
                    
                }
                if (i != min / i)
                {
                    if ((a % (min / i)) == 0 && (b % (min / i)) == 0)
                        Console.WriteLine(min / i);
                }
            }
        }
    }
}

// Time Complexity: O(sqrt(min(a, b)))
// Space Complexity: O(1)

// In this problem, the loop only needs to run up to the smaller of the two values, a and b, 
// because a number greater than min(a, b) cannot be a common divisor of both numbers.
// By utilizing the square root optimization, we can further reduce the time complexity, 
// as divisors always come in pairs (i.e., if x is a divisor, then min(a, b) / x is also a divisor). 
// This allows us to find all divisors by checking only up to the square root of the smaller value.
