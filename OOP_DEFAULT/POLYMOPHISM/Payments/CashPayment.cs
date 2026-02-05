using POLYMOPHISM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Payments
{
    public class CashPayment : IPayment
    {
        public PaymentType Type => PaymentType.Cash;

        public string Name => "Tiền mặt";

        public void Pay(decimal amount)
        {
            // Đưa ra thông báo và nhập số tiền vào
            Console.WriteLine("Nhập số tiền khách đưa");
            decimal given = decimal.Parse(Console.ReadLine()!);

            // Kiểm tra số dư đầu vào
            if(given < amount)
            {
                Console.WriteLine("Không đủ tiền!");
                return;
            }

            // Nếu thanh toán thành công
            Console.WriteLine($"Thanh toán thành công");
            Console.WriteLine($"Tiền thừa : {given - amount:N0} VNĐ");
        }
    }
}
