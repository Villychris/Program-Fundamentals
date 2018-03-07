using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int length = Math.Min(firstArr.Length, secondArr.Length);

            int equalElements = 0;

            for (int index = 0; index < length; index++)
            {
                if (firstArr[index] == secondArr[index])
                {
                    equalElements++;
                }
            }

            Array.Reverse(firstArr);

            secondArr = secondArr.Reverse().ToArray();

            int reversedCounter = 0;

            for (int index = 0; index < length; index++)
            {
                if (firstArr[index] == secondArr[index])
                {
                    reversedCounter++;
                }
            }

            if (equalElements > reversedCounter)
            {
                Console.WriteLine(equalElements);
            }
            else
            {
                Console.WriteLine(reversedCounter);
            }
               

           
        }
    }
}
