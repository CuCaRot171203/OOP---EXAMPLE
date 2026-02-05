using POLYMOPHISM.Models;
using POLYMOPHISM.Orders;
using POLYMOPHISM.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Services
{
    public class OrderService
    {
        private readonly IOrderType _orderType;
        private readonly IPayment _payment;

        public OrderService(IOrderType orderType, IPayment payment)
        {
            _orderType = orderType;
            _payment = payment;
        }

        public void Process(Product product, int quantity)
        {
            Console.WriteLine($"\n🧾 HÌNH THỨC: {_orderType.Name}");
            decimal total = _orderType.CalculateTotal(product, quantity);

            Console.WriteLine($"{product.Name} x {quantity}");
            Console.WriteLine($"Tổng tiền: {total:N0} VNĐ");
            Console.WriteLine($"Thanh toán bằng: {_payment.Name}\n");

            _payment.Pay(total);
        }
    }
}
