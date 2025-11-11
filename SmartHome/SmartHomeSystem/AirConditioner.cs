using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeSystem
{
    public class AirConditioner : Device, IEnergyConsumer
    {
        public string DeviceName => Name;
        public int PowerConsumption => 2000;
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почав охолодження.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} зупинено.");
        }
        public double GetEnergyUsage(int hours)
        {
            if (IsOn) { return PowerConsumption * hours / 1000; }
            else { return 0; }
        }
    }
}
