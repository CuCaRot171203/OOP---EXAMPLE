using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{
    public class EmailNotification : INotificationService
    {
        // Thực thi (IMPLEMENT) code
        public void Send(string message)
        {
            Console.WriteLine($"Gửi Email: {message}");
        }
    }
}
