namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 74, 70, 93, 77, 98, 63, 87, 93, 97, 100 };
            jaggedArray[1] = new int[] { 94, 92, 98, 76, 66, 91, 86, 64, 68, 63 };
            jaggedArray[2] = new int[] { 81, 74, 87, 94, 96, 100, 98, 84, 68, 95 };
            PrintGroupStatistics(jaggedArray);
        }
        public static void PrintGroupStatistics(int[][] groups)
        {
            Console.WriteLine("Група 1: Середній = " + GetAverage(groups[0]) + ", Мінімальний = " + GetMin(groups[0]) + ", Максимальний = " + GetMax(groups[0]));
            Console.WriteLine("Група 2: Середній = " + GetAverage(groups[1]) + ", Мінімальний = " + GetMin(groups[1]) + ", Максимальний = " + GetMax(groups[1]));
            Console.WriteLine("Група 3: Середній = " + GetAverage(groups[2]) + ", Мінімальний = " + GetMin(groups[2]) + ", Максимальний = " + GetMax(groups[2]));
        }
        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return sum / marks.Length;
        }
        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            for (int i = 0; i < marks.Length; i++)
            {
                if(min > marks[i])
                {
                    min = marks[i];
                }
            }
            return min;
        }
        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            for (int i = 0; i < marks.Length; i++)
            {
                if (max < marks[i])
                {
                    max = marks[i];
                }
            }
            return max;
        }
    }
}