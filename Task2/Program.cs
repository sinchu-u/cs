using System;
namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = 5;
            int min = 1;
            int max = 100;
            int[] array = GenerateRandomArray(size, min, max);
            Console.Write("Масив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Сума елементів: " + GetSum(array));
            Console.WriteLine("Середнє арифметичне: " + GetAverage(array));
            Console.WriteLine("Мінімум: " + GetMin(array));
            Console.WriteLine("Максимум: " + GetMax(array));
        }
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }
        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public static double GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (double)sum/numbers.Length;
        }
        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}