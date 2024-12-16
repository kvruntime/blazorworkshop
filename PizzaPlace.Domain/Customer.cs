using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Domain
{
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string ZipCode { get; set; }
    }
}