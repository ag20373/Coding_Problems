using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_14_Reverse_A_Digit
    {
        public Problem_14_Reverse_A_Digit()
        {
            int num = 104020000;
            Solution(num);
        }

        public void Solution(int num)
        {
            int rev = 0;
            bool checkforZero = true;

            while (num != 0) // -- O(d) or  O(log base 10 (num))
            {
                //if (checkforZero && num % 10 == 0)
                //{
                //    num = num / 10;
                //    continue;
                //}
                //else
                //{
                //    checkforZero = false;
                //}
                rev = (rev * 10) + (num % 10);
                num = num / 10;
            }

            Console.WriteLine(rev);
        }
        // Note : If Input is Like 430900 , then output should be 9034
        // O(d) or  O(log base 10 (num)) Time , Space  O(1)
    }
}
