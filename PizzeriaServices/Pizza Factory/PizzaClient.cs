using PizzeriaServices.Shared_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Pizza_Factory
{
    public class PizzaClient:IPizzaClient
    {
        private IPizzaFactory PizzaFactory;
        public PizzaClient(IPizzaFactory pizzaFactory)
        {
            PizzaFactory = pizzaFactory;
        }
        public void CreatePizza()
        {
            throw new NotImplementedException();
        }
        public List<PizzaMenuResponseModel> GetPizzaMenus()
        {
            List<PizzaMenuResponseModel> response = new List<PizzaMenuResponseModel>();
            var result = PizzaFactory.GetPizzas();
            if(result!=null && result.Any())
            {
                response = result.Select(x => new PizzaMenuResponseModel
                {
                    Name = x.Name,
                    Rate=x.Price.ToString(),
                    Base=x.Base,
                    Type=x.Type
                }).ToList();
            }
            return response;
        }
    }
}
