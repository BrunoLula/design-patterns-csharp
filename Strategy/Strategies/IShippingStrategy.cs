using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Context;

public interface IShippingStrategy
{
    decimal CalculateShippingCost(decimal orderAmount);

    void ShipOrder(string orderId);
}
