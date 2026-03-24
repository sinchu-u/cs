namespace task_5
{
    public class Logger
    {
        public Action<string>? LogHandler;
        public void Log(string message)
        {
            if (LogHandler != null)
            {
                LogHandler(message);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.LogHandler = message => Console.WriteLine(message);
            logger.Log("hehe");
            logger.LogHandler = message => Console.WriteLine(message.ToUpper());
            logger.Log("haha");
        }
    }
}
