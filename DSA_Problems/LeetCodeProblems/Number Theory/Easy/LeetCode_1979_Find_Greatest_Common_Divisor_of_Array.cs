using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Number_Theory.Easy
{
    class LeetCode_1979_Find_Greatest_Common_Divisor_of_Array
    {
        public LeetCode_1979_Find_Greatest_Common_Divisor_of_Array()
        {
            Solution();
        }
        public void Solution()
        {
            int[] arr = new int[]
            {
                3
            };

            if (arr.Length < 2 && arr.Length <1000) return;

            int Smallest = arr.Min(); // O(n)
            int Lastest = arr.Max(); // O(n)

            int x = gcd(Smallest, Lastest);
            Console.WriteLine(x);

        }

        // Time Compleixty : O(log(min(num1, num2))) 
        // Space Compleixty : O(1)
        public int gcd(int a , int b)
        {
            if (b == 0) return a;
            else
            {
                return gcd(b, a % b);
            }
        }
    }
}


// GCD 

// Optimal Solutions

// Solution 1 : EuclideanAlgorithm 1
// gcd(a,b) = gcd(b, a-b);
// considering b > a , here....
// Time Complxity Become O(log(min(Given Numbers)))
// This is because in each time the number is getting reduced significantly..
// The significane Reduce size is no of digits in min  number.

// Solution 2 : EuclideanAlgorithm 2
// gcd(a,b) = gcd(b,a%b)
// if (b == 0) return a;
// Time Complexity : O(log(min(Given Numbers)))
