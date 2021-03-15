using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //The client code can parametrize an invoker with any commands.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));

            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
            
            invoker.DoSomethingImportant();
        }
    }
}