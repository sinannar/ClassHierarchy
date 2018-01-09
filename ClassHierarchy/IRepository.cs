using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{
    /*
     * You can use generics when defining interfaces. Example as Repository pattern is below.
     */
    interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }
}
