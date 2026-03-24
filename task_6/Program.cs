namespace task_6
{
    internal class Program
    {
        public delegate bool Validator(string input);
        public static Validator GetValidator(int minLength)
        {
            return input => input != null && input.Length >= minLength;
        }

        static void Main()
        {
            Validator passwordValidator = GetValidator(8);
            Validator loginValidator = GetValidator(3);

            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine();

            Console.WriteLine("\nПеревірка логіна:");
            Console.WriteLine(loginValidator(login) ? "Логін підходить" : "Логін занадто короткий");

            Console.WriteLine("\nПеревірка пароля:");
            Console.WriteLine(passwordValidator(password) ? "Пароль підходить" : "Пароль занадто короткий");
        }
    }
}