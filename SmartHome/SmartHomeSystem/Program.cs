namespace SmartHomeSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SmartHomeController controller = new SmartHomeController();
            Light light = new Light { Name = "Лампа у вітальні" };
            AirConditioner airConditioner = new AirConditioner { Name = "Кондиціонер у спальні" };
            CoffeeMachine coffeeMachine = new CoffeeMachine { Name = "Кавомашина на кухні" };
            MotionSensor motionsensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(light);
            controller.AddDevice(airConditioner);
            controller.AddDevice(coffeeMachine);
            controller.AddDevice(motionsensor);

            controller.AddEnergyDevice(light);
            controller.AddEnergyDevice(airConditioner);
            controller.AddEnergyDevice(coffeeMachine);

            controller.TurnAllOn();

            Console.WriteLine("");

            light.PrintStatus();
            airConditioner.PrintStatus();
            coffeeMachine.PrintStatus();
            motionsensor.PrintStatus();

            Console.WriteLine("");

            controller.ShowEnergyReport(5);

            Console.WriteLine("");

            controller.TurnAllOff();
        }
    }
}
