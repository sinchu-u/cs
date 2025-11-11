using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        public List<ISwitchable> devices = new List<ISwitchable>();
        public List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();
        public void AddDevice(ISwitchable device) {
            devices.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer device) {
            energyDevices.Add(device);
        }
        public void TurnAllOn() {
            foreach (ISwitchable device in devices)
            {
                device.TurnOn();
            }
        }
        public void TurnAllOff() { 
            foreach (ISwitchable device in devices)
            {
                device.TurnOff();
            }
        }
        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double totalEnergy = 0;
            foreach (IEnergyConsumer device in energyDevices)
            {
                IEnergyConsumer currentDevice = device;
                double energy = currentDevice.GetEnergyUsage(hours);
                totalEnergy += energy;
                Console.WriteLine($"{currentDevice.DeviceName}: {energy:F2} кВт·год (потужність: {currentDevice.PowerConsumption} Вт)");
            }
            Console.WriteLine($"Загальне споживання: {totalEnergy:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {totalEnergy * 4:F2} грн");
        }
    }
}
