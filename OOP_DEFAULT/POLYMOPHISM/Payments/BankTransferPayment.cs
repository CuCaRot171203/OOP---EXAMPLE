using POLYMOPHISM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Payments
{
    public class BankTransferPayment : IPayment
    {
        public PaymentType Type => PaymentType.BankTransfer;
        public string Name => "Chuyển khoản";
        public void Pay(decimal amount)
        {
            Console.Write("Nhập số tài khoản: ");
            string account = Console.ReadLine()!;

            Console.Write("Nhập tên người chuyển: ");
            string nameAccount = Console.ReadLine()!;

            Console.Write("Nhập CCV: ");
            string CCV = Console.ReadLine()!;

            Console.WriteLine($"{nameAccount} đã chuyển {amount:N0} VNĐ");
            Console.WriteLine($"Giao dịch thành công");
        }
    }
}
