using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_8_LCM_OF_Two_Number
    {

        
        public Problem_8_LCM_OF_Two_Number()
        {
            int result = LCM(12,14);
            Console.WriteLine(result);
        }

        public int LCM(int a,int b)
        {
            //This statement Will Only take O(1) time
            // GCD Will Take O(logmin(a,b))
            return (a * b) / Problem_7_Greatest_Common_divisor.OptiomalSolution3(a, b); 

        }
    }
}


//space complexity  : O(1) 