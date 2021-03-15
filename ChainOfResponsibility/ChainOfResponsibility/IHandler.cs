namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); //To build the chain of handlers
        object Handle(object request);  //To handle request
    }
}