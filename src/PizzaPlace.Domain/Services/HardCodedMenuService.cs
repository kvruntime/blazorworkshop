using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Domain.Services
{
    public class HardCodedMenuService : IMenuService
    {
        public ValueTask<Pizza[]> GetMenu()
        {
            Pizza[] Pizzas = [
    new Pizza {
Id = Guid.Parse("d8eb5b4c-22e5-4341-9c62-8991b09fd86b"),
Name = "Pepperoni",
Price = 8.99M,
Spiciness = Spiciness.Spicy },
new Pizza {
Id = Guid.Parse("66fb968b-a751-47c1-9537-3ad948a00c6f"),
Name = "Margherita",
Price = 7.99M,
Spiciness = Spiciness.None },
new Pizza {
Id = Guid.Parse("95995ec0-7336-4a1f-b4cd-8730f27ba87f"),
Name = "Diavola",
Price = 9.99M,
Spiciness = Spiciness.Hot }];
            return ValueTask.FromResult(Pizzas);
        }
    }
}