using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Signal;
using static Signal.Signal;

namespace TrafficLightEnum
{
    internal class Program
    {

        
        
        static void Main(string[] args)
        {
            SignalController controller = new SignalController();

            Console.WriteLine("Available Traffic Light Signals:");
            foreach (TrafficLight signal in Enum.GetValues(typeof(TrafficLight)))
            {
                Console.WriteLine($"{(int)signal} - {signal}");
            }

            Console.Write("\nEnter the signal number 0 for Red, 1 for Yellow, 2 for Green: ");
            int input = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(TrafficLight), input))
            {
                TrafficLight selectedSignal = (TrafficLight)input;
                controller.ShowSignal(selectedSignal);
            }
            else
            {
                Console.WriteLine("Invalid signal number.");
            }

            


    }
    }
}
