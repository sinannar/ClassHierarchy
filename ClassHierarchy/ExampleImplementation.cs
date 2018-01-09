using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{

    /*
     * Capital I is convention in C# for iterfaces. Interfaces are key concept in C#
     * Interface contains the public signature of methods, properties, events and indexers
     * A type, class and struct, can implement an interface
     */
    interface IExample
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get; set; }    }

    /*
     * All interface elementes are public since there is no access modifiers are mentioned in interfaces
     * It is not possible to implement and change the acecss modifier to anything other than public
     */

    class ExampleImplementation : IExample
    {
        public string GetResult()
        {
            return "result";
        }
        public int Value { get; set; }
        public event EventHandler CalculationPerformed;
        public event EventHandler ResultRetrieved;
        public int this[string index]
        {
            get
            {
                return 42;
            }
            set { }
        }
    }
}
