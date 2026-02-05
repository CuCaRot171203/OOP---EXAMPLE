using POLYMOPHISM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMOPHISM.Payments
{
    public interface IPayment
    {
        PaymentType Type{ get; }
        string Name { get; }
        void Pay(decimal amount);
    }
}
