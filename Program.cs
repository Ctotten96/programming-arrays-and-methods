using System;

namespace ProgrammingArraysAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            while (true)
            {
                Console.WriteLine("Please enter an integer number between 5 and 15:");
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());

                    if (length >= 5 && length <= 15)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please ensure the number is between 5 and 15.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }

            int[] numbers = ArrayMethods.PopulateRandomArray(length);
            Console.WriteLine("The elements of the array are: " + string.Join(" ", numbers));
            int sum = ArrayMethods.SumArray(numbers);
            Console.WriteLine("The sum is: " + sum);
        }
    }

    public static class ArrayMethods
    {
        public static int[] PopulateRandomArray(int length)
        {
            int[] numbers = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(10, 51); // 51 because upper bound is exclusive
            }

            return numbers;
        }

        public static int SumArray(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
