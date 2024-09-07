using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_4_Digit_Problem
    {
        public Problem_4_Digit_Problem()
        {
            DigitPRoblem();
        }

        public void DigitPRoblem()
        {
            int no = 12345;

            int CountOfDigits = 0;
            int LastDigit = no%10 ;//Get Us Last Digit
            int SumOfDigit = 0;

            while (no != 0)
            {
                CountOfDigits++;//Gets Count Till iteration Ends            
                SumOfDigit = SumOfDigit + (no % 10); //Reducting number by base 10
                no = no / 10;//Remove Last digit.
            }

            Console.WriteLine("Sum Of Digits : " + SumOfDigit);//15
            Console.WriteLine("Last Digit : " + LastDigit);//5
            Console.WriteLine("Count Of digits : " + CountOfDigits);//5

        }
    }
}

// Space Complexity : O(1)
// Time Complexity :O(logbase10n)
