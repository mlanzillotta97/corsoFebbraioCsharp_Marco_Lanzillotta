using System;

namespace NewsObserver
{
    class EmailClient : INewsSubscriber
    {
        public void Update(string news)
        {
            Console.WriteLine("Email sent: " + news);
        }
    }
}