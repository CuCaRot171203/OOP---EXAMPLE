using POLYMOPHISM.Enum;
using POLYMOPHISM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Orders
{
    public interface IOrderType
    {
        OrderType Type { get; }
        string Name { get; }
        decimal CalculateTotal(Product product, int quantity);
    }
}
