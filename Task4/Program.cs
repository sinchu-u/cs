using System;
namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть першу сторону:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть другу сторону:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть третю сторону:");
            double c = Convert.ToDouble(Console.ReadLine());

            if(IsValidTriangle(a, b, c))
            {
                GetPerimeter(a, b, c);
                GetArea(a, b, c);
                GetTriangleType(a, b, c);
            }
        }
        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a < b + c && b < a + c && c < a + b;
        }
        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        public static double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        }
        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && a == c && b == c)
            {
                return "рівносторонній";
            }
            else if(a == b || a == c || b == c)
            {
                return "рівнобедрений";
            }
            else if(Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
            {
                return "прямокутний";
            }
            else
            {
                return "довільний";
            }
        }
    }
}