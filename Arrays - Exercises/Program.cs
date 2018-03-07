using System;
using System.Linq;

namespace Arrays___Exercises
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {


                int[] result = new int[numbers.Length - 1];
                result[0] = numbers[0] + numbers[1];
                result[1] = numbers[1] + numbers[2];

                numbers[0] = result[0] + result[1];

                Console.WriteLine(numbers[i]);
            }

        }
    }
}