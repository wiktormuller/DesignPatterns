﻿using System;

namespace Composite
{
    //The base Component class declares common operations for both simple and complex objects of a composition.
    public abstract class Component
    {
        public Component()
        {
        }

        //May implement some default behavior or leave it to concrete classes (by declaring the method containing the behavior as "abstract")
        public abstract string Operation();
        
        
        //Sometimes, it would be beneficial to define the child-management operations right in the base Component class.
        //This way, you won't need to expose any concrete component classes to the client code, even during the object tree assembly.
        //The downside is that these methods will be empty for leaf-level components.
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        //You can provide a method that lets the client code figure out whether a component can bear children.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}