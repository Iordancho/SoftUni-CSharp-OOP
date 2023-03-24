using System;
namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = new Vehicle(100, 15);
            car.Drive(100);
            Console.WriteLine(car.Fuel);

        }
    }
}
