using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Shared_Models
{
    public abstract class PizzaToppings
    {
        public Toppings Topping { get; set; }

        public int ToppingId { get; set; }

        public int PizzaId { get; set; }
    }
}
