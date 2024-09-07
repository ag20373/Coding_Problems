using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_3_Maximum_Of_TwoAndThree_Number
    {
        public Problem_3_Maximum_Of_TwoAndThree_Number()
        {
            Max3();
            Max2();
        }

        public void Max2()
        {
            int a = 100;
            int b = 235;

            int result = a > b ? a : b;
            Console.WriteLine("MAximumn Of Two is  : "+ result);
            
        }
        public void Max3()
        {
            int a = 100;
            int b = 188;
            int c = 20;

            int result = (a > b ? (a >c?a:c) : (b > c ? b : c));
            Console.WriteLine("MAximumn Of Three is  : " + result);
        }
    }
}

// Time Complexity : O(1) ,space Complexity :O(1)
