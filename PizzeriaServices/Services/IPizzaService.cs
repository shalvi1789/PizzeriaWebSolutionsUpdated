using PizzeriaServices.Shared_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Services
{
    public interface IPizzaService
    {
        List<PizzaMenu> GetAllPizza();
        List<Toppings> GetAllToppings();
    }
}
