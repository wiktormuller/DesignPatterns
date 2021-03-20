﻿namespace Bridge
{
    //The abstraction defines the interface for the 'control' part of two class hierarchies.
    //It maintains a reference to an object of the Implementation hierarchy and delegates all
    //of the real works to this objects.
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
        }
    }
}