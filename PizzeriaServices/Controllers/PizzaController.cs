using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzeriaServices.Pizza_Factory;
using PizzeriaServices.Shared_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaClient PizzaClient;
        public PizzaController(IPizzaClient pizzaClient)
        {
            PizzaClient = pizzaClient;
        }
        [HttpGet]
        [Route("pizzaMenu")]
        public IActionResult GetPizzaMenus()
        {
            var response = PizzaClient.GetPizzaMenus();
            if(response!=null && response.Any())
            {
                return Ok(response);
            }
            return NotFound();
        }
    }
}
