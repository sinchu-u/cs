namespace task_3
{
    internal class Program
    {
        public delegate bool FilterPredicate(int number);
        public static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (int number in numbers)
            {
                if (predicate(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
        static void Main()
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            FilterArray(numbers, isEven);
            FilterArray(numbers, biggerThan5);
        }
        public static bool isEven(int number) => number % 2 == 0;
        public static bool biggerThan5(int number)
        {
            if (number > 5) return true;
            else return false;
        }
    }
}
