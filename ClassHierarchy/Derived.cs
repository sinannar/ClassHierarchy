using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{
    //CHANGING BEHAVIOUR
    class Base
    {
        protected virtual void Execute()
        { }
    }

    class Derived : Base
    {
        protected override void Execute()
        {
            Log("Before executing");            base.Execute();
            Log("After executing");        }

        private void Log(string message) { /* some logging code */ }
    }


    //HIDING A METHOD WITH A NEW KEYWORD
    class Base2
    {
        public void Execute()
        {
            Console.WriteLine("Base2.Execute");
        }
    }

    class Derived2 : Base2
    {
        public new void Execute()
        {
            Console.WriteLine("Derived2.Execute");
        }
    }


    class Program2
    {
        static void Main(string[] args)
        {
            Base2 b = new Base2();
            b.Execute();
            b = new Derived2();
            b.Execute();
        }
    }


    //CREATING AN ABSTRACT CLASS
    abstract class Base3
    {
        public virtual void MethodWithImplementation() {/*Method with implementation*/}
        public abstract void AbstractMethod();
    }
    class Derived3 : Base3
    {
        public override void AbstractMethod() { }
    }
}
