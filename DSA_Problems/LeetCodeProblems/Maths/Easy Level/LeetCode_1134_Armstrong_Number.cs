using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Maths
{
    class LeetCode_1134_Armstrong_Number
    {
        public LeetCode_1134_Armstrong_Number()
        {
            Solution();
        }

        public void Solution()
        {
            int no = 153;// 1634//
            int org = no;
            int Dgits = (int)(Math.Log10(no) + 1);
            int sum = 0;
            while (no != 0)
            {
                sum += (int)Math.Pow(no % 10,Dgits);
                no = no / 10;
            }

            if(sum == org)
            {
                Console.WriteLine("ArmStrong Number");
                
            }
            else
            {
                Console.WriteLine("Not ArmStrong Number");
            }

        }
    }
}
