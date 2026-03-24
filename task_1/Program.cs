namespace task_1
{
    internal class Program
    {
        public class TemperatureChip
        {
            public delegate void TemperatureHandler (int temperature);
            public event TemperatureHandler TemperatureRecived;
            public void GetTemperature (int temperature)
            {
                TemperatureRecived?.Invoke (temperature);
            }
        }
        public class Display
        {
            public void DisplayTemperature(int temperature)
            {
                Console.WriteLine($"Temperature: {temperature}");
            }
            public void Subscribe (TemperatureChip chip)
            {
                chip.TemperatureRecived += DisplayTemperature;
            }
        }
        public class AirConditioner
        {
            public void OnTemperatureChange(int temperature)
            {
                if (temperature <= 17)
                {
                    Console.WriteLine("обігрів");
                }
                else if (temperature > 17 && temperature < 25)
                {
                    Console.WriteLine("кондиціонер вимкнений");
                }
                else 
                {
                    Console.WriteLine("охолодження");
                }
            }
            public void Subscribe(TemperatureChip chip)
            {
                chip.TemperatureRecived += OnTemperatureChange;
            }
        }
        public class SecuritySystem
        {
            public void OnCriticTemperature (int temperature)
            {
                if (temperature >= 40)
                {
                    Console.WriteLine("перегрів");
                }
                else if (temperature <= 5)
                {
                    Console.WriteLine("перехолодження");
                }
            }
            public void Subscribe(TemperatureChip chip)
            {
                chip.TemperatureRecived += OnCriticTemperature;
            }
        }
        static void Main(string[] args)
        {
            TemperatureChip chip = new TemperatureChip();
            Display display = new Display();
            AirConditioner airConditioner = new AirConditioner();
            SecuritySystem securitySystem = new SecuritySystem();
            display.Subscribe(chip);
            airConditioner.Subscribe(chip);
            securitySystem.Subscribe(chip);
            chip.GetTemperature(16);
            chip.GetTemperature(20);
            chip.GetTemperature(30);
            chip.GetTemperature(0);
            chip.GetTemperature(50);
        }
    }
}
