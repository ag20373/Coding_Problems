using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Maths.Medium_Level
{
    class LeetCode_172_Factorial_Trailing_Zeroes
    {
        public LeetCode_172_Factorial_Trailing_Zeroes()
        {
            int n = 10;
            BruteForceSolution(n);
        }

        public void BruteForceSolution(int n)
        {
            long sum = 13;
            for(int i =1;i<=n; i++)
            {
                sum *= i;
            }

            int taliingzero = 0;
            while(sum % 10 == 0)
            {
                sum = sum / 10;
                taliingzero++;
            }
            Console.WriteLine(taliingzero);
        }

    }
}

// Solve the Problem In Logrithm 
