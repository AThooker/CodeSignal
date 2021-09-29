using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1,2,1,2};
            //Console.WriteLine(IncreasingSequence(intArray));
            Console.WriteLine(GetSumRange(1,5));
            Console.ReadLine();
        }

        public static bool checkPalindrome(string inputString)
        {
            char[] inputArray = inputString.ToCharArray();
            Array.Reverse(inputArray);
            var reversed = new string(inputArray);
            if (reversed == inputString)
            {
                return true;
            }
            return false;
        }

        //Find which two elements next to each other in the array return the largest product
        public int adjacentElementsProduct(int[] inputArray)
        {
            int p = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length; i++)
            {
                int produtctAdj = inputArray[i] * inputArray[i + 1];
                if (produtctAdj > p)
                {
                    p = produtctAdj;
                }
            }
            return p;
        }

        public static int MakeArrayConsecutiveTwo(int[] statues)
        {
            return statues.Max() - statues.Min() + 1 - statues.Length;
        }


        //Method to test if you could remove no more than one element to make a strictly increasing array
        public static bool IncreasingSequence(int[] sequence)
        {
            int counter = 0;
            if(sequence.Length == 2)
            {
                return true;
            }
            for(int i = 0; i < sequence.Length; i++)
            {
                if(sequence[i] >= sequence[i + 1])
                {
                    counter++;
                    bool skipFor = i + 2 < sequence.Length && sequence[i + 2] <= sequence[i];
                    bool skipBack = i - 1 >= 0 && sequence[i + 1] <= sequence[i - 1];
                    if(skipBack && skipFor || counter > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int GetSumRange(int a, int b)
        {
            if(a == b)
            {
                return a;
            }
            return Math.Abs((b * (b + 1) - (a - 1) * a)) / 2;
        }
    }
}
