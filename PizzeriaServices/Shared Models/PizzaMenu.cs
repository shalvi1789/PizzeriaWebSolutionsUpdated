using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Shared_Models
{
    public class PizzaMenu:Pizza
    {
        public string Base { get; set; }
        public string Type { get; set; }
    }
}
