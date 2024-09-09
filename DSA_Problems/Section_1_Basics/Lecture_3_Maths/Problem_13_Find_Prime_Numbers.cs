using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_13_Find_Prime_Numbers
    {
        public Problem_13_Find_Prime_Numbers()
        {
            int num = 40;
            BruteForce(num);
        }

        public void BruteForce(int  n)
        {
            for(int i = 2; i <= n; i++) // O(n*root(n) )
            {
                bool flag = false; 
                for(int j =2;j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                    
                }
                if (flag == false)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}


//This Solution Solve the Problem in O(n*root(n))