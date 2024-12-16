using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Domain
{
    public class State
    {
        public Pizza[] Pizzas { get; set; } = [];
        public ShoppingBasket Basket { get; } = new();
        public decimal TotalPrice => Basket.Orders.Sum(id => GetPizza(id)!.Price);
        public Pizza? GetPizza(Guid id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
        public Customer Customer { get; set; } = new()
        {
            Name = string.Empty,
            Street = string.Empty,
            City = string.Empty,
            ZipCode = string.Empty
        };

    }
}