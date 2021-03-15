using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    public class Subject : ISubject
    {
        //We can delegate the part of maintaining subscription list to some helper class, like: EventManager.
        //"However, if you’re applying the pattern to an existing class hierarchy, consider an approach based on composition:
        //put the subscription logic into a separate object, and make all real publishers use it."
        public int State { get; set; } = 0;

        //Subscription list have to be dynamic, so subscribers can join or leave the list whenever they need to,.
        private List<IObserver> _observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void BusinessLogic()
        {
            Console.WriteLine("\nSubject: I`m doing something important.");
            this.State = new Random().Next(0, 10);
            
            Thread.Sleep(10000);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
        }
    }
}