using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATION.Devices
{
    public class SmartLight : ISmartDevice
    {
        // Phương thức đóng gói
        private bool _isOn = false;

        // Phương thức thay đổi trạng thái
        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Light is turn on");
        }

        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Light is turn off");
        }

        // Method to get status, couldn't be change
        public string GetStatus()
        {
            return _isOn ? "Light is turn ON" : "Light is turn OFF";
        }
    }
}
