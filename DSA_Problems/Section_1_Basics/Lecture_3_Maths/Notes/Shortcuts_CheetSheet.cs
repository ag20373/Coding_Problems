using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths.Notes
{
    class Shortcuts_CheetSheet
    {
        #region Related To Number Theory
        // Related To Numbers Eg :- 12452

        // 1. We Can found Count Of a Number  O(1) using Math.Log10(n) + 1;
        // 2. Time Complexity To Solve This using While Loop is  O(log base 10(num))
        // 3. Num % 10 Get Us Last Digit :- 2
        // 4. Num % 100 Get Us Last Two Digits :- 52 ... So , On
        // 5. Num / 10 Deletes Last Digit :- 1245 
        // 6. If , Remainder is  Zero , then Dividing N / zero , Will Get Us Runtime Error.
        // 7. Num = Digit * 10 ,where Consider Num has Arleady 12452 , Digit = 3 will become 124523

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Related To Plaindrome 
        // 1. If Numer 121 , its reverse is also 121 , then it is plaindrome
        // 2. -ve  numbers cannot be plaindrome , single digits are palindrome
        // 3. we can use reverse digits logic to solve this 

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Divisiblity Rule Of Nine.
        // 1. If Given No. is 0 , then result will be 0 
        // 2. If given No % 9 ==0 , then result will be 9.
        // 3. If given No % 9 == Any Single Digit Number, that will be the result.

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Number With Exactly three Divisors
        // 1. First number Need to be PErfect Square :-> 4 = 2*2
        // 2. 2nd Squared Number Should be Prime : - 2 is Prime.
        // 3. then Following Number has 3 divisor only.

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Number With Exactly two Divisor / Prime Number
        // 1. Number Dvided By 1 or itself


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Smallest +Ve number Divided By both n and 2 are 
        // 1. Even numbe : n itself
        // 2. Odd number : n*2

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Find a Way How Many ways, we can Store the Equal Digits in array in a equal Pairs...
        // -> Eg :- [2,2] [3,3] [1,1] or [2,2,2,2,2] [3,3,3,3,3] etc
        // 1 . Store all the elements frequency in a dictory ..
        // 2 . Find the GCD of All the Frquency.

        #endregion

    }
}
