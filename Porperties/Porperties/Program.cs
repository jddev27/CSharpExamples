using System;

namespace Porperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car() {Color = "Red", Make = "Honda", Model = "Accord", NumberOfDoors = 4};
            myCar.DisplayCar();
        }
    }

    public class Car
    {

        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfDoors { get; set; }

        public void DisplayCar()
        {
            Console.WriteLine( $"Your car is a: {Make} {Model} {Color} of {NumberOfDoors} doors" );

        }
    }
}