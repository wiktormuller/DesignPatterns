using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SameClient code can work with different subclasses:");
            
            Client.ClientCode(new ConcreteClass1());

            Console.WriteLine("\n");

            Console.WriteLine("SameClient code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}