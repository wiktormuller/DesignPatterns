using System;

namespace Mediator
{
    public class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");
            this._mediator.Notify(this, "A");
        }
        
        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");
            _mediator.Notify(this, "B");
        }
    }
}