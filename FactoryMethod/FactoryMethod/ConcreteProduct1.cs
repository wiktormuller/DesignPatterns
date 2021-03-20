namespace ConsoleApp1
{
    //Concrete Products provide various implementations of the Product interface.
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result from the ConcreteProduct1}";
        }
    }
}