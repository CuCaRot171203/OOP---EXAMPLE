using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{
    public class SmsNofitication : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Send SMS: {message}");
        }
    }
}
