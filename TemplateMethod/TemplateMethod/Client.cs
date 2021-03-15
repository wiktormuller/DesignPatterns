namespace TemplateMethod
{
    public class Client
    {
        //The ClientCode cals the template method to execute algorithm.
        //ClientCode does not have to know the concrete class of an object it
        //works with, as lon as it works with objects through the interface of
        //their base class.
        public static void ClientCode(AbstractClass abstractClass)
        {
            //...
            abstractClass.TemplateMethod();
            //...
        }
    }
}