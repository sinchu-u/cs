namespace task_2
{
    internal class Program
    {
        public class MessagePublisher
        {
            public delegate void MessageEvent(string text);
            public event MessageEvent MessageSend;
            public void Send(string text)
            {
                MessageSend.Invoke(text);
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
