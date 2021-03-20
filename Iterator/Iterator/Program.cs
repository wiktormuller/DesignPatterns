﻿using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //The ClientCode may or not know about the ConcreteIterator
            //or Collection classes, depending on the level of indirection you
            //want to keep in your program
            var collection = new WordCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");
            
            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}