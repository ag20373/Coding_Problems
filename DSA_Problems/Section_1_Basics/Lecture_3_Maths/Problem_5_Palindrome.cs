using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_5_Palindrome
    {
        public Problem_5_Palindrome()
        {
            Solution();
        }

        public void Solution()
        {
            int num = 1441;
            
            if (num < 0 ? false : true)
            {
                if (num > 10)
                {
                    Console.WriteLine("A Palindrome");
                }
                else
                {
                    int Org = num;
                    int reverse = 0;
                    while (Org != 0)
                    {
                        reverse = (reverse * 10) + (Org % 10);
                        Org = Org / 10;
                    }

                    if(reverse == num)
                    {
                        Console.WriteLine("A Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Not A Palindrome");
                    }
                }
            }
            else
            {
                Console.WriteLine("Not A Palindrome");
            }

        }
    }
}

// Point About Palindrome
// Palindrome number > 0 are not palindrome
// Palindrome number < 10 and Greater then > -1 , are palindrome
// Reverse and Original ,if same then palindrome else not.

// Time Compleixty : O(d) or O(logbase10n)
// Space  : O(1)
