using PizzeriaServices.Shared_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Pizza_Factory
{
    public interface IPizzaFactory
    {
        List<PizzaMenu> GetPizzas();
        List<Toppings> GetToppings();
    }
}
