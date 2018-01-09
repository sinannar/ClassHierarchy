using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{
    class Order : IEntity
    {
        public int Id { get; }
    }

    class OrderRepository : Repository<Order>
    {
        public OrderRepository(IEnumerable<Order> orders) : base(orders)
        {

        }

        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
        {
            List<Order> result = null;

            return result;
        }
    }
}
