using System;

namespace Observer
{
    public class SecondObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 10 || (subject as Subject).State == 10)
            {
                Console.WriteLine("SecondSubscriber: Reached to the event");
            }
        }
    }
}