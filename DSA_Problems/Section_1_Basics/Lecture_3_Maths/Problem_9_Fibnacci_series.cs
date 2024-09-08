using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_9_Fibnacci_series
    { 
        public Problem_9_Fibnacci_series()
        {
            solution();
        }

        public void solution()
        {
            int num = 20;
            int a = 0;
            int b = 1;

            Console.Write(a);
            Console.Write(" "+b);
            for (int i = 2; i < num; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
                Console.Write(" " + temp);
            }
            Console.WriteLine();
        }
    }
}

// Time : O(n)
// Space : O(1)