using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_10_ArmStrong_Number
    {
        public Problem_10_ArmStrong_Number()
        {
            int num = 0; //Store the Sum
            int numeber = 1634;
            int result = solution((numeber.ToString()).Length,num,numeber); 
            Console.WriteLine(result);
            SolutionIterative(numeber);
        }

        public int solution(int count,int num,int n)
        {
            num += Convert.ToInt32(Math.Pow((n % 10),count));
            if (n == 0) return num;
            else 
            {
                return solution(count,num,n / 10);
            }
            
        }

        //Time Complexity  : O(logbase10 (n)) or O(d) --- Number is decreasing by 10 on each iteration
        // Space Complexity : O(logbase10 (n)) or O(d) ---  Stack is formed number of Digits 'time...


        public void SolutionIterative(int num2)
        {
            int num = num2;
            int count = (num.ToString()).Length;
            int sum = 0;
            while (num != 0)
            {
                sum += Convert.ToInt32(Math.Pow((num % 10), count));
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
        //Time Complexity  : O(logbase10 (n)) or O(d) --- Including Calcuation of count 
        // Space Complexity : O(1) --- No space Required

    }
}
