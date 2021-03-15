using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    //The Client code is usually suited to work with a single handler.
    //In most cases, it is not even aware that the handler is part of a chain.
    public class Client
    {
        public static void ClientCode(BaseHandler handler)
        {
            var setOfFood = new List<string> { "Nut", "Banana", "Cup of coffee"};
            
            foreach (var food in setOfFood)
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.WriteLine($"    {result}");
                }
                else
                {
                    Console.WriteLine($"    {food} was left untouched");
                }
            }
        }
    }
}