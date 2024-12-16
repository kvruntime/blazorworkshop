using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Domain.Services
{
    public interface IOrderService
    {
        ValueTask PlaceOrder(Customer customer, ShoppingBasket basket);
    }
}