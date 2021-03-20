﻿namespace AbstractFactory
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunction()
        {
            return "The result of the product B2.";
        }

        //The variant, Product B2, is only able to work correctly with the variant, ProductA2. Nevertheless, it accepts
        //any instance of AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}