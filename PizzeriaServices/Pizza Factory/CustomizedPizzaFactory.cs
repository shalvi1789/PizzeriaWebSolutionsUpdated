using PizzeriaServices.Services;
using PizzeriaServices.Shared_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Pizza_Factory
{
    public class CustomizedPizzaFactory:IPizzaFactory
    {
        private IPizzaService PizzaService;
        public CustomizedPizzaFactory(IPizzaService pizzaService)
        {
            PizzaService = pizzaService;
        }
        public List<PizzaMenu> GetPizzas()
        {
            return PizzaService.GetAllPizza();
        }

        public List<Toppings> GetToppings()
        {
            return PizzaService.GetAllToppings();
        }

    }
}
