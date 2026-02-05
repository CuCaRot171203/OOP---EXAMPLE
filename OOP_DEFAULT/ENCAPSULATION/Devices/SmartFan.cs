using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCAPSULATION.Devices
{
    public class SmartFan : ISmartDevice
    {
        // Encapsulation
        private bool _isRunning = false;

        public void TurnOn()
        {
            _isRunning = true;
            Console.WriteLine("Fan is running");
        }

        public void TurnOff()
        {
            _isRunning = false;
            Console.WriteLine("Fan is turn off");
        }

        public string GetStatus()
        {
            return _isRunning ? "Fan is Running" : "Fan is turn Off";
        }
    }
}
