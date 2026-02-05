using POLYMOPHISM.Enum;
using POLYMOPHISM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Orders
{
    public class BuyOrder : IOrderType
    {
        public OrderType Type => OrderType.Buy;
        public string Name => "Mua đồ";

        /// <summary>
        /// Phương thức xử lý với mua đồ
        /// </summary>
        /// <param name="product">Sản phẩm</param>
        /// <param name="quantity">Số lượng</param>
        /// <returns>Tiền mua đồ</returns>
        public decimal CalculateTotal(Product product, int quantity)
        {
            return product.Price * quantity;
        }
    }
}
