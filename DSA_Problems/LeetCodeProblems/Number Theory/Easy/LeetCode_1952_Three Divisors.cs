using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Number_Theory.Easy
{
    class LeetCode_1952_Three_Divisors
    {
        public LeetCode_1952_Three_Divisors()
        {
            Solution();
            
        }

        // using List and Get count 
        // O(SqrtRoot(n)) Space and Time
        public void Solution()
        {
            int n = 4;
            List<int> arr = new List<int>();
            for(int i = 1; i <= n/i; i++)
            {
                if(n%i == 0)
                {
                    arr.Add(i);
                    if (i != n / i)
                    {
                        arr.Add(n / i);
                        
                    }
                }
            }

            if(arr.Count > 2)
            {
                Console.WriteLine( true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        // Using PErfect Square and Prime Logic 
        // O(sqrtRoot(n)) Space and Time
        public void Optimalsolution()
        {
            int n = 9;
            for(int i = 2; i * i < n; i++)
            {
                if (i * i == n)
                {
                    bool val = checkedForPRime(i);
                    Console.WriteLine(val);
                }
            }

            Console.WriteLine(false); ;
        }

        private bool checkedForPRime(int n)
        {
            for(int i = 1; i*i <= n; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

// Problem : Find No with excatly three Divisor.
// Eg :- 1,2,4 for 4.

// A number Has Excatly has three Divisor, Only if it is a perfect square and Square number is Prime.
// Eg :- 4 :- 2 * 2 , and 2 is Prime .... 1, 2 , 4 
// Eg :- 16 :- 4 * 4 , but 4 is not prime .... 1 ,2 , 4 , 8
// 

// Approach One To Solve 
// Add all the Divisor in a List And get The Count ....
// Time complexity : O(SqrtRoot(n))
// Space Compexity : O(sqrtRoot(n)) For Worst Case It get Store all the DiVisor in a Memeory , when the value is close.

// Optimal Solution : Prefect Square and Square number is Prime 
// check is the  n is Perfect Square i * i = n ,if true,  then check i is Prime 
// Time Compleoxity : O(SqrtRoot(n))
// Space Compleixty : O(1)....
