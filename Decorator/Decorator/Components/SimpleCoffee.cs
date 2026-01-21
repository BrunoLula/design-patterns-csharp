using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Components
{
    internal class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }
        public decimal GetCost()
        {
            return 2.0m;
        }
    }
}
