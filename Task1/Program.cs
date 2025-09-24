namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMessage(number));
        }
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else return false;
        }
        public static string GetMessage(int number)
        {
            if (IsEven(number))
            {
                return "Двері відкриваються!";
            }
            else return "Двері зачинені...";
        }
    }
}
