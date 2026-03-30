using System;

namespace constructorCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Mustang", 2022, "blue");
            Car car2 = new Car("Lamborghini", "Gallardo", 2012, "white");

            car1.Drive();
            car2.Drive();



            Console.ReadKey();
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive a {color} {make} {model} from year {year}");
        }
    }
}