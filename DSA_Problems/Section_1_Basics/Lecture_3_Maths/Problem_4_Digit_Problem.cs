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
            OptimalWayToCountDigit();
            ProblemGFG();
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

        public void OptimalWayToCountDigit()
        {
            double num = 231233.12312;//Works with int, long


            int count = Convert.ToInt32(Math.Log10(num)) + 1; // O(1)
            Console.WriteLine(count);
        }

        public void ProblemGFG()
        {
            int Num = 205;
            int N = Num;
            int count= 0;
            while (N != 0)
            {
                int rem = N % 10;
                if(rem != 0 && Num % rem == 0)
                {
                    count++;
                }
                N = N / 10;
            }

            Console.WriteLine("Count : " + count);

        }
    }
}

// Space Complexity : O(1)
// Time Complexity :O(logbase10n) or O(d)

// Other Way Of Solving the Count is Converting the number to String and then get the length.
// Let n = no.ToString();
// n.Length;
// Time Compleixty Remain O(d) or O(logbase10n)

// Time Complexity to count the no of Digit is O(1) -- Optimal Solution 
