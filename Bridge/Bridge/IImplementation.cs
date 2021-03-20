namespace Bridge
{
    //The Implementation defines the interface for all implementation classes.
    //It doesn't have to match the Abstraction's interface. In fact, the two interfaces 
    //can be entirely different. Typically the implementation interface provides only primitive operations
    //while the Abstraction defines high-level operations based on those primitives.
    public interface IImplementation
    {
        string OperationImplementation();
    }
}