using POLYMOPHISM.Enum;
using POLYMOPHISM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Orders
{
    public class RentOrder : IOrderType
    {
        public OrderType Type => OrderType.Rent;
        public string Name => "Thuê đồ";
        public decimal CalculateTotal(Product product, int quantity)
        {
            return product.Price * 0.3m * quantity;
        }
    }
}
