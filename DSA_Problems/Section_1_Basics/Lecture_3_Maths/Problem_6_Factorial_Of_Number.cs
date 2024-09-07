using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_6_Factorial_Of_Number
    {
        public Problem_6_Factorial_Of_Number()
        {
            solution();
        }
        
        public void solution()
        {
            int no = 22;
            long factorial = 1;
            for(int i = 1; i <= no; i++) //---O(n) Times
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
