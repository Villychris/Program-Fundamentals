using System;
using System.Linq;

namespace _7._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startIndesx = 0;
            int currentLenght = 1;
            int maxStart = 0;
            int maxLenght = 1;

            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] > numbers[index - 1])
                {
                    currentLenght++;

                    if (currentLenght > maxLenght)
                    {
                        maxLenght = currentLenght;
                        maxStart = startIndesx;
                    }
                }
                else
                {
                    currentLenght = 1;
                    startIndesx = index;

                }
            }
            for (int index = maxStart; index < maxStart + maxLenght; index++)
            {
                Console.Write(numbers[index] + " ");
            }
            Console.WriteLine();
        }
    }
}
