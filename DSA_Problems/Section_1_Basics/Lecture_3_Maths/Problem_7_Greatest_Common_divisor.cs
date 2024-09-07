using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_7_Greatest_Common_divisor
    {
        public Problem_7_Greatest_Common_divisor()
        {
            Solution1();
        }

        public void Solution1()
        {
            int num1 = 12;
            int num2 = 18;
            int num3 = 48;

            int result = 0;

            int min = (num1 < num2 ? (num1 < num3 ? num1 : num3) : (num2 < num3 ? num2 : num3));

            for (int i =2;i<=min; i++) // O(min(n1,n2,n3))
            {
                if (num1 % i == 0 && num2 % i == 0 && num3 % i == 0)
                {
                    result = i;
                }
            }
            Console.WriteLine(result);
        }
    }
}


// Time Compleixty O(min(n1,n2,n3))
// Space Complexity : O(1)