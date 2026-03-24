namespace task_2
{
    internal class Program
    {
        public delegate void NotificationHandler(string message);
        public static void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: [{message}]");
        }
        public static void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent: [{message}]");
        }
        static void Main(string[] args)
        {
            NotificationHandler notification = SendEmail;
            notification += SendSMS;
            notification("Hello World!");
        }
    }
}
