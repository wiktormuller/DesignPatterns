using System;

namespace Observer
{
    public class FirstObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0)
            {
                Console.WriteLine("First Observer: Reached the event of 0 degrees.");
            }
        }
    }
}