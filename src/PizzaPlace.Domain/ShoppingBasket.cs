using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Domain
{
    public class ShoppingBasket
    {
        public List<Guid> Orders { get; } = [];
        public void Add(Guid pizzaId)
        => Orders.Add(pizzaId);
        public void RemoveAt(int pos)
        => Orders.RemoveAt(pos);
    }
}