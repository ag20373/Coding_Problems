using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Maths.Easy_Level
{
    class LeetCode_66_Plus_One
    {
        public LeetCode_66_Plus_One()
        {
            solution();
        }

        public void solution()
        {
            int[] arr = new int[]
            {
                9,8,4,4,5,9,9
            };

            bool falg = false;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 9)
                {
                    arr[i] = 0;
                }
                else
                {
                    arr[i] += 1;
                    falg = true;
                    break;
                }
            }
            if (falg == true)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                return;
            }
            else
            {
                int[] arr2 = new int[arr.Length + 1];
                arr2[0] = 1;
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]);
                }
                return;
            }



        }
    }
}

// Logic 
// IF LAst Number other then One Increment and Return the arr 
// If Last Number 9 , make it zero till we get number < 9 , Increment that number by 1 and return arr.
// IF all Number are 9 , then create a new array with size (org array +1) , add 1 to top and return new array

// Time compleixty  : O(n) MAx iteraton can run till n number.
// Space Complexity : O(n) Size +1 the original array.