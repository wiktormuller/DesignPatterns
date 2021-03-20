namespace Adapter
{
    //Contains some useful behavior, but its interface is incompatible with the existing client code.
    //THe Adaptee needs some adaptation before client code can use it.
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}