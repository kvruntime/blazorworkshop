using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Domain.Services
{
    public interface IMenuService
    {
        ValueTask<Pizza[]> GetMenu();
    }
}