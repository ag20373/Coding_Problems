using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_11_Factor_Of_number
    {
        public Problem_11_Factor_Of_number()
        {
            Recursion(20,1);
            Optimal();
        }

        public void Recursion(int originalnum,int num)
        {
            if(num > (originalnum/2))
            {
                return;
            }
            else
            {
                if(originalnum % num == 0)
                {
                    Console.WriteLine(num);
                }
                
                Recursion(originalnum, ++num);
                
                
            }
        } // O(n) Time

        public void Optimal () // O(root(n)) Time
        {
            Console.WriteLine("Optimal");
            int num = 20;
            for(int i = 1; i < num / i; i++)
            {
                if((num%i) == 0)
                {
                    Console.WriteLine(i);
                    if(i != num / i)
                    {
                        Console.WriteLine(num/i);
                    }
                }
            }
        }
    }
}

//Why To Choose Iteration Over Recursion here,
// 1. Stack OverFlow Problme ... we need O(n) Stack To solve this solution.
// 2. Repetative Code ... More efficient in term of iteration , laso interm of space. 

// Bruteforce Approach 
// Take O(n/2) timecompleixty , which can written as O(n)
// We are running loop till half.

// Optimal Approach 
// Here we know if  i is Divisior of Num , then Num /i Also be devisior Of number
// we can write this as i <= n/i 
// i^2 <= n 
// i <= Root(n)
// time Complexity Become  O(root n)

// Space Compleixtty Become O(1)
