using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Problems.Section_1_Basics.Lecture_3_Maths
{
    class Problem_2_Calculator
    {
        public Problem_2_Calculator()
        {
            Solution();
        }

        public void Solution()
        {
            int Number1 = 2;
            int Number2 = 6;
            int result = 0;
            
            string Operation = String.Empty;
            Console.WriteLine("Enter the Operation to be Performed");
            Operation = Console.ReadLine(); // O(n)
            string flag= "Y"; 
            while (flag.ToUpper() != "N") // Runs for O(User Input Size)
            {
                switch (Operation.ToUpper()) //-- Runs For O(1) times
                {
                    case "ADD" :
                        result = Number1 + Number2;
                        Console.WriteLine("Addition is : "+result);
                        break;
                    case "MULTIPLY":
                        result = Number1 * Number2;
                        Console.WriteLine("Multiply is : " + result);
                        break;
                    case "SUBTRACT":
                        result = Number1 - Number2;
                        Console.WriteLine("Subtraction is : " + result);
                        break;
                    case "DIVIDE":
                        result = Number1 / Number2;
                        Console.WriteLine("Division is : " + result);
                        break;
                    default :
                        Console.WriteLine("Invalid Operation");
                        flag = "Y";
                        continue;
                }

                Number1 = result;
                Console.WriteLine("Do You Want To Continue With More Operation, Press Y for Yes or N for No ");
                flag = Console.ReadLine();
                if (flag.ToUpper() == "Y")
                {
                    Console.WriteLine("Enter A Number Again , to Continue");
                    Number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Operation to be Performed");
                    Operation = Console.ReadLine();
                }
                Console.WriteLine();
            }
        }
    }
}

// Console.ReadLine Takes Order of O(n) time compleixty -- Based Upon Size Of Input ,It reads all the input one by one.
// "string".ToUpper() Also Take O(n) Time Complexity --- Bcoz System Iterate Through Whole String Input Once to make it upper.
// Space Complexty : O(1) And Time Compleixty is O(Kn) Time
// Switch case Runs for O(1) time, but Depondend upon input size of Program.