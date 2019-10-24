using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string radius;
            double user_radius;

            Console.WriteLine("Enter a radius");

            radius = Console.ReadLine();
            user_radius = double.Parse(radius);

            if (user_radius < 0)
            {
                Console.WriteLine("Negative numbers not allowed. Please try again.");  
                    }
            else
            {
                double area = 3.14 * user_radius * user_radius;

                Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
            }

            /*do
            {
                Console.WriteLine("Enter a radius");

                radius = Console.ReadLine();
            }
            while (user_radius < 0); */


            Console.ReadLine();

        }
    }
}
