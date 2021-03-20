namespace Adapter
{
    //Defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }
}