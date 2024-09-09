using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_12_Prime_Or_Not
    {
        public Problem_12_Prime_Or_Not()
        {
            int num = 25;
            BruteForceSolution(num);
            OptimalSolution(num);
        }
        public void BruteForceSolution(int n)
        {
            int num = n;
            int flag = 0;
            for(int i = 2; i <= num / 2; i++) // --O(n/2) --> O(n)
            {
                if(num % i == 0)
                {
                    flag++;
                    break;
                }
            }

            if(flag > 0)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }

        public void OptimalSolution(int n) // O(root(n))
        {
            int num = n;
            int count = 0; 
            for (int i = 2; i <= Math.Sqrt(num); i++)  // -- can oslo write this as i <= n/i
            {
                if(num %i == 0)
                {
                    count++;
                    break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }


}

// Space Compleiity : O(1)
// Time Complexity : O(Root(n)) Same Logic as Factors
