using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Maths.Medium_Level
{
    // Problem Level Easy
    //Follow up: Could you solve it without converting the integer to a string?
    class LeetCode_9_Plaindrome
    {
        public LeetCode_9_Plaindrome()
        {
            bool result = Solution(121);
            Console.WriteLine(result);
        }
        

        public bool Solution(int n)
        {
            if (n < 0)
            {
                return false;
            }
            else if (n < 10)
            {
                return true;
            }
            else
            {
                int rev = 0;
                int org = n;
                while (n != 0)
                {
                    rev = (rev * 10) + (n % 10);
                    n = n / 10;
                }

                if(rev == org)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            
        }
    }

    
}

// Comcept To LEarn :
// -ve Numbers cannot be plaindrome 
// Single Digits are always palindrome.

//-----------------------------------------------------------------------------------------------------------------------------------

// Complexity
//Time complexity:
//Best Case : O(1) , Worst Case : O(log base 10 N)
//Space complexity:
//O(1)
