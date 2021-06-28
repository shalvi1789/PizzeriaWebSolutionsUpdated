using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaServices.Shared_Models
{
    public abstract class Pizza
    {
        public const int DefaultSize = 12;
        public const int MinimumSize = 9;
        public const int MaximumSize = 17;
        public string Id { get; set; }
        public string Name { get;  set; }
        public string OrdeId { get;  set; }
        public int Size { get;  set; }
        public decimal Price { get; set; }       
        public List<PizzaToppings> Toppings { get; set; }
        public CustomizedPizza CustomizedPizza { get; set; }
        public decimal BasePrice => ((decimal)Size / (decimal)DefaultSize) * CustomizedPizza.BasePrice;

        public decimal TotalPrice => BasePrice + Toppings.Sum(t => t.Topping.Price);

        public string FormattedTotalPrice => TotalPrice.ToString("0.00");
    }
}
