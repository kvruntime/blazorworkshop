using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Domain
{
    public class Pizza
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public required decimal Price { get; init; }
        public required Spiciness Spiciness { get; init; }
    }
}