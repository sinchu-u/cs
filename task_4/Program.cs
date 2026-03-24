using System.Security.Cryptography.X509Certificates;

namespace task_4
{
    internal class Program
    {
        //public static Func<double, double, double> Add = (first, second) => first + second;
        //public static Func<double, double, double> Subtract = (first, second) => first - second;
        //public static Func<double, double, double> Multiply = (first, second) => first * second;
        //public static Func<double, double, double> Divide = (first, second) => first / second;
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Add(5.7, 3.4));
        //    Console.WriteLine(Subtract(5.7, 3.4));
        //    Console.WriteLine(Multiply(5.7, 3.4));
        //    Console.WriteLine(Divide(5.7, 3.4));
        //}
        static void Main()
        {
            List<string> students = ["Маша", "Настя", "Руся", "Зоря", "Оксана", "Марго", "Альона"];
            string letter = "М";
            List<string> results = students.FindAll(student => student.StartsWith(letter));
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
