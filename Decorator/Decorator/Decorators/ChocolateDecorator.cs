using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators;

public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee) { }
    public override string GetDescription()
        => $"{base.GetDescription()}, Chocolate";
    public override decimal GetCost()
        => base.GetCost() + 2.00m;

}
