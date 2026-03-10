using System;
using System.Collections.Generic;

namespace NewsObserver
{
    class NewsAgency
    {
        private static NewsAgency instance;

        private List<INewsSubscriber> subscribers = new List<INewsSubscriber>();

        private string news;

        // Costruttore privato
        private NewsAgency() { }

        // Singleton
        public static NewsAgency Instance
        {
            get
            {
                if (instance == null)
                    instance = new NewsAgency();

                return instance;
            }
        }

        // Proprietà News
        public string News
        {
            get { return news; }
            set
            {
                news = value;
                Notify();
            }
        }

        public void Subscribe(INewsSubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(INewsSubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        private void Notify()
        {
            foreach (var sub in subscribers)
            {
                sub.Update(news);
            }
        }
    }
}