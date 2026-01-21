using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class CinnamonDecorator : CoffeeDecorator
    {
        public CinnamonDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription()
            => $"{base.GetDescription()}, Cinnamon";
        public override decimal GetCost()
            => base.GetCost() + 1.00m;
    {
    }
}
