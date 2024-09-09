using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem Level Medium

namespace DSA_Problems.LeetCodeProblems.Maths
{
    class LeetCode_7_ReverseInteger
    {
        public LeetCode_7_ReverseInteger()
        {
            int nom = Reverse(123);
            Console.WriteLine(nom);
        }
        public int Reverse(int x)
        {
            int org = x;
            long rev = 0;
            while (org != 0)
            {
                rev = (rev * 10) + (org % 10);
                org = org / 10;
            }
            if (rev < ((-1) * Math.Pow(2, 31)) || rev > (Math.Pow(2, 31) + 1))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(rev);
            }
        }
    }
}

// Note In This Problem
// -> We Learning Difference Between Int32 and Int64
// -> Size BitWise
//    32 bits
//    64 bits
//
// -> Range of Value 
//    UnSigned(Positive) 
//                       32 bit -> 0 to 2^32 -1
//                       64 bit -> 0 to 2^64 -1
//    Signed(Negative And Positive) 
//                       32 bit -> -2^31 to 2^31 -1
//                       64 bit -> -2^63 to 2^61 -1
//
// -> Memory : 
//              32 Bit -> 1 byte = 8 bits , 4 byte = 32 bits
//              64 bit -> 8 bytes = 64 bits
//              

//------------------------------------------------------------------------------------------------------------------------------------------------------

// -> Handle Situation If the Value Get out of Range.
// -> Here, I Used long Datatype for rev bcoz ,As Per Question The Value can get out Int32 Range for (signed and unsigned)

//------------------------------------------------------------------------------------------------------------------------------------------------------

// -> How to Reverse a Integer
// -> rev = (rev * 10) + (org % 10);
// -> org = org / 10;

//------------------------------------------------------------------------------------------------------------------------------------------------------

// Time : O(No of Digits) / O(log base 10 (N))
// Sapce : O(1)