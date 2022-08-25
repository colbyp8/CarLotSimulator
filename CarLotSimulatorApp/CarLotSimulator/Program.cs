using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var lot = new CarLot();
            

            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "4-Runner";
            myCar.Year = 2000;
            myCar.EngineNoise = "RRRRR";
            myCar.HonkNoise = "Honk";
            myCar.IsDrivable = true;

            lot.Cars.Add(myCar);

            var neighborsCar = new Car()
            {
                Year = 2022,
                Make = "Chevrolet",
                Model = "Corvette",
                EngineNoise = "Vroooooooom",
                HonkNoise = "Beep",
                IsDrivable = true

            };
            lot.Cars.Add(neighborsCar);

            var friendsCar = new Car(2016, "Honda", "Civic", "vrroom", "HMMM", true);

            lot.Cars.Add(friendsCar);

            myCar.MakeEngineNoise();
            neighborsCar.MakeEngineNoise();
            friendsCar.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
