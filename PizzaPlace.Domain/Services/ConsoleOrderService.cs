using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PizzaPlace.Domain.Services
{
    public class ConsoleOrderService : IOrderService
    {
        public ValueTask PlaceOrder(Customer customer, ShoppingBasket basket)
        {
            System.Console.WriteLine($"Placing order for {customer.Name}");
            return new ValueTask();
        }
    }
}