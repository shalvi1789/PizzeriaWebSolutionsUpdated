using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Shared_Models
{
    public class PizzaMenuResponseModel
    {
        public string Name { get; set; }
        public string Rate { get; set; }
        public string Base { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }

    }
}
