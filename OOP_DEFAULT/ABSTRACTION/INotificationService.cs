using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{
    // Đưa ra phương thức để gọi đến nhưng không biết cách thực hiện bên trong
    public interface INotificationService
    {
        void Send(string message);
    }
}
