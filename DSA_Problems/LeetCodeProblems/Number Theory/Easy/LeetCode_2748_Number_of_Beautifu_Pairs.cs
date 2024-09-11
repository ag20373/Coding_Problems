using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.LeetCodeProblems.Number_Theory.Easy
{
    class LeetCode_2748_Number_of_Beautifu_Pairs
    {
        public LeetCode_2748_Number_of_Beautifu_Pairs()
        {
            Solution();
        }

        public void Solution()
        {
            int[] arr = new int[]
            {
                11,21,12
            };

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    string a1 = arr[i].ToString();
                    int a = Convert.ToInt32(a1[0]-'0');

                    string b1 = arr[j].ToString();
                    int b = Convert.ToInt32(b1[b1.Length -1]-'0');

                    int Gcd1 = Gcd(a, b);
                    if (Gcd1 == 1)
                    {
                        Console.WriteLine(Gcd1);
                    }
                }
            }
        }

        private int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Gcd(b, a % b);
            }
        }
    }
}
