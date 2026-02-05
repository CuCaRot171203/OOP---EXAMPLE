using POLYMOPHISM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Payments
{
    public static class PaymentFactory
    {
        public static IPayment Create(PaymentType type)
        {
            return type switch
            {
                PaymentType.Cash => new CashPayment(),
                PaymentType.BankTransfer => new BankTransferPayment(),
                _ => throw new NotSupportedException("Payment type không hỗ trợ")
            };
        }
    }
}
