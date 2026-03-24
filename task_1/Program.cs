namespace task_1
{
    internal class Program
    {
        public delegate double MathOperation(double first, double second);
        public static double Add(double first, double second)
        {
            return first + second;
        }
        public static double Subtract(double first, double second)
        {
            return first - second;
        }
        public static double Multiply(double first, double second)
        {
            return first * second;
        }
        public static double Divide(double first, double second)
        {
            return first / second;
        }
        static void Main(string[] args)
        {
            MathOperation operation = Add;
            Console.WriteLine(operation(5.7, 3.4));
            operation = Subtract;
            Console.WriteLine(operation(5.7, 3.4));
            operation = Multiply;
            Console.WriteLine(operation(5.7, 3.4));
            operation = Divide;
            Console.WriteLine(operation(5.7, 3.4));
        }
    }
}
