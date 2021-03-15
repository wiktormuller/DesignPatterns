namespace Observer
{
    public interface ISubject
    {
        //Add observers to subscribers' list
        void Attach(IObserver observer);
        //Remove observers from subscribers' list
        void Detach(IObserver observer);
        //Notify all observers about an event
        void Notify();
    }
}