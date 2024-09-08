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
            BruteForce();
            EuclideanAlgorithm_Iterative();
            int result = EuclideanAlgorithm_Recursive(35,25 );
            Console.WriteLine(result);

            int result1= OptiomalSolution3(12, 18);
            Console.WriteLine(result1);
        }

        public void BruteForce()
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
        // Time Compleixty - O(min(num1,num2,num3))
        // Space Complexity - O(1)

        public void EuclideanAlgorithm_Iterative()
        {
            int num1 = 35;
            int num2 = 25;
            //int num3 = 48;

            int min = Math.Min(num1, num2);
            int Endloop = Math.Max(num1,num2);
            int Rem = Endloop;
            while (Rem != 0)
            {
                int temp = min;
                Endloop = Endloop % min;
                if (Endloop != 0)
                {
                    Rem = Endloop;
                }
                else
                {
                    break;
                }
                min = Endloop;
                Endloop = temp;
            }

            Console.WriteLine(min);
        }
        // Time Compleixty : O(log(min(num1, num2))) 
        // Space Compleixty : O(1)

        public int EuclideanAlgorithm_Recursive(int a , int b)
        {
            if (a == b) return a;
            else
            {
                int min = Math.Min(a, b);
                int max = Math.Max(a, b);
                return EuclideanAlgorithm_Recursive(min ,max-min);
            }
        }

        // Time Compleixty : O(log(min(num1, num2))) 
        // Space Compleixty : O(1)
        public static int OptiomalSolution3(int a, int b)
        {
            if(b==0)return a;
            else
            {
                return OptiomalSolution3(b, a % b);
            }
        }

        //Time Complexity : O(log(min(num1, num2, num3))) 
        public int OptiomalSolution(int a,int b,int c)
        {
            return OptiomalSolution3((OptiomalSolution3(b, a % b)), c);
        }
    }
}


// What is GCD ?
// GCD Stands for Greatest Common Divisor 
//-----------------------------------------------------------
// exa : Two No a , b
// Both get divided by 1,4,6,8,9
// here greatest one is 9 , so 9 become GCD..
//-----------------------------------------------------------
// Consider If we have a numbers like 12 , 58 , 200
// then we have to run the loop till 1 to 12 only..
// Because a number > then 12 cannot be a divisior of 12
// That is why In Brute Solution the Time Compleixty become O(min(given Numbers))
//----------------------------------------------------------
// Optimal Solutions

// Solution 1 : EuclideanAlgorithm 1
// gcd(a,b) = gcd(b, a-b);
// considering b > a , here....
// Time Complxity Become O(log(min(Given Numbers)))
// This is because in each time the number is getting reduced significantly..
// The significane Reduce size is no of digits in min  number.

// Solution 2 : EuclideanAlgorithm 2
// gcd(a,b) = gcd(b,a%b)
// if (b == 0) return a;
// Time Complexity : O(log(min(Given Numbers)))
//-----------------------------------------------------------
// Conidered i have three numbers 
// In that can i can fidn the
// EuclideanAlgorithmof(EuclideanAlgorithmof (first , 2nd), third)
// Time Will Be Order(log min(a,b,c))

