using POLYMOPHISM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Orders
{
    public static class OrderTypeFactory
    {
        public static IOrderType Create(OrderType type)
        {
            return type switch
            {
                OrderType.Buy => new BuyOrder(),
                OrderType.Rent => new RentOrder(),
                _ => throw new NotSupportedException("Order Type không hợp lệ")
            };
        }
    }
}
