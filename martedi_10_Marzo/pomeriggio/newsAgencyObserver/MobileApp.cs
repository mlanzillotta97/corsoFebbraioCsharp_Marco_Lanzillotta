using System;

namespace NewsObserver
{
    class MobileApp : INewsSubscriber
    {
        public void Update(string news)
        {
            Console.WriteLine("Notification on mobile: " + news);
        }
    }
}