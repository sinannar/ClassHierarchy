using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{
    /*
     * One thing to note that interface can define a property with only a get accessor and implmeenting type also has a set accessor
     */
    interface IReadOnlyInterface
    {
        int Value { get; }
    }

    struct ReadAndWriteImplementation : IReadOnlyInterface
    {
        public int Value { get; set; }
    }
    /*
    In this case, the implementing class adds an extra set accessor. The advantage of using this
    pattern is that if a user accesses your class through its interface, it will see only the get accessor.
    Direct users of the class will see both the get and the set accessor. 
     */
}
