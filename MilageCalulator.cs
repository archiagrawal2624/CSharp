using System;
namespace milage;
class Calculator{
    public static void Main(string[] args){
          Console.WriteLine("Mileage Calculator");
            Console.WriteLine("------------------");

            // Get the distance traveled from the user
            Console.Write("Enter the distance traveled (in km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Get the amount of fuel consumed from the user
            Console.Write("Enter the amount of fuel consumed (in L): ");
            double fuelConsumed = Convert.ToDouble(Console.ReadLine());

            // Calculate the mileage
            double mileage = CalculateMileage(distance, fuelConsumed);

            // Display the result
            Console.WriteLine($"The mileage is: {mileage:F2} Km per L");
        }

        static double CalculateMileage(double distance, double fuelConsumed)
        {
            // Calculate the mileage
            double mileage = distance / fuelConsumed;

            return mileage;
        }
    }
