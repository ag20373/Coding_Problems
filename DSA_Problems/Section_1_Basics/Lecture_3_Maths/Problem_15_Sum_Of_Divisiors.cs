using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths.Notes
{
    class Problem_15_Sum_Of_Divisiors
    {
        public Problem_15_Sum_Of_Divisiors()
        {
            int n = 5;
            BruteForceSolution(n);
            OptimalSolution(n);
            HarmonicLemma(n);
        }

        public void BruteForceSolution(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++) // run this loop for each numnber till n
            {
                for (int j = 1; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        // Avoid counting sqrt(i) twice.
                        if (i / j == j)
                        {
                            sum += j;
                        }
                        else
                        {
                            sum += j + i / j;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }

        public void OptimalSolution(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += (n / i) * i;
            }

            Console.WriteLine(sum);
        }

        public void HarmonicLemma(int n)
        {
            int ans = 0;
            int l = 1;

            // Iterating over all values of 'l' such that 'n/l' is distinct.
            // There at most 2*sqrt(n) such values.
            while (l <= n)
            {
                int val = n / l;

                // 'r' = maximum value of 'i' such that 'n/i' is val.
                int r = n / val;

                ans += ((r * (r + 1)) / 2 - (l * (l - 1)) / 2) * val;

                // moving on to next range.
                l = r + 1;
            }

            Console.WriteLine (ans);
        }
    }
}
