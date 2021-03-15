using System;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        //The TemplateMethod defines the skeleton of an algorithm
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of work.");
        }
        
        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subClasses override some operations.");
        }
        
        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway.");
        }
        
        //These operations have to be implemented in subclasses.
        protected abstract void RequiredOperations1();
        protected abstract void RequiredOperation2();
        
        //There are "hooks". Subclasses may override them, but it's not mandatory
        //since the hooks already have default (but empty) implementation.
        //Hooks provide additional extension points in some crucial places of the algorithm.
        protected virtual void Hook1()
        {
        }

        protected virtual void Hook2()
        {
        }
    }
}