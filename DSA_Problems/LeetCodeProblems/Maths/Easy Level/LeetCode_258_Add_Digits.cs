using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Maths.Easy
{
    class LeetCode_258_Add_Digits
    {
        public LeetCode_258_Add_Digits()
        {

            Solution();
        }

        public void Solution() // O(1) Time
        {
            int num = 38;
            int result = 0;
            if (num == 0)
            {
                result = 0;
            }
            else if (num % 9 == 0)
            {
                result = 9;
            }
            else
            {
                result = num % 9;
            }

            Console.WriteLine(result);
        }
    }
}

// Topic To Learn

// Divisiblity Rule OF Nine
// Any Number Divide By 9 Give us a Result in Single Digit.
// Eg :- 12 % 9 = 3 , 24 % 9 = 6 , 28 % 9 = 1  
// If Num % 9 == 0 , then Result should be  9.
