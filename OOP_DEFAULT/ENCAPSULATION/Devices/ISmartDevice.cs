using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATION.Devices
{
    // Abstraction here
    /// <summary>
    /// Không quan tâm thiết bị làm được gì
    /// và không quan tâm phải làm thế nào
    /// </summary>
    public interface ISmartDevice
    {
        void TurnOn();

        void TurnOff();

        string GetStatus();
    }
}
