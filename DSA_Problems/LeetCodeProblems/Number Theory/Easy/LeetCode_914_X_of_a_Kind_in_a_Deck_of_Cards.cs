using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Number_Theory.Easy
{
    class LeetCode_914_X_of_a_Kind_in_a_Deck_of_Cards
    {
        public LeetCode_914_X_of_a_Kind_in_a_Deck_of_Cards()
        {
            solution();
        }

        private void solution()
        {
            int[] arr = new int[]
            {
                1,2,2,1,1,1
            };

            Dictionary<int, int> Dict = new Dictionary<int, int>();             
            for(int i = 0; i < arr.Length; i++)
            {
                int val = -1;
                if(Dict.TryGetValue(arr[i],out val))
                {
                    Dict[arr[i]] = ++val;
                }
                else
                {
                    Dict.Add(arr[i], 1);
                }
            }
            bool flag = true;
            int a = Dict.Values.FirstOrDefault();
          
            foreach(var b in Dict)
            {
                a = GCD(a, b.Value);
                if(a <= 1)
                {
                    return;
                }
            }
        }

        public int GCD(int a, int b)
        {
            if(b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
    }


}

// Point To Remember 

// Consider Given  Array With Some Numbers Like 
// 1, 1, 1, 2, 2 ,2 ,2 ,3, 3 ,3 ,3 ,1
// I want to check if they all can be grouped into similary type of blocks
// Eg :- [1, 1, 1, 1] [2,2,2,2] [3,3,3,3]   or
//        [1 ,1 ] [1 ,1 ] [2 , 2 ] [2 , 2] [3 , 3] [3 , 3]

// Instead of Doing that , i can get the frequescy of each number in dictionary 
// Then find the GCD of each Number  , that way we can check if the number can vbe Divided into Equal block with similar lements. 
// We can Find out the Smallest or Largest Block They Can be All Paired.

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Time Complexity : O(n + O(K * log(max Frequency))) 
// max Frequency can be wtitten as min(a,b)
// n :- denotes time taken to fill the list.

// Space Compleixty : O(k) --> O(log base k N)
// Dictonar will store the frequency of each unique elemnts...If  N are Tolal and K  are total Unique  and K < N
 