using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var firstSubscriber = new FirstObserver();
            subject.Attach(firstSubscriber);

            var secondSubscriber = new SecondObserver();
            subject.Attach(secondSubscriber);
            
            subject.BusinessLogic();
            subject.BusinessLogic();
            
            subject.Detach(secondSubscriber);
            
            subject.BusinessLogic();
        }
    }
}