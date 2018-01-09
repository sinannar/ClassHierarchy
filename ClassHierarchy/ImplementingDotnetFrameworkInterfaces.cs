using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy2
{
    ///////////////////////////////////////////////////////////////////////////////////////
    //IComparable
    class Order : IComparable
    {
        public DateTime Created { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Order o = obj as Order;
            if (o == null)
            {
                throw new ArgumentException("Object is not an Order");
            }
            return this.Created.CompareTo(o.Created);
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////
    //IEnumerable
    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " +LastName;
        }
    }

    class People : IEnumerable<Person>
    {
        public People(Person[] people)
        {
            this.people = people;
        }
        Person[] people;

        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////
    //IDisposable
    /*

        public interface IDisposable
        {
            void Dispose();
        }

      */
    ///////////////////////////////////////////////////////////////////////////////////////
    //IUnknown
    /*
            Before .NET existed, the first generation of the Windows API was based on a library of functions
        contained in a dynamic-link library (DLL). Later generations collected these functions
        into a Component Object Model (COM) interface. The .NET Framework provides classes that
        wrap much of these APIs in a managed version so that in normal life you almost never touch
        any COM components directly.
            Normally, you just add a reference to a COM object and the compiler generates the necessary
        wrapper classes called COM Interop classes. If this fails for some reason, you have to
        create the wrapper class; this is where the IUnknown interface is used.        
    */
    ///////////////////////////////////////////////////////////////////////////////////////
    //EXMPLES
    public class Test
    {
        public Test()
        {

            //TESTING COMPARABLE
            List<Order> orders = new List<Order>
            {
             new Order { Created = new DateTime(2012, 12, 1 )},
             new Order { Created = new DateTime(2012, 1, 6 )},
             new Order { Created = new DateTime(2012, 7, 8 )},
             new Order { Created = new DateTime(2012, 2, 20 )},
            };
            orders.Sort();

            //INTRO TO IENUMERABLE
            List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9 };
            using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
            }
        }
    }
}
