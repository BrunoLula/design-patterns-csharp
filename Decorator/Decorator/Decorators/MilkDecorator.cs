using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators;

public class MilkDecorator : CoffeeDecorator
{
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
            => $"{base.GetDescription()}, Milk";

        public override decimal GetCost()
            => base.GetCost() + 1.50m;
}

