using PizzeriaServices.Shared_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Services
{
    public class PizzaService:IPizzaService
    {
        public PizzaService()
        {
            //Initialize db context
        }
        public List<PizzaMenu> GetAllPizza()
        {
            List<PizzaMenu> pizza = new List<PizzaMenu>();
            pizza.Add(new PizzaMenu { Id = "001", Name = "Pepproni Pizza", Price = 200, Size = 9, Base="Thin Crust" , Type="ABC"});
            pizza.Add(new PizzaMenu { Id = "002", Name = "ABC Pizza", Price = 300, Size = 12 , Base="Wheat", Type="XYZ"});
            return pizza;
        }
        public List<Toppings> GetAllToppings()
        {
            List<Toppings> toppings = new List<Toppings>();
            toppings.Add(new Toppings { Id = 10, Name = "Cheese", Price = 30 });
            toppings.Add(new Toppings { Id = 11, Name = "Ketchup", Price = 40 });
            return toppings;
        }
    }
}
