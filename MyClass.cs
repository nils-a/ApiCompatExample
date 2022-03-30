using System;

namespace ApiCompatExample
{
    [My]
    public class MyClass
    {
        public void SomethingIsRequiredInTheClass()
        {
        }
        
        /*
        public void AddThisAsANonBreakingChange()
        {
        }
        */
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyAttribute : Attribute
    {
    }
}

