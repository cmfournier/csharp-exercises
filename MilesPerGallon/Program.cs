using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            string miles;
            string gallons;
            double num_miles;
            double num_gallons;
            double mpg;

            Console.WriteLine("How many miles did you drive?");
            miles = Console.ReadLine();
            num_miles = double.Parse(miles);

            Console.WriteLine("How many gallons did you use?");
                gallons = Console.ReadLine();
            num_gallons = double.Parse(gallons);

            mpg = num_miles / num_gallons;

            Console.WriteLine("Your fuel efficiency was " + mpg + " miles per gallon");
        }
    }
}
